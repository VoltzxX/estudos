using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aulaintro = "introdução a coleções";
            string aulamodelando = "modelando a Classe aula";
            string aulaSets = "trabalhando com conjuntos";

            //List<string> aulas = new List<string> {
            //    aulaintro,
            //    aulamodelando,
            //    aulaSets
            //};

            List<string> aulas = new List<string>();
            aulas.Add(aulaintro);
            aulas.Add(aulamodelando);
            aulas.Add(aulaSets);
            
            Imprimir(aulas);

            Console.WriteLine("a aula acessada pelo indice é: " + aulas[0]);
            Console.WriteLine("a aula primeira acessada pelo metodo First é: " + aulas.First());
            Console.WriteLine("a ultima aula acessada pelo indice é: " + aulas[aulas.Count - 1]);
            Console.WriteLine("a ultima aula acessada pelo metodo Last é: " + aulas.Last());


            aulas[0] = "Trabalhando com lisatas";

            Imprimir(aulas);

            Console.WriteLine("A primeira aula 'Trabalhando' é : "
                + aulas.First(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A ultima aula 'Trabalhando' é : "
            + aulas.Last(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A primeira aula 'palavra diferenciada' é : "
                + aulas.FirstOrDefault(aula => aula.Contains("palavra diferenciada")));

            aulas.Reverse();
            Imprimir(aulas);

            aulas.Reverse();
            Imprimir(aulas);

            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            aulas.Add("conclusão");
            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);


            List<string> Copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(Copia);

            List<string> clone = new List<string>(aulas);

            Imprimir(clone);

            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);

            
        }

        private static void Imprimir(List<string> aulas)
        {
            //foreach (string aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}
            aulas.ForEach(aula => {
                Console.WriteLine(aula);
            });
            Console.WriteLine(aulas.Count);

        }
    }
}
