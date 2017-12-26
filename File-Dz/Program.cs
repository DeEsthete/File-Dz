using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание #1");
            #region FileRead
            string[] file = File.ReadAllLines("FileInput.txt");
            int[] intArray = new int[file.Length];
            for (int i = 0; i < file.Length; i++)
            {
                intArray[i] = int.Parse(file[i]);
            }
            Console.WriteLine("Файл успешно считан!");
            #endregion

            #region FileWrite
            using (StreamWriter writer = new StreamWriter("FileInput.txt", false))
            {
                for (int i = 0; i < intArray.Length; i++)
                {
                    writer.WriteLine((intArray[i]));
                }
                for (int i = 0; i < intArray.Length; i++)
                {
                    writer.WriteLine("" + (intArray[i]) + (intArray[i]));
                }
            }
            Console.WriteLine("Файл успешно записан");
            #endregion
            Console.ReadLine();
        }
    }
}
