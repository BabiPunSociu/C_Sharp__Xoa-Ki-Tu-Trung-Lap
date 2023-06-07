using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoaKiTuTrungLap
{
    internal class HamXoa
    {
        public static string XoaTrungLap(string s)
        {
            string result = string.Empty;
            for(int i=0;i<s.Length;i++)
            {
                if (!result.Contains(s[i]))     // Nếu s[i] CHƯA có trong result thì cho thêm vào, nếu có rồi thì bỏ qua
                    result += s[i];
            }   
            return result;
        }
    }
}
