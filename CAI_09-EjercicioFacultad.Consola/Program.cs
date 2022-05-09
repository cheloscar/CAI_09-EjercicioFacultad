using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_09_EjercicioFacultad.Consola
{
    public class Program
    {
        static Program()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            int sum = 0;

            for (int x = 0; x < 10; x++)
            {
                sum = sum + x;
                Console.WriteLine(sum);
            }

            Console.WriteLine(sum);
            
            Console.ReadKey();
        }
    }
}