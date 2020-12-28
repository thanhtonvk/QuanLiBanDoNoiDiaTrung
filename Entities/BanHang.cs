using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLiBanDoNoiDiaTrung.Entities
{
    class BanHang
    {
        private string tenkhachhang, mamahang, tenmathang, loai, ngaymua;
        private int soluong, tongtien;
        public BanHang(string tenkhachhang,string mamahang,string tenmathang,string ngaymua,int soluong,int tongtien)
        {
            this.tenkhachhang = tenkhachhang;
            this.mamahang = mamahang;
            this.tenmathang = tenmathang;
            this.ngaymua = ngaymua;
            this.soluong = soluong;
            this.Tongtien = tongtien;
        }
        public override string ToString()
        {
            return tenkhachhang + ";" + mamahang + ";" + tenmathang + ";" + loai + ";" + ngaymua + ";" + soluong+";"+Tongtien;
        }
        public string Tenkhachhang { get => tenkhachhang; set => tenkhachhang = value; }
        public string Mamathang { get => mamahang; set => mamahang = value; }
        public string Tenmathang { get => tenmathang; set => tenmathang = value; }
        public string Loai { get => loai; set => loai = value; }
        public string Ngaymua { get => ngaymua; set => ngaymua = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
    }
}
