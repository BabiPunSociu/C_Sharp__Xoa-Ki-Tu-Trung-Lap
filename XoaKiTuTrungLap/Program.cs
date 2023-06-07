using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoaKiTuTrungLap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập chuỗi: ");
            string s = Console.ReadLine();

            // Xóa by for loop
            string s1 = HamXoa.XoaTrungLap(s);
            Console.WriteLine("Kết quả dùng for_loop: " + s1);

            // Xóa by HashSet
            string s2 = HamXoaHashSet.XoaTrungLap(s);
            Console.WriteLine("Kết quả dùng HashSet: " + s2);

            // Xóa by Linq
            string s3 = HamXoaLinq.XoaTrungLap(s);
            Console.WriteLine("Kết quả dùng Linq: " + s3);
        }
    }
}
