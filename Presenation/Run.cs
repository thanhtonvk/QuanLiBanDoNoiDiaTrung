using System;
using System.Collections.Generic;
using System.Text;
using QuanLiBanDoNoiDiaTrung.BussinessLogic;
using QuanLiBanDoNoiDiaTrung.Entities;
using QuanLiBanDoNoiDiaTrung.DataAccess;
namespace QuanLiBanDoNoiDiaTrung.Presenation
{
    class Run
    {
        public static void Menu()
        {
            Console.WriteLine("                                 ════════════════════════════════════════════════════");
            Console.WriteLine("                                 ║           QUẢN LÍ BÁN ĐỒ NỘI ĐỊA TRUNG           ║");
            Console.WriteLine("                                 ║══════════════════════════════════════════════════║");
            Console.WriteLine("                                 ║1. Quản lí mặt hàng                               ║");
            Console.WriteLine("                                 ║2. Quản lí bán hàng                               ║");
            Console.WriteLine("                                 ║0. Thoát                                          ║");
            Console.WriteLine("                                 ════════════════════════════════════════════════════");
        }
        public static void run()
        {
            BanHang_BLL banHang_BLL = new BanHang_BLL();
            MatHang_BLL matHang_BLL = new MatHang_BLL();
            BanHang_DAL banHang_DAL = new BanHang_DAL();
            MatHang_DAL matHang_DAL = new MatHang_DAL();
            List<MatHang> matHangs = new List<MatHang>();
            List<BanHang> banHangs = new List<BanHang>();
            matHang_DAL.docFile(matHangs);
            banHang_DAL.docFile(banHangs);
            int chon;
            while (true)
            { Menu();
                chon = int.Parse(Console.ReadLine());
                if (chon == 0) break;
               
                switch (chon)
                {
                    case 1:
                        MatHang_GUI.Run(matHang_BLL, matHang_DAL, matHangs);
                        break;
                    case 2:
                        BanHang_GUI.Run(banHang_BLL, banHang_DAL, matHangs, banHangs, matHang_BLL);
                        break;
                    default:break;
                }
            }
        }
    }
}
