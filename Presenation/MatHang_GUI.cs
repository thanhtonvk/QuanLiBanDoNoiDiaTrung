using System;
using System.Collections.Generic;
using System.Text;
using QuanLiBanDoNoiDiaTrung.BussinessLogic;
using QuanLiBanDoNoiDiaTrung.DataAccess;
using QuanLiBanDoNoiDiaTrung.Entities;

namespace QuanLiBanDoNoiDiaTrung.Presenation
{
    class MatHang_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("                                 ══════════════════════════════════════════════════");
            Console.WriteLine("                                 ║                  QUẢN LÝ MẶT HÀNG                ║");
            Console.WriteLine("                                 ║══════════════════════════════════════════════════║");
            Console.WriteLine("                                 ║1. Nhập thêm mặt hàng                             ║");
            Console.WriteLine("                                 ║2. Hiện thị danh sách                             ║");
            Console.WriteLine("                                 ║3. Sửa thông tin                                  ║");
            Console.WriteLine("                                 ║4. Xóa mặt hàng                                   ║");
            Console.WriteLine("                                 ║5. Tìm kiếm                                       ║");
            Console.WriteLine("                                 ║0.Thoát                                           ║");
            Console.WriteLine("                                 ║══════════════════════════════════════════════════║");
        }
        public static void Run(MatHang_BLL matHang_BLL, MatHang_DAL matHang_DAL, List<MatHang> list)
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
                        matHang_BLL.NhapThongTin(list);
                        matHang_DAL.ghiFile(list);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        matHang_BLL.hienDanhSach(list);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        matHang_BLL.CapNhat(list);
                        matHang_DAL.ghiFile(list);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        matHang_BLL.Xoa(list);
                        matHang_DAL.ghiFile(list);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        matHang_BLL.TimKiem(list);
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
