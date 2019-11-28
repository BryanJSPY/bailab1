using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NhaPho : KhuDat
    {
        public int NamXayDung { get; set; }
        public int SoTang { get; set; }

        public NhaPho()
        {

        }

        public NhaPho(string diaDiem, int dienTich, double giaBan,int namXayDung, int soTang)
            :base(diaDiem,dienTich,giaBan)
        {
            NamXayDung = namXayDung;
            SoTang = soTang;
        }

        public new void Input()
        {
            base.Input();

            Console.Write("Nam Xay Dung: ");
            NamXayDung = int.Parse(Console.ReadLine());

            Console.Write("So Tang: ");
            SoTang = int.Parse(Console.ReadLine());
        }

        public new void Show()
        {
            base.Show();

            Console.WriteLine("Nam xay dung: {0}", NamXayDung);
            Console.WriteLine("So tang; {0}", SoTang);
        }
    }
}
