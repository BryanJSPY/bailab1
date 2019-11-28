using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DSKhuDat
    {   
        public static List<KhuDat> NhapDSKhuDat()
        {
            int n = 0;
            Console.Write("\n===Nhap so luong ['KHU DAT'] moi mua: ");
            n = int.Parse(Console.ReadLine());

            List<KhuDat> listKhuDat = new List<KhuDat>();
            Console.WriteLine("\n===Nhap thong tin ve ['KHU DAT']: ");
            for(int i = 0; i < n; i++)
            {
                KhuDat temp = new KhuDat();
                Console.WriteLine("Khu Dat [{0}]:",i+1);
                temp.Input();
                Console.WriteLine("");
                listKhuDat.Add(temp);
            }

            return listKhuDat;
        }
        public static void XuatDSKhuDat(List<KhuDat> listKhuDat)
        {
            Console.WriteLine("\n===Xuat Danh Sach Khu Dat Dang Quan Ly: ");
            foreach(KhuDat kd in listKhuDat)
            {
                Console.WriteLine("");
                kd.Show();
            }
        }
    }
}
