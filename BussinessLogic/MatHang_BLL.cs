using QuanLiBanDoNoiDiaTrung.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLiBanDoNoiDiaTrung.BussinessLogic
{
    class MatHang_BLL
    {
        public void NhapThongTin(List<MatHang> list)
        {
            string ma = "MH" + list.Count;
            Console.Write("                                     Nhập tên mặt hàng: ");
            string ten = Console.ReadLine();
            Console.Write("                                     Nhập loại:         ");
            string loai = Console.ReadLine();
            Console.Write("                                     Nhập số lượng      ");
            int soluong = int.Parse(Console.ReadLine());
            Console.Write("                                     Nhập giá:          ");
            int gia = int.Parse(Console.ReadLine());
            list.Add(new MatHang(ma, ten, loai, soluong, gia));
        }
        public void hien(MatHang matHang)
        {
            Console.WriteLine("                                     |{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", matHang.Ma, matHang.Ten, matHang.Loai, matHang.Soluong, matHang.Gia);
        }
        public void hienDanhSach(List<MatHang> list)
        {

            Console.WriteLine("                                     |{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "Mã mặt hàng", "Tên mặt hàng", "Loại mặt hàng", "Số lượng", "Giá");
            foreach (MatHang matHang in list)
            {
                hien(matHang);
            }
        }
        public MatHang timMatHang(List<MatHang> list)
        {
            MatHang ketqua = null;
            Console.Write("                                     Nhập tên hoặc mã cần tìm: ");
            string tukhoa = Console.ReadLine();
            foreach (MatHang matHang in list)
            {
                if (tukhoa.Equals(matHang.Ma) || tukhoa.Equals(matHang.Ten))
                {
                    ketqua = matHang;
                }
            }
            return ketqua;
        }
        public void TimKiem(List<MatHang> list)
        {
            MatHang matHang = timMatHang(list);
            if (matHang == null)
            {
                Console.WriteLine("                                     Không tìm thấy mặt hàng");

            }
            else
            {
                hien(matHang);
            }
        }
        public void CapNhat(List<MatHang> list)
        {
            MatHang matHang = timMatHang(list);
            if (matHang == null)
            {
                Console.WriteLine("                                     Không tìm thấy mặt hàng");

            }
            else
            {
                Console.Write("                                     Nhập tên mặt hàng: ");
                matHang.Ten = Console.ReadLine();
                Console.Write("                                     Nhập loại:         ");
                matHang.Loai = Console.ReadLine();
                Console.Write("                                     Nhập số lượng      ");
                matHang.Soluong = int.Parse(Console.ReadLine());
                Console.Write("                                     Nhập giá:          ");
                matHang.Gia = int.Parse(Console.ReadLine());
                Console.WriteLine("                                     Cập nhật thành công");
            }
        }
        public void Xoa(List<MatHang> list)
        {
            MatHang matHang = timMatHang(list);
            if (matHang == null)
            {
                Console.WriteLine("                                     Không tìm thấy mặt hàng");

            }
            else
            {
                list.Remove(matHang);
            }
        }
    }
}
