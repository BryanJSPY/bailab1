using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ChungCu : KhuDat
    {
        public int Tang { get; set; }

        public ChungCu()
        {

        }

        public ChungCu(string diaDiem, int dienTich, double giaBan,int tang)
            :base(diaDiem,dienTich,giaBan)
        {
            Tang = tang;
        }

        public new void Input()
        {
            base.Input();

            Console.WriteLine("Tang: ");
            Tang = int.Parse(Console.ReadLine());
        }

        public new void Show()
        {
            base.Show();

            Console.WriteLine("Tang; {0}", Tang);
        }
    }
}
