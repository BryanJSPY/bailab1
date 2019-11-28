using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DSChungCu
    {
        public static List<ChungCu> NhapDSChungCu()
        {
            int n = 0;
            Console.Write("Nhap so luong ['CHUNG CU'] moi mua: ");
            n = int.Parse(Console.ReadLine());

            List<ChungCu> listChungCu = new List<ChungCu>();
            Console.WriteLine("Nhap thong tin ve ['CHUNG CU']: ");
            for (int i = 0; i < n; i++)
            {
                ChungCu temp = new ChungCu();
                Console.WriteLine("Chung Cu [{0}]:", i + 1);
                temp.Input();
                Console.WriteLine("");
                listChungCu.Add(temp);
            }

            return listChungCu;
        }
        public static void XuatDSChungCu(List<ChungCu> listChungCu)
        {
            Console.WriteLine("Xuat Danh Sach Khu Dat Dang Quan Ly: ");
            foreach (ChungCu cc in listChungCu)
            {
                cc.Show();
            }
        }
    }
}
