using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaSomenteLeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        private static void Imprimir(List<Aula> aulas)
        {
            //comente esta linha para ver fucionando por completo
            //Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
                //Console.WriteLine($"titulo da aula = {aula.titulo_da_aula} duracao = {aula.duracao} de cada aula");
            }
        }

    
    }
}
