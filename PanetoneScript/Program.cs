using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanetoneScript
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = @"C:\Users\mathias.ody\Documents\Mathias Ody\Ps";
            string filename;

            filename = Console.ReadLine();

            Console.WriteLine(directory + filename);

            PanetoneScript.LoadFolder(directory);

            Console.ReadLine();
        }
    }
}
