using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class KhuDat
    {
        public string DiaDiem { get; set; }
        public int DienTich { get; set; }
        public double GiaBan { get; set; }

        public KhuDat()
        {

        }

        public KhuDat(string diaDiem, int dienTich, double giaBan)
        {
            DiaDiem = diaDiem;
            DienTich = dienTich;
            GiaBan = giaBan;
        }

        public void Input()
        {
            Console.Write("Nhap Diem Dia Diem Khu Dat: ");
            DiaDiem = Console.ReadLine();

            Console.Write("Nhap Dien Tich Khu Dat: ");
            DienTich = int.Parse(Console.ReadLine());

            Console.Write("Nhap Gia Ban Khu Dat: ");
            GiaBan = double.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine("Dia Diem: {0}", DiaDiem);
            Console.WriteLine("Dien Tich: {0}", DienTich);
            Console.WriteLine("Gia Ban: {0}", GiaBan);
        }
    }
}
