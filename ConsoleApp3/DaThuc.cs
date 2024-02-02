using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class DaThuc
    {
        private DonThuc[] donThucArray;

        public DaThuc(int n)
        {
            donThucArray = new DonThuc[n + 1];
            for (int i = 0; i <= n; i++)
            {
                donThucArray[i] = new DonThuc(0, i); // Khởi tạo với hệ số mặc định là 0
            }
        }

        // Indexer
        public DonThuc this[int i]
        {
            get { return donThucArray[i]; }
            set { donThucArray[i] = value; }
        }

        // Nhập
        public void NhapDaThuc()
        {
            for (int i = 0; i < donThucArray.Length; i++)
            {
                Console.Write($"Nhập hệ số của đơn thức thứ {i}: ");
                double heSo = Convert.ToDouble(Console.ReadLine());

                donThucArray[i] = new DonThuc(heSo, i);
            }
        }

        // Xuất
        public void XuatDaThuc()
        {
            for (int i = 0; i < donThucArray.Length; i++)
            {
                Console.Write(donThucArray[i]);
                if (i < donThucArray.Length - 1)
                    Console.Write(" + ");
            }
            Console.WriteLine();
        }

        // Tính giá trị
        public double TinhGiaTriDaThuc(double x)
        {
            double result = 0;
            for (int i = 0; i < donThucArray.Length; i++)
            {
                result += donThucArray[i].TinhGiaTri(x);
            }
            return result;
        }
    }

}
