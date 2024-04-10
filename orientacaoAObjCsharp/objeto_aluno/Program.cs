using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objeto_aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aulaintro = new Aula("introdução a coleções", 14);
            var aulamodelando = new Aula("modelando a Classe aula", 16);
            var aulaSets = new Aula("trabalhando com conjuntos", 20);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaintro);
            aulas.Add(aulamodelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);

            aulas.Sort((este, outro) => este.duracao.CompareTo(outro.duracao));
            Imprimir(aulas);
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

        public class Aula : IComparable
        {
            public Aula(string titulo_da_aula = null, int duracao = 0)
            {
                this.titulo_da_aula = titulo_da_aula;
                this.duracao = duracao;
            }

            public string titulo_da_aula { get; set; }
            public int duracao { get; set; }

            public int CompareTo(object obj)
            {
                var that = obj as Aula;
                return this.titulo_da_aula.CompareTo(that.titulo_da_aula);
            }

            public override string ToString()
            {
                return $"titulo_da_aula: {titulo_da_aula}, tempo:{duracao} em minutos";
            }
        }
    }
}
