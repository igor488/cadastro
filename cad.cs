using System;
using System.Collections.Generic;

class Program
{
    static List<Pessoa> listaPessoas = new List<Pessoa>();

    static void Main()
    {
        while (true)
        {

            Console.WriteLine("1 - Cadastrar Pessoa");
            Console.WriteLine("2 - Listar Pessoas");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();


            switch (opcao)

            {
                case "1":
                    CadastrarPessoa();
                    break;

                case "2":

                    ListarPessoas();
                    break;

                case "3":
                    Console.WriteLine("Saindo do programa. Até mais!");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void CadastrarPessoa()
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();


        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());

        Pessoa pessoa = new Pessoa(nome, idade);
        listaPessoas.Add(pessoa);

        Console.WriteLine("Pessoa cadastrada com sucesso!\n");
    }

    static void ListarPessoas()
    {
        Console.WriteLine("\nLista de Pessoas:");

        foreach (var pessoa in listaPessoas)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
        }

        Console.WriteLine();
    }
}

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
