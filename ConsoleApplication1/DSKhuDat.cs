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
            Console.Write("Nhap so luong khu dat moi mua: ");
            n = int.Parse(Console.ReadLine());

            List<KhuDat> listKhuDat = new List<KhuDat>();
            Console.Write("Nhap thong tin ve khu dat");
            for(int i = 0; i < n; i++)
            {
                KhuDat temp = new KhuDat();
                temp.Input();
                listKhuDat.Add(temp);
            }

            return listKhuDat;
        }
        public static void XuatDSKhuDat(List<KhuDat> listKhuDat)
        {
            Console.WriteLine("Xuat Danh Sach Khu Dat Dang Quan Ly: ");
            foreach(KhuDat kd in listKhuDat)
            {
                kd.Show();
            }
        }

    }
}
