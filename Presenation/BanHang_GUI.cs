using System;
using System.Collections.Generic;
using System.Text;
using QuanLiBanDoNoiDiaTrung.BussinessLogic;
using QuanLiBanDoNoiDiaTrung.DataAccess;
using QuanLiBanDoNoiDiaTrung.Entities;
namespace QuanLiBanDoNoiDiaTrung.Presenation
{
    class BanHang_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("                                 ══════════════════════════════════════════════════");
            Console.WriteLine("                                 ║                  QUẢN LÝ BÁN HÀNG                ║");
            Console.WriteLine("                                 ║══════════════════════════════════════════════════║");
            Console.WriteLine("                                 ║1. Nhập hóa đơn                                   ║");
            Console.WriteLine("                                 ║2. Xuất hóa đơn                                   ║");
            Console.WriteLine("                                 ║3. Cập nhật kho hàng                              ║");
            Console.WriteLine("                                 ║4. Mặt hàng bán chạy                              ║");
            Console.WriteLine("                                 ║5. Thống kê doanh thu theo ngày                   ║");
            Console.WriteLine("                                 ║6. Thống kê doanh thu theo tháng                  ║");
            Console.WriteLine("                                 ║7. Khách hàng đã mua                              ║");
            Console.WriteLine("                                 ║0.Thoát                                           ║");
            Console.WriteLine("                                 ║══════════════════════════════════════════════════║");
        }
        public static void Run(BanHang_BLL banHang_BLL, BanHang_DAL banHang_DAL, List<MatHang> matHangs, List<BanHang> banHangs, MatHang_BLL matHang_BLL)
        {

            int chon;
            while (true)
            {
                Menu();
                //chọn chức  năng
                chon = int.Parse(Console.ReadLine());
                //nếu nhập = 0 thì dừng chương trình
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        banHang_BLL.NhapHoaDon(matHangs, banHangs, matHang_BLL);
                        banHang_DAL.ghiFile(matHangs);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        banHang_BLL.XuaHoaDon(banHangs);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        banHang_BLL.CapNhatKhoHang(matHangs, banHangs);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        banHang_BLL.ThongKeBanChay(banHangs, matHangs, matHang_BLL);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        banHang_BLL.ThongKeDoanhThuTheoNgay(banHangs);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        banHang_BLL.ThongKeDoanhThuTheoThang(banHangs);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        banHang_BLL.KhachHang(banHangs);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: break;
                }
            }
        }
    }
}
