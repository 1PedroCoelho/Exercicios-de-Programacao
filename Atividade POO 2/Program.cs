using System.Diagnostics.Tracing;

class Carro
{
    public string marca;
    public string modelo;
    public string cor;
    public int anoFabricacao;

    public void exibirInformacoes()
    {
        Console.WriteLine($"{marca}");
        Console.WriteLine($"{modelo}");
        Console.WriteLine($"{cor}");
        Console.WriteLine($"{anoFabricacao}");
    }
    public void buzinar()
    {
        Console.WriteLine("Beep Beep!");
    }
}

class Filme
{
    public string titulo;
    public string diretor;
    public int anoLancamento;
    public bool emprestado;

    public void exibirInformacoes()
    {
        Console.WriteLine($"{titulo}");
        Console.WriteLine($"{diretor}");
        Console.WriteLine($"{anoLancamento}");
        Console.WriteLine($"{emprestado}");
    }
    public void emprestar()
    {
        if (this.emprestado == true)
        {
            Console.WriteLine($"{this.titulo} já está emprestado");
        }
        else
        {
            this.emprestado = true;
            Console.WriteLine($"{this.titulo} emprestado com sucesso");
        }
    }
    public void devolver()
    {
        if (this.emprestado == false)
        {
            Console.WriteLine($"{this.titulo} já está devolvido");
        }
        else
        {
            this.emprestado = false;
            Console.WriteLine($"{this.titulo} devolvido com sucesso");
        }
    }
    public Filme()
    {
        emprestado = false;
    }
}
class TesteFilme
{
    public TesteFilme()
    {
        Console.WriteLine("Quantos filmes deseja cadastrar? ");
        int qntd = int.Parse(Console.ReadLine());

        Filme[] filmes = new Filme[qntd];

        for (int i = 0; i < qntd; i++)
        {
            Filme filme = new Filme();
            Console.WriteLine("Titulo: ");
            filme.titulo = Console.ReadLine();
            Console.WriteLine("Diretor: ");
            filme.diretor = Console.ReadLine();
            Console.WriteLine("Ano de Lançamento: ");
            filme.anoLancamento = int.Parse(Console.ReadLine());
            filmes[i] = filme;
        }
        for (int i = 0; i < filmes.Length; i++)
        {
            Console.WriteLine($"Filme - {i + 1}");
            filmes[i].exibirInformacoes();
        }
        int escolha;

        do
        {
            Console.WriteLine("1 - Emprestar filme");
            Console.WriteLine("2 - Devolver filme");
            Console.WriteLine("3 - Mostrar filmes");
            Console.WriteLine("0 - Sair");

            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.WriteLine("Qual filme deseja emprestar?");
                int n = int.Parse(Console.ReadLine()) - 1;

                filmes[n].emprestar();
            }

            else if (escolha == 2)
            {
                Console.WriteLine("Qual filme deseja devolver?");
                int n = int.Parse(Console.ReadLine()) - 1;

                filmes[n].devolver();
            }

            else if (escolha == 3)
            {
                for (int i = 0; i < filmes.Length; i++)
                {
                    Console.WriteLine($"Filme {i + 1}");
                    filmes[i].exibirInformacoes();
                }
            }

        } while (escolha != 0);
    }
}
class Jogo
{
    public string titulo;
    public string plataforma;
    public int anoLancamento;
    public bool emprestado;

    public void exibirInformacoes()
    {
        Console.WriteLine($"{titulo}");
        Console.WriteLine($"{plataforma}");
        Console.WriteLine($"{anoLancamento}");
        Console.WriteLine($"{emprestado}");
    }

    public void emprestar()
    {
        if (this.emprestado == true)
        {
            Console.WriteLine($"{this.titulo} já está emprestado");
        }
        else
        {
            this.emprestado = true;
            Console.WriteLine($"{this.titulo} emprestado com sucesso");
        }
    }

    public void devolver()
    {
        if (this.emprestado == false)
        {
            Console.WriteLine($"{this.titulo} já está devolvido");
        }
        else
        {
            this.emprestado = false;
            Console.WriteLine($"{this.titulo} devolvido com sucesso");
        }
    }

    public Jogo()
    {
        emprestado = false;
    }
}

class TesteJogo
{
    public TesteJogo()
    {
        Console.WriteLine("Quantos jogos deseja cadastrar?");
        int qntd = int.Parse(Console.ReadLine());

        Jogo[] jogos = new Jogo[qntd];

        for (int i = 0; i < qntd; i++)
        {
            Jogo jogo = new Jogo();

            Console.WriteLine("Titulo:");
            jogo.titulo = Console.ReadLine();

            Console.WriteLine("Plataforma:");
            jogo.plataforma = Console.ReadLine();

            Console.WriteLine("Ano de lançamento:");
            jogo.anoLancamento = int.Parse(Console.ReadLine());

            jogos[i] = jogo;
        }

        for (int i = 0; i < jogos.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {jogos[i].titulo}");
            Console.WriteLine($"{jogos[i].plataforma}");
            Console.WriteLine($"{jogos[i].anoLancamento}");
            Console.WriteLine($"{jogos[i].emprestado}");
        }

        Console.WriteLine("Escolha um jogo para emprestar:");
        int escolha = int.Parse(Console.ReadLine()) - 1;
        jogos[escolha].emprestar();

        Console.WriteLine("Escolha um jogo para devolver:");
        escolha = int.Parse(Console.ReadLine()) - 1;
        jogos[escolha].devolver();
    }
}
class Program
{
    static void Main()
    {
        Carro carro1 = new Carro();
        carro1.marca = "Honda";
        carro1.modelo = "HRV";
        carro1.cor = "Azul";
        carro1.anoFabricacao = 2019;
        carro1.exibirInformacoes();
        Console.WriteLine("");
        Carro carro2 = new Carro();
        carro2.marca = "Fiat";
        carro2.modelo = "Palio";
        carro2.cor = "Prata";
        carro2.anoFabricacao = 2005;
        carro2.exibirInformacoes();
        Console.WriteLine("");

        Carro carro3 = new Carro();
        carro3.marca = "Chevrolet";
        carro3.modelo = "Astra";
        carro3.cor = "Preto";
        carro3.anoFabricacao = 2008;
        carro3.exibirInformacoes();
        carro3.buzinar();

        TesteFilme teste = new TesteFilme();
    }
}