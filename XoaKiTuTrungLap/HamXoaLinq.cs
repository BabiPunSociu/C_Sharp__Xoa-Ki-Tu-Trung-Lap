using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoaKiTuTrungLap
{
    internal class HamXoaLinq
    {
        public static string XoaTrungLap(string s)
        {
            var uniqueCharArray = s.ToCharArray().Distinct().ToArray();
            var result = new string(uniqueCharArray);
            return result;
        }
    }
}
