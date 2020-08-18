using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF AND ELSE , OPERADORES CONDICIONAIS ;

            int x = 10;
          
            Console.WriteLine(" ENTRE COM UM NUMERO INTEIRO ");

           x = int.Parse(Console.ReadLine()); // CONVERTENDO INT EM STRING PARA PODER IMPRIMIR NA TELA ;

            if (x % 2 == 0)
            {
                Console.WriteLine("PAR");

                }

            else
            {
                Console.WriteLine("IMPAR");
            }



            }

        }
    }
