using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        //    Console.WriteLine("Введите число 1:");
        //    int num1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Введите число 2:");
        //    int num2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Выберете действие: + = 1, - = 2, * = 3, / = 4");
        //    int choise = int.Parse(Console.ReadLine());
        //    int result;
        //    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", "Debug");
        //    do
        //    {
        //        switch (choise)
        //        {
        //            case 1: result = num1 + num2;
        //                File.WriteAllText( path, result.ToString()); break;
        //            case 2: result = num1 - num2;
        //                File.WriteAllText( path, result.ToString()); break;
        //            case 3: result = num1 * num2;
        //                File.WriteAllText( path, result.ToString()); break;
        //            case 4: result = num1 / num2;
        //                File.WriteAllText( path, result.ToString()); break;

        //        }
                
        //    } while (choise > 0 && choise < 5);
            
        }
    }
}
