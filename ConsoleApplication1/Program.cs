using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
        static void Main(string[] args)
        {

            string hexString = "E0C22342F86FC98C639EB18A205FE1A4";
            byte[] b = HexStringToByteArray(hexString);
            int count = b.Length ;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Convert.ToString(b[i]));
            }
            Console.ReadLine();
        }
    }
}
