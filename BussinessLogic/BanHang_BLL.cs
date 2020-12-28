using System;
using System.Collections.Generic;
using System.Text;
using QuanLiBanDoNoiDiaTrung.Entities;
namespace QuanLiBanDoNoiDiaTrung.BussinessLogic
{
    class BanHang_BLL
    {
        public void NhapHoaDon(List<MatHang> matHangs, List<BanHang> banHangs, MatHang_BLL matHang_BLL)
        {

            MatHang matHang = matHang_BLL.timMatHang(matHangs);
            if (matHang == null)
            {
                Console.WriteLine("                         Mặt hàng không tồn tại");
            }
            else
            {
                Console.Write("                         Nhập tên khách hàng: ");
                string ten = Console.ReadLine();
                Console.Write("                         Nhập số lượng mua : ");
                int soluong = int.Parse(Console.ReadLine());
                Console.Write("                         Nhập ngày mua(ngày/tháng/năm)     : ");
                string ngay = Console.ReadLine();
                int tongtien = soluong * matHang.Gia;
                banHangs.Add(new BanHang(ten, matHang.Ma, matHang.Ten, ngay, soluong, tongtien));
            }

        }
        public void XuaHoaDon(List<BanHang> banHangs)
        {
            Console.Write("                         Nhập tên khách hàng: ");
            string ten = Console.ReadLine();
            foreach (BanHang banHang in banHangs)
            {
                if (ten.Equals(banHang.Tenkhachhang))
                {
                    Console.WriteLine("                   HÓA ĐƠN");
                    Console.WriteLine("                         Tên khách hàng: " + banHang.Tenkhachhang);
                    Console.WriteLine("                         Tên mặt hàng hàng: " + banHang.Tenmathang);
                    Console.WriteLine("                         Ngày mua: " + banHang.Ngaymua);
                    Console.WriteLine("                         Số lượng: " + banHang.Soluong);
                    Console.WriteLine("                         Tổng tiền: " + banHang.Tongtien);

                }
            }
        }
        public void CapNhatKhoHang(List<MatHang> matHangs, List<BanHang> banHangs)
        {
            Console.WriteLine("Các mặt hàng được bán là: ");
            foreach (MatHang matHang in matHangs)
            {
                foreach (BanHang banHang in banHangs)
                {
                    if (matHang.Ma.Equals(banHang.Mamathang))
                    {
                        Console.WriteLine(matHang.Ten);
                        matHang.Soluong = matHang.Soluong - banHang.Soluong;
                    }
                }
            }
        }
        public void ThongKeBanChay(List<BanHang> banHangs, List<MatHang> matHangs, MatHang_BLL matHang_BLL)
        {
            BanHang ketqua = null;
            int max = int.MinValue;
            foreach (BanHang banHang in banHangs)
            {
                if (max < banHang.Soluong)
                {
                    max = banHang.Soluong;
                    ketqua = banHang;
                }
            }
            Console.WriteLine("                                     Mặt hàng bán chạy là: ");
            foreach (MatHang matHang in matHangs)
            {
                if (ketqua.Mamathang.Equals(matHang.Ma))
                {
                    matHang_BLL.hien(matHang);
                }
            }
        }
        public void ThongKeDoanhThuTheoNgay(List<BanHang> banHangs)
        {
            int tong = 0;
            Console.Write("                         Nhập ngày(ngày/tháng/năm): ");
            string ngay = Console.ReadLine();
            foreach (BanHang banHang in banHangs)
            {
                if (ngay.Equals(banHang.Ngaymua))
                {
                    tong += banHang.Tongtien;
                }
            }
            Console.Write("                         Doanh thu trong ngày là: " + tong);
        }
        public void ThongKeDoanhThuTheoThang(List<BanHang> banHangs)
        {
            int tong = 0;
            Console.Write("                         Nhập tháng(tháng/năm): ");
            string ngay = Console.ReadLine();
            foreach (BanHang banHang in banHangs)
            {
                if (banHang.Ngaymua.Contains(ngay))
                {
                    tong += banHang.Tongtien;
                }
            }
            Console.WriteLine("                         Doanh thu trong tháng là: " + tong);
        }
        public void KhachHang(List<BanHang> banHangs)
        {
            Console.WriteLine("                         Nhưng khách hàng đã mua là:");
           
            foreach (BanHang banHang in banHangs)
            {
                Console.WriteLine("                       "+banHang.Tenkhachhang);
            }
        }
    }
}
