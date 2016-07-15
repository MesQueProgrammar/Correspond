using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hyhy85383695";
           string result = EncryptCode(str);
           Console.WriteLine(result);
           Console.ReadLine();
        }
        static String EncryptCode(String message)
        {
            Byte[] clearBytes = new UnicodeEncoding().GetBytes(message);
            Byte[] hashedBytes = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(clearBytes);

            String tt = BitConverter.ToString(hashedBytes).Replace("-", "");
            // MessageBox.Show(tt.Length.ToString());
            return tt;
        } 

    }
}
