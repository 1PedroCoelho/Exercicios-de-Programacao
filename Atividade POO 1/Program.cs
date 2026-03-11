class Program
{


    static int MultiplicacaoRecursiva(int m, int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else
        {
            return m + MultiplicacaoRecursiva(m, n - 1);
        }
    }
    static int QPrimeirosMultiplos(int n, int q)
    {
        if (q <= 0)
        {
            return 1;
        }
        else
        {
            Console.WriteLine($"{n * q}");
            return QPrimeirosMultiplos(n, q - 1);
        }
    }
    static double ResultSerie(double s)
    {
        if (s <= 0)
            return 0;
        else
        {
            Console.WriteLine($"1/{s}");
            return 1 / s + ResultSerie(s - 1);
        }
    }
    static int SomaVetor(int[] v, int i)
    {
        if (i < 0)
            return 0;
        else
            return v[i] + SomaVetor(v, i - 1);
    }

    static void DecimalParaBinario(int n)
    {
        if (n > 1)
            DecimalParaBinario(n / 2);

        Console.Write(n % 2);
    }

    struct Data
    {
        public int Dia;
        public int Mes;
        public int Ano;
    }

    struct Funcionario
    {
        public int Matricula;
        public string Nome;
        public string Departamento;
        public double Salario;
        public Data DataAdmissao;
    }

    static void CadastrarFuncionarios(Funcionario[] funcionarios)
    {
        for (int i = 0; i < funcionarios.Length; i++)
        {
            Console.WriteLine($"Funcionario {i + 1}");

            Console.Write("Matricula: ");
            funcionarios[i].Matricula = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            funcionarios[i].Nome = Console.ReadLine();

            Console.Write("Departamento: ");
            funcionarios[i].Departamento = Console.ReadLine();

            Console.Write("Salario: ");
            funcionarios[i].Salario = double.Parse(Console.ReadLine());

            Console.Write("Dia Admissao: ");
            funcionarios[i].DataAdmissao.Dia = int.Parse(Console.ReadLine());

            Console.Write("Mes Admissao: ");
            funcionarios[i].DataAdmissao.Mes = int.Parse(Console.ReadLine());

            Console.Write("Ano Admissao: ");
            funcionarios[i].DataAdmissao.Ano = int.Parse(Console.ReadLine());
        }
    }

    static void ListarPorDepartamento(Funcionario[] funcionarios, string dep)
    {
        for (int i = 0; i < funcionarios.Length; i++)
        {
            if (funcionarios[i].Departamento == dep)
            {
                Console.WriteLine(funcionarios[i].Nome);
            }
        }
    }

    class Vet
    {
        private int[] v;

        public Vet(int tamanho)
        {
            v = new int[tamanho];
        }

        public void Inserir(int pos, int valor)
        {
            v[pos] = valor;
        }

        public int Recuperar(int pos)
        {
            return v[pos];
        }

        public bool Existe(int valor)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == valor)
                    return true;
            }
            return false;
        }

        public int SomaPares()
        {
            int soma = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 == 0)
                    soma += v[i];
            }
            return soma;
        }

        public int SomaImpares()
        {
            int soma = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 != 0)
                    soma += v[i];
            }
            return soma;
        }

        public int SomaTodos()
        {
            int soma = 0;
            for (int i = 0; i < v.Length; i++)
                soma += v[i];
            return soma;
        }

        public void Listar()
        {
            for (int i = 0; i < v.Length; i++)
                Console.WriteLine(v[i]);
        }
    }

    struct Livro
    {
        public string titulo;
        public string autor;
        public string genero;
        public int ano;
    }

    static Livro CriarLivro(string titulo, string autor, string genero, int ano)
    {
        Livro l;
        l.titulo = titulo;
        l.autor = autor;
        l.genero = genero;
        l.ano = ano;
        return l;
    }

    static string ObterAutor(Livro l)
    {
        return l.autor;
    }

    static string ObterTitulo(Livro l)
    {
        return l.titulo;
    }

    static string ObterGenero(Livro l)
    {
        return l.genero;
    }

    static int ObterAno(Livro l)
    {
        return l.ano;
    }

    static bool EhModernismo(Livro l)
    {
        if (l.ano >= 1930 && l.ano <= 1945)
            return true;
        else
            return false;
    }

    static bool EhBarroco(Livro l)
    {
        if (l.ano >= 1601 && l.ano <= 1768)
            return true;
        else
            return false;
    }
    static void Main()
    {
        static void Main()
        {
            int Quest1 = MultiplicacaoRecursiva(7, 5);
            Console.WriteLine($"Resultado1: {Quest1}");

            QPrimeirosMultiplos(5, 6);

            double Quest3 = ResultSerie(5);
            Console.WriteLine($"Resultado3: {Quest3}");

            int[] vetor = { 1, 2, 3, 4, 5 };
            int soma = SomaVetor(vetor, vetor.Length - 1);
            Console.WriteLine($"Soma Vetor: {soma}");

            Console.Write("65 em binario: ");
            DecimalParaBinario(65);
            Console.WriteLine();

            Funcionario[] funcionarios = new Funcionario[2];

            funcionarios[0].Matricula = 1;
            funcionarios[0].Nome = "Pedro";
            funcionarios[0].Departamento = "TI";
            funcionarios[0].Salario = 3000;
            funcionarios[0].DataAdmissao.Dia = 1;
            funcionarios[0].DataAdmissao.Mes = 1;
            funcionarios[0].DataAdmissao.Ano = 2024;

            funcionarios[1].Matricula = 2;
            funcionarios[1].Nome = "Maria";
            funcionarios[1].Departamento = "RH";
            funcionarios[1].Salario = 2500;
            funcionarios[1].DataAdmissao.Dia = 2;
            funcionarios[1].DataAdmissao.Mes = 2;
            funcionarios[1].DataAdmissao.Ano = 2023;

            Console.WriteLine("Funcionarios do departamento TI:");
            ListarPorDepartamento(funcionarios, "TI");

            Vet v = new Vet(5);
            v.Inserir(0, 1);
            v.Inserir(1, 2);
            v.Inserir(2, 3);
            v.Inserir(3, 4);
            v.Inserir(4, 5);

            Console.WriteLine($"Existe 3: {v.Existe(3)}");
            Console.WriteLine($"Soma Pares: {v.SomaPares()}");
            Console.WriteLine($"Soma Impares: {v.SomaImpares()}");
            Console.WriteLine($"Soma Todos: {v.SomaTodos()}");

            Console.WriteLine("Elementos do vetor:");
            v.Listar();

            Livro livro = CriarLivro("Dom Casmurro", "Machado de Assis", "Romance", 1899);

            Console.WriteLine($"Titulo: {ObterTitulo(livro)}");
            Console.WriteLine($"Autor: {ObterAutor(livro)}");
            Console.WriteLine($"Eh Modernismo: {EhModernismo(livro)}");
            Console.WriteLine($"Eh Barroco: {EhBarroco(livro)}");
        }
    }
}