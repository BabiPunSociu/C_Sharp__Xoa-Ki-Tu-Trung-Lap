using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoaKiTuTrungLap
{
    internal class HamXoaHashSet
    {
        public static string XoaTrungLap(string s)
        {
            string result = string.Empty;

            var unique = new HashSet<char>(s);
            foreach (char c in unique)
            {
                result += c;
            }

            return result;
        }
    }
}
