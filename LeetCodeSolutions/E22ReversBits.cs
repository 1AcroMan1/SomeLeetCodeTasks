using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class ReversBits
    {
        public uint reverseBits(uint n)
        {
            var bits = Convert.ToString(n, 2).PadLeft(32, '0').ToCharArray();
            Array.Reverse(bits);    
            return Convert.ToUInt32(new string(bits), 2);
        }
    }
}
