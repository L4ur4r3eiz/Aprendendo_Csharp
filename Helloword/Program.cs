using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloword
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores logicos:

            int numero1 = 2 + 2;
            float numero2 = 20 * 3;
            float numero3 = 5.0f / 2;

            //condicionais:

            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);

            int a = 30;
            int b = 40; 
            int c = 10;
            
            if ( a < b && a > c )
            {
                Console.WriteLine("Está correto");
            }



            if (23 == numero1)
            {
                Console.WriteLine("Essa condição é verdadeira!");
            }

            else
            {
                Console.WriteLine("Essa condição é falsa!");
            }


                Console.ReadLine();
        }
    }
    

    
}

/* APRENDENDO COMO USAR VARIAVEIS NO C#
     * internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("qual é seu nome");


            string nome = "Laura Reis";
            int idade = 15;
            bool estudante = true;
            float altura = 1.65f;


            Console.WriteLine(nome);
            Console.WriteLine("qual é sua idade?");
            Console.WriteLine(idade);
            Console.WriteLine("Você é estudante?");
            Console.WriteLine(estudante);
            Console.WriteLine("qual é sua altura?");
            Console.WriteLine(altura);

            idade = 20;

            Console.WriteLine(idade);


            Console.ReadLine();

        }
    } */