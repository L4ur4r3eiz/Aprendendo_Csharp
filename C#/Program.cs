// Exercícios de C# - Conceitos Básicos e Iniciais de POO
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos de Dados e Variáveis
            int idade = 20;
            string nome = "Lau";
            float altura = 1.65f;
            bool estudante = true;

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Estudante: " + estudante);

            // Condicionais
            Console.Write("Digite sua idade: ");
            int idadeUsuario = int.Parse(Console.ReadLine());
            if (idadeUsuario >= 18)
                Console.WriteLine("Maior de idade");
            else
                Console.WriteLine("Menor de idade");

            // Condicional intermediária
            Console.Write("Digite sua nota final: ");
            float nota = float.Parse(Console.ReadLine());
            if (nota >= 7)
                Console.WriteLine("Aprovado");
            else if (nota >= 5)
                Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Reprovado");

            // Laço de repetição
            Console.WriteLine("Contagem de 1 a 5:");
            for (int i = 1; i <= 5; i++)
                Console.WriteLine(i);

            // Intermediário: tabuada do 7
            Console.WriteLine("Tabuada do 7:");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"7 x {i} = {7 * i}");

            // While intermediário: soma até digitar 0
            int soma = 0;
            int numero;
            do
            {
                Console.Write("Digite um número (0 para sair): ");
                numero = int.Parse(Console.ReadLine());
                soma += numero;
            } while (numero != 0);
            Console.WriteLine("Soma total: " + soma);

            // Funções/Métodos
            Saudacao("Lau");
            int dobro = Dobrar(5);
            Console.WriteLine("Dobro de 5: " + dobro);
            Console.WriteLine("10 é par? " + EhPar(10));

            // Intermediário: método que retorna se a idade é maior de idade
            Console.WriteLine(
                VerificarMaioridade(20) ? "Maior de idade" : "Menor de idade");

            // Intermediário: método que retorna a média de notas
            float mediaNotas = CalcularMedia(new float[] { 7, 8.5f, 6 });
            Console.WriteLine("Média: " + mediaNotas);

            // POO BÁSICO
            Pessoa p1 = new Pessoa();
            p1.Nome = "Laura";
            p1.Idade = 15;
            p1.Falar();

            Carro c1 = new Carro("Fusca", 1975);
            c1.ExibirInfo();

            Aluno aluno1 = new Aluno("Lau", 8.5f);
            aluno1.MostrarNota();

            // POO Intermediário: Lista de produtos com preço
            List<Produto> produtos = new List<Produto>
            {
                new Produto("Caneta", 2.5),
                new Produto("Caderno", 15.9),
                new Produto("Borracha", 1.2)
            };
            foreach (Produto p in produtos)
                p.Exibir();

            // POO Intermediário: Cadastro de clientes
            Cliente cliente1 = new Cliente("Ana", "ana@email.com");
            cliente1.ExibirDados();

            // POO Intermediário: Conta bancária
            ContaBancaria conta = new ContaBancaria("123-4", "Lau");
            conta.Depositar(100);
            conta.Sacar(40);
            conta.ExibirSaldo();
        }

        static void Saudacao(string nome)
        {
            Console.WriteLine("Bem-vindo(a), " + nome);
        }

        static int Dobrar(int numero)
        {
            return numero * 2;
        }

        static bool EhPar(int n)
        {
            return n % 2 == 0;
        }

        static bool VerificarMaioridade(int idade)
        {
            return idade >= 18;
        }

        static float CalcularMedia(float[] notas)
        {
            float soma = 0;
            foreach (float nota in notas)
                soma += nota;
            return soma / notas.Length;
        }
    }

    class Pessoa
    {
        public string Nome;
        public int Idade;

        public void Falar()
        {
            Console.WriteLine($"Oi, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }

    class Carro
    {
        public string Modelo;
        public int Ano;

        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Carro: {Modelo}, Ano: {Ano}");
        }
    }

    class Aluno
    {
        public string Nome;
        public float Nota;

        public Aluno(string nome, float nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public void MostrarNota()
        {
            Console.WriteLine($"Aluno: {Nome}, Nota: {Nota}");
        }
    }

    class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void Exibir()
        {
            Console.WriteLine($"Produto: {Nome}, Preço: R${Preco}");
        }
    }

    class Cliente
    {
        public string Nome;
        public string Email;

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Cliente: {Nome}, Email: {Email}");
        }
    }

    class ContaBancaria
    {
        public string Numero;
        public string Titular;
        private double Saldo;

        public ContaBancaria(string numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
            else
                Console.WriteLine("Saldo insuficiente!");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Titular: {Titular}, Saldo: R${Saldo}");
        }
    }
}
