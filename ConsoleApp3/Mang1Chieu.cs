using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Mang1Chieu
    {
        int[] arr = new int[100];

        public Mang1Chieu() { }
        public Mang1Chieu(int soPhanTu)
        {
            this.arr = new int[soPhanTu];
        }

        public int length
        {
            get { return arr.Length; }

        }
        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public void prettyPrint()
        {
            Console.Write("Xuất phần tử: ");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public void printEven()
        {
            Console.Write("Xuất phẩn tử số chẵn: ");
            foreach (var i in arr)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
