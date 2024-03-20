using ByteBank.Modelos;
using Humanizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "paginas?argumentos";
            int indiceInterrogação = url.IndexOf('?');
            string argumentos = url.Substring(indiceInterrogação + 1);
            Console.WriteLine(argumentos);
        }
    }
}
