using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
           Lista<int> lista = new Lista<int>();

            TestaListaDeObject();
            TestaListaDeContaCorrente();
            TestaArrayInt();
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeidades = new ListaDeObject();

            listaDeidades.AdicionarVarios(10, 23, 12, 123, 53, 63, 23);

            for (int i = 0; i < listaDeidades.Tamnho; i++)
            {
                int idade = (int)listaDeidades[i];
                Console.WriteLine($"escrevendo todas as iidades da listaDeIdades {idade}");
            }
        }

        static void TestaListaDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438)
            };
            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }

    }
}
