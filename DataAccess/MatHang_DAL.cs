using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLiBanDoNoiDiaTrung.Entities;
namespace QuanLiBanDoNoiDiaTrung.DataAccess
{
    class MatHang_DAL
    {
        public void docFile(List<MatHang> list)
        {
            try
            {
                StreamReader streamReader = new StreamReader("mathang.txt");
                string line;
                while((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split(";");
                    list.Add(new MatHang(arr[0], arr[1], arr[2], int.Parse(arr[3]), int.Parse(arr[4])));
                }
                streamReader.Close();
            }catch(Exception e)
            {
                e.GetType();
            }
        }
        public void ghiFile(List<MatHang> list)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter("mathang.txt");
                foreach(MatHang matHang in list)
                {
                    streamWriter.WriteLine(matHang.ToString());
                }
                streamWriter.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
