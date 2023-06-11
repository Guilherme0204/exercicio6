using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração da matriz
            int[,] estoque = new int[4, 3];
            //Declaração das variáveis de linha e coluna
            int l, c;
            Random quan = new Random();
            //Preenchendo a matriz
            for (l = 0; l < 4; l++)
            {
                for (c = 0; c < 3; c++)
                {
                    //Produtos em cada armazem
                    estoque[l, c] = quan.Next(50, 350);

                }
                
            }
            //Guaradando os produtos nas linhas
            for (l = 0; l < 4; l++)
            {
                int produto = 0;
                for (c = 0; c < 3; c++)
                {

                    produto += estoque[l, c];

                }
                Console.WriteLine($"No armazem {l + 1} tem {produto} produtos armazenados");
            }
            //Informando qual é a linha que tem a maior quantidade do produto 2
            int produto2 = estoque[0, 1];
            int qtesto = 1;
            for (int i = 1; i < 4; i++)
            {
                if (estoque[i, 1] > produto2)
                {
                    produto2 = estoque[i, 1];
                    qtesto = i + 1;
                }
               

            }
            Console.WriteLine($"\nO armazém com maior estoque do produto 2 é o armazém {qtesto}.");
            //Informando qual é a linha que tem a menor quantidade do produto 1
            int produto1 = estoque[0, 0];
            int qtesto1 = 1;
            for (int i = 1; i < 4; i++)
            {
                if (estoque[i, 0] < produto1)
                {
                    produto1 = estoque[i, 0];
                    qtesto1 = i + 1;
                }


            }
            Console.WriteLine($"\nO armazém com maior estoque do produto 1 é o armazém {qtesto1}.");
            Console.ReadKey();
        }
    }
}
