using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLiBanDoNoiDiaTrung.Entities;
namespace QuanLiBanDoNoiDiaTrung.DataAccess
{
    class BanHang_DAL
    {
        public void docFile(List<BanHang> list)
        {
            try
            {
                StreamReader streamReader = new StreamReader("banhang.txt");
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split(";");
                    list.Add(new BanHang(arr[0], arr[1], arr[2],arr[3],int.Parse(arr[4]),int.Parse(arr[5])));
                }
                streamReader.Close();
            }
            catch (Exception e)
            {
                e.GetType();
            }
        }
        public void ghiFile(List<MatHang> list)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter("banhang.txt");
                foreach (MatHang matHang in list)
                {
                    streamWriter.WriteLine(matHang.ToString());
                }
                streamWriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
