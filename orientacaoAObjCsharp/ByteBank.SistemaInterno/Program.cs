using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2024, 04, 23);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferença = dataFimPagamento - dataCorrente;


            Console.WriteLine();


        }
    }
}
