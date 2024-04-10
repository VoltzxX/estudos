using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaSomenteLeitura
{
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
