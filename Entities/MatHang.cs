using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLiBanDoNoiDiaTrung.Entities
{
    class MatHang
    {
        private string ma, ten, loai;
        private int soluong, gia;
        public MatHang(string ma,string ten,string loai,int soluong,int gia)
        {
            this.ma = ma;
            this.ten = ten;
            this.loai = loai;
            this.soluong = soluong;
            this.gia = gia;
        }
        public override string ToString()
        {
            return ma + ";" + ten + ";" + loai + ";" + soluong + ";" + gia;
        }
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Loai { get => loai; set => loai = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Gia { get => gia; set => gia = value; }
    }
}
