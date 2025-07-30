// See https://aka.ms/new-console-template for more information
using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Laura";
            int idade = 15;
            float altura = 1.65f;
            bool estudante = true;

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Estudante: " + estudante);

            //Usuario pode dirigir
            Console.WriteLine("Qual é a sua idade?");
            int idadeUsuario = Convert.ToInt32(Console.ReadLine());
            if (idadeUsuario >= 18)
            {
                Console.WriteLine("Você pode dirigir.");
            }
            else
            {
                Console.WriteLine("Você não pode dirigir.");
            }

            //Verifica se o usuário é estudante
            Console.WriteLine("Você é estudante? (true/false)");
            bool estudanteUsuario = Convert.ToBoolean(Console.ReadLine());
            if (estudanteUsuario == true)
            {
                Console.WriteLine("Você é estudante.");
            }
            else
            {
                Console.WriteLine("Você não é estudante.");
            }


            //Calcula a média de três notas
            Console.WriteLine("Digite a primeira nota:");
            float nota1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            float nota2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota:");
            float nota3 = Convert.ToSingle(Console.ReadLine());

            float notafinal = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("A média das notas é: " + notafinal);

            //Ver se é criança, adolescente, adulto ou idoso
            Console.WriteLine("Digite sua idade:");
            int idadeVerificacao = Convert.ToInt32(Console.ReadLine());

            if (idadeVerificacao < 12)
            {
                Console.WriteLine("Você é uma criança.");
            }
            else if (idadeVerificacao >= 12 && idadeVerificacao < 18)
            {
                Console.WriteLine("Você é um adolescente.");
            }
            else if (idadeVerificacao >= 18 && idadeVerificacao < 60)
            {
                Console.WriteLine("Você é um adulto jovem.");
            }
            else
            {
                Console.WriteLine("Você é um idoso.");
            }

            //Verifica se o número é par ou ímpar
            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    
    namespace exercicios
    {
        public class ContaBancaria
        {
            private string titular;
            private double saldo;

            public ContaBancaria(string nomeTitular)
            {
                titular = nomeTitular;
                saldo = 0.0;
            }

            public void Depositar(double valor)
            {
                saldo += valor;
            }

            public void Sacar(double valor)
            {
                if (valor <= saldo)
                    saldo -= valor;
                else
                    Console.WriteLine("Saldo insuficiente!");
            }

            public void MostrarSaldo()
            {
                Console.WriteLine($"Titular: {titular} | Saldo: R${saldo}");
            }
        }

        class Programa
        {
            static void Somar(string[] args)
            {
                // SEU CÓDIGO EXISTENTE AQUI...

                // Testando ContaBancaria no final
                ContaBancaria contaLau = new ContaBancaria("Lau");
                contaLau.Depositar(300);
                contaLau.Sacar(150);
                contaLau.MostrarSaldo();
            }
        }
    }
}



        
    


