using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class Login
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan nama anda :");
            string nama = Console.ReadLine();

            Console.Write("Masukan umur anda :");
            int umur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + nama + " umur anda adalah " + umur);
            Console.ReadKey();
        }
    }
}
