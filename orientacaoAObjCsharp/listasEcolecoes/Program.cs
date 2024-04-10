using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasEcolecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aulaintro = "introdução a coleções";
            string aulamodelando = "modelando a Classe aula";
            string aulaSets = "trabalhando com conjuntos";

            string[] array = new string[] {
                aulaintro,
                aulamodelando,
                aulaSets
            };

            Imprimir(array);
            array[0] = "Trabalhando com arrays";

            Console.WriteLine("modelando a Classe aula encontrado no indice " + Array.IndexOf(array, aulamodelando));
            Console.WriteLine(Array.LastIndexOf(array, aulamodelando));

            Array.Reverse(array);
            Imprimir(array);

            Array.Reverse(array);
            Imprimir(array);

            Array.Resize(ref array, 2);
            Imprimir(array);

            Array.Resize(ref array, 3);
            Imprimir(array);

            array[array.Length - 1] = "Conclusão";
            Imprimir(array);

            Array.Sort(array);
            Imprimir(array);

            string[] copia = new string[2];
            Array.Copy(array, 1, copia, 0, copia.Length);
            Imprimir(copia);

            string[] clone = array.Clone() as string[];
            Imprimir(clone);

            Array.Clear(clone, 1, 2);
            Imprimir(clone);
        }

        public static void Imprimir(string[] aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
