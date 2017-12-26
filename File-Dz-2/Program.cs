using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Dz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание #2");
            #region FileRead
            string[] fileInit = File.ReadAllLines("FileInput.txt");
            string[] file = fileInit[0].Split(' ');
            int[] intArray = new int[file.Length];
            for (int i = 0; i < file.Length; i++)
            {
                intArray[i] = int.Parse(file[i]);
            }
            Console.WriteLine("Файл успешно считан!");
            #endregion

            #region FileWrite
            using (StreamWriter writer = new StreamWriter("FileOutput.txt", false))
            {
                for (int i = 0; i < intArray.Length - 1; i++)
                {
                    writer.WriteLine((intArray[i] + intArray[i + 1]));
                    i++;
                }
            }
            Console.WriteLine("Файл успешно записан");
            #endregion
            Console.ReadLine();
        }
    }
}
