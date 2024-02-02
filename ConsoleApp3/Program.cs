using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Mang1Chieu mMang1Chieu = new Mang1Chieu(3);
            for(int i = 0; i < mMang1Chieu.length; i++)
            {
                Console.Write($"Nhập phần tử thứ {i}: ");
                mMang1Chieu[i] = int.Parse(Console.ReadLine());
            }


            mMang1Chieu.prettyPrint();
            mMang1Chieu.printEven();



            Console.Write("Nhập bậc của đa thức: ");
            int n = Convert.ToInt32(Console.ReadLine());

            DaThuc daThuc = new DaThuc(n);

            daThuc.NhapDaThuc();

            Console.Write("Đa thức vừa nhập là: ");
            daThuc.XuatDaThuc();

            Console.Write("Nhập giá trị x để tính giá trị đa thức: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double giaTri = daThuc.TinhGiaTriDaThuc(x);
            Console.WriteLine($"Giá trị của đa thức với x={x} là: {giaTri}");
            Console.ReadKey();

        }
    }
}
