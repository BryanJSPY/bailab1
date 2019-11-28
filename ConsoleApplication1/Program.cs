using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KhuDat> listKhuDat = DSKhuDat.NhapDSKhuDat();
            List<NhaPho> listNhaPho = DSNhaPho.NhapDSNhaPho();
            List<ChungCu> listChungCu = DSChungCu.NhapDSChungCu();
            //c4(listKhuDat, listNhaPho);
            c5(listKhuDat, listNhaPho, listChungCu);
            Console.ReadLine();
        }

        public static void c4(List<KhuDat> listKhuDat, List<NhaPho> listNhaPho)
        {
            List<KhuDat> listKQKD = listKhuDat.Where(p => p.DienTich > 100).ToList();
            List<NhaPho> listKQNP = listNhaPho.Where(p => p.DienTich > 60 && p.NamXayDung >= 2019).ToList();
            if(listKQKD.Count > 0)
            {
                Console.WriteLine("\n===Nhung khu dat co dien tich > 100m2");
                DSKhuDat.XuatDSKhuDat(listKQKD);
            }else
            {
                Console.WriteLine("\n===Khong tim thay khu dat co dien tich > 100m2");
            }

            if (listKQNP.Count > 0)
            {
                Console.WriteLine("\n===Nhung nha pho co dien tich > 60m2 va nam xay dung >= 2019");
                DSNhaPho.XuatDSNhaPho(listKQNP);
            }
            else
            {
                Console.WriteLine("\n===Khong tim thay nha pho co dien tich > 60m2 va nam xay dung >= 2019");
            }
        }

        public static void c5(List<KhuDat> listKhuDat, List<NhaPho> listNhaPho, List<ChungCu> listChungCu)
        {
            KhuDat temp = new KhuDat();
            Console.WriteLine("\n===Tim Kiem thong tin Bat Dong San theo yeu cau: ");
            temp.Input();
            Console.WriteLine("");

            List<KhuDat> listKQKD = listKhuDat.Where(p => p.DiaDiem.IndexOf(temp.DiaDiem) > -1 && p.DienTich >= temp.DienTich && p.GiaBan <= temp.GiaBan).ToList();
            List<NhaPho> listKQNP = listNhaPho.Where(p => p.DiaDiem.IndexOf(temp.DiaDiem) > -1 && p.DienTich >= temp.DienTich && p.GiaBan <= temp.GiaBan).ToList();
            List<ChungCu> listKQCC = listChungCu.Where(p => p.DiaDiem.IndexOf(temp.DiaDiem) > -1 && p.DienTich >= temp.DienTich && p.GiaBan <= temp.GiaBan).ToList();
            if (listKQKD.Count > 0)
            {
                Console.WriteLine("\n===Nhung khu dat gan giong theo yeu cau:");
                DSKhuDat.XuatDSKhuDat(listKQKD);
            }
            else
            {
                Console.WriteLine("\n===Khong tim thay khu dat gan giong theo yeu cau.");
            }

            if (listKQNP.Count > 0)
            {
                Console.WriteLine("\n===Nhung nha pho gan giong theo yeu cau:");
                DSNhaPho.XuatDSNhaPho(listKQNP);
            }
            else
            {
                Console.WriteLine("\n===Khong tim thay nha pho gan giong theo yeu cau.");
            }

            if (listKQCC.Count > 0)
            {
                Console.WriteLine("\n===Nhung chung cu gan giong theo yeu cau:");
                DSChungCu.XuatDSChungCu(listKQCC);
            }
            else
            {
                Console.WriteLine("\n===Khong tim thay chung cu gan giong theo yeu cau.");
            }
        }
    }
}
