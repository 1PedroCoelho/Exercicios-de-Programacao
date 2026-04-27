using System;

// Classe base
class Produto
{
    protected string nome;
    protected double preco;

    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Preço: " + preco);
    }
}

// Classe derivada
class Livro : Produto
{
    protected string autor;

    public void DefinirDados(string nome, double preco, string autor)
    {
        this.nome = nome;
        this.preco = preco;
        this.autor = autor;
    }

    public void ExibirDadosLivro()
    {
        ExibirDados();
        Console.WriteLine("Autor: " + autor);
    }
}
// Classe base
class Pessoa
{
    protected string nome;
    protected int idade;

    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
    }
}

// Classe derivada
class Aluno : Pessoa
{
    protected string curso;

    public void DefinirDados(string nome, int idade, string curso)
    {
        this.nome = nome;
        this.idade = idade;
        this.curso = curso;
    }

    public void ExibirDadosAluno()
    {
        ExibirDados();
        Console.WriteLine("Curso: " + curso);
    }
}
// Classe base
class Dispositivo
{
    protected string marca;
    protected string modelo;

    public void ExibirDados()
    {
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
    }
}

// Classe derivada
class Celular : Dispositivo
{
    protected int armazenamento;

    public void DefinirDados(string marca, string modelo, int armazenamento)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.armazenamento = armazenamento;
    }

    public void ExibirDadosCelular()
    {
        ExibirDados();
        Console.WriteLine("Armazenamento: " + armazenamento + "GB");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Produto - Livro
        Livro livro = new Livro();
        livro.DefinirDados("Dom Casmurro", 29.90, "Machado de Assis");
        Console.WriteLine("=== Livro ===");
        livro.ExibirDadosLivro();

        Console.WriteLine();

        // Pessoa - Aluno
        Aluno aluno = new Aluno();
        aluno.DefinirDados("Pedro", 19, "Sistemas de Informação");
        Console.WriteLine("=== Aluno ===");
        aluno.ExibirDadosAluno();

        Console.WriteLine();

        // Dispositivo - Celular
        Celular celular = new Celular();
        celular.DefinirDados("Samsung", "Galaxy S23", 256);
        Console.WriteLine("=== Celular ===");
        celular.ExibirDadosCelular();
    }
}