using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DSNhaPho
    {
        public static List<NhaPho> NhapDSNhaPho()
        {
            int n = 0;
            Console.Write("\n===Nhap so luong ['NHA PHO'] moi mua: ");
            n = int.Parse(Console.ReadLine());

            List<NhaPho> listNhaPho = new List<NhaPho>();
            Console.WriteLine("\n===Nhap thong tin ve ['NHA PHO']:");
            for (int i = 0; i < n; i++)
            {
                NhaPho temp = new NhaPho();
                Console.WriteLine("Nha Pho [{0}]:", i + 1);
                temp.Input();
                Console.WriteLine("");
                listNhaPho.Add(temp);
            }

            return listNhaPho;
        }
        public static void XuatDSNhaPho(List<NhaPho> listNhaPho)
        {
            Console.WriteLine("\n==Xuat Danh Sach Nha Pho Dang Quan Ly: ");
            foreach (NhaPho np in listNhaPho)
            {
                Console.WriteLine("");
                np.Show();
            }
        }
    }
}
