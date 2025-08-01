using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloword
{
    using System;

    class Program // vamos ver se você é um bruxo ou um trouxa!
    {
        static void Main()
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("🎮 BEM-VINDO AO TEXTE DE BRUXO EM C# OU CERÁ QUE É UM TROUXA?🎮");
                Console.WriteLine("1 - 💰 Cofrinho Digital (Soma de dois valores)");
                Console.WriteLine("2 - 🚀 Contagem Espacial (Contar de 1 a 10)");
                Console.WriteLine("3 - ⚡ Detector de Energia (Par ou Ímpar)");
                Console.WriteLine("4 - 🧠 Desafio da Tabuada Mágica");
                Console.WriteLine("5 - 🎓 Simulador de Notas da Escola dos Magos");
                Console.WriteLine("0 - ❌ Sair do programa");
                Console.Write("Escolha um desafio: ");

                bool entradaValida = int.TryParse(Console.ReadLine(), out opcao);

                if (!entradaValida)
                {
                    Console.WriteLine("Entrada inválida. Digite um número valido.");
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();
                    continue;
                }

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        CofrinhoDigital();
                        break;
                    case 2:
                        ContagemEspacial();
                        break;
                    case 3:
                        DetectorDeEnergia();
                        break;
                    case 4:
                        TabuadaMagica();
                        break;
                    case 5:
                        EscolaDosMagos();
                        break;
                    case 0:
                        Console.WriteLine("Encerrando o teste... Até a próxima!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione ENTER para voltar ao menu...");
                    Console.ReadLine();
                }

            } while (opcao != 0);
        }

        static void CofrinhoDigital()
        {
            Console.WriteLine("💰 COFRINHO MÁGICO");

            Console.Write("Digite o valor da primeira moeda: ");
            int moeda1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da segunda moeda: ");
            int moeda2 = int.Parse(Console.ReadLine());

            int total = moeda1 + moeda2;

            Console.WriteLine("Você juntou R$" + total + " no seu cofrinho!");
        }

        static void ContagemEspacial()
        {
            Console.WriteLine("🚀 CONTAGEM ESPACIAL: 3... 2... 1... VAI!");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Nível " + i);
            }
        }

        static void DetectorDeEnergia()
        {
            Console.WriteLine("⚡ DETECTOR DE ENERGIA");

            Console.Write("Digite um número para verificar o tipo de energia: ");
            int energia = int.Parse(Console.ReadLine());

            if (energia % 2 == 0)
            {
                Console.WriteLine("Energia POSITIVA detectada (número par)!");
            }
            else
            {
                Console.WriteLine("Energia CAÓTICA detectada (número ímpar)!");
            }
        }

        static void TabuadaMagica()
        {
            Console.WriteLine("🧠 TABUADA MÁGICA");

            Console.Write("Digite um número mágico: ");
            int magico = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{magico} x {i} = {magico * i}");
            }
        }

        static void EscolaDosMagos()
        {
            Console.WriteLine("🎓 ESCOLA DOS BRUXOS");

            Console.Write("Nota da Prova de Poções: ");
            double potions = double.Parse(Console.ReadLine());

            Console.Write("Nota da Prova de Voo com Vassoura: ");
            double voo = double.Parse(Console.ReadLine());

            Console.Write("Nota da Prova de Defesa Contra as Trevas: ");
            double defesa = double.Parse(Console.ReadLine());

            double media = (potions + voo + defesa) / 3;

            Console.WriteLine($"Sua média mágica foi: {media:F2}");

            if (media >= 7)
            {
                Console.WriteLine("Parabéns! Você passou para o próximo nível da magia! Alvo Dumbledore estaria orgulhoso de Você 🧙‍♂️✨");
            }
            else
            {
                Console.WriteLine("Hmm...Você etá mais para um trouxa. Tome cuidado se for parente do Herry 💥");
            }
        }
    }




    //ABAIXO ESTÁ ALGUNS EXERCICIOS, NÃO CONSEGUI DEIXAR ELES FUNCIONANDO NO MESMO CODIGO/PROGRAMA




    /*funções 

    class program
    {
        static void Main(string[] args)

        {
            Exibirmsg();
            Exibirmsg();
            Exibirmsg();
            GeraPreco(60);
            GeraPreco(40);

            Console.ReadLine();
        }

        static void Exibirmsg()
        {   

            Console.WriteLine("Olá, seja bem vindo ao meu programa!");

        }


        static void GeraPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int valorfinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorfinal);
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



    /* class Program
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
    */


    // criando um programa sobre idade:

    // criando um programa sobre idade:

    /*
    class idades
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");

            int idade = int.Parse(Console.ReadLine());

            if ( idade >= 0 && idade <= 12)
            {
                Console.WriteLine("você é uma criança");
            }
            else if(idade >= 13 && idade <= 18)
            {
                Console.WriteLine("você é um Adolecente");
            }
            else if (idade >= 19 && idade <= 59)
            {
                Console.WriteLine("você é um Adulto");
            }
            else
            {
                Console.WriteLine("você é um Idoso");
            }

            Console.ReadLine();
        }

    */
}

