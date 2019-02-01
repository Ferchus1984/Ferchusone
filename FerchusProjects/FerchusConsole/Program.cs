using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerchusConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operacones = new Operaciones();
            Console.WriteLine("Hola");

            int resultadoSuma = operacones.Suma(3, 5);

            Console.Write(resultadoSuma.ToString());
            Console.ReadLine();
        }
    }
}
