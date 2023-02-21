using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("C# Winform.");
                // hien thi so lon hon trong 2 so.

                int a, b, max;
                Console.Write("Nhap a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Nhap b: ");
                b = int.Parse(Console.ReadLine());

                max = a > b ? a : b;

                Console.WriteLine("Max: {0} va {1} = {2}", a, b, max);

            } catch(Exception e)
            {
                Console.WriteLine("Error: ", e.Message);
            } finally
            {
                Console.ReadKey();
            }
            


            
        }
    }
}
