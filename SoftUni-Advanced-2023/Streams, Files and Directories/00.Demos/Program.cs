using System;
using System.IO;

namespace _00.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            using(FileStream fileStream = new FileStream("..\..\..\myfile.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[]
                {
                    69, 70, 80
                }

                fileStream.Write(buffer);

            }

        }
 
    }
}
