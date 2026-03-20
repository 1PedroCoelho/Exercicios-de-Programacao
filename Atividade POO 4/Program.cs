static class ConversorTemperatura
{
    public static double CelsiusParaFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
    public static double FahrenheitParaCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
}

class Aluno
{
    public string nome;
    public static int totalAlunos = 0;
    public Aluno(string nome)
    {
        this.nome = nome;
        Console.WriteLine($"Aluno {nome} cadastrado");
        totalAlunos++;
    }
    public static void ExibirTotalAlunos()
    {
        Console.WriteLine($"Total alunos: {totalAlunos}");
    }
}

class Curso
{
    public string nome;
    public int cargaHoraria;

    public Curso(string nome)
    {
        this.nome=nome;
        cargaHoraria=40;
        Console.WriteLine("Curso criado");
    }
    public Curso(string nome, int cargaHoraria)
    {
        this.nome=nome;
        this.cargaHoraria=cargaHoraria;
        Console.WriteLine("Curso criado");
    }
    public void ExibirDados()
    {
        Console.WriteLine($"Curso: {nome}");
        Console.WriteLine($"Carga horária: {cargaHoraria}");
    }
    ~Curso()
    {
        Console.WriteLine($"Curso {nome} removido da memória");
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine($"Temperatura em Celsius: {ConversorTemperatura.CelsiusParaFahrenheit(0)}");
        Console.WriteLine($"Temperatura em Fahrenheit: {ConversorTemperatura.FahrenheitParaCelsius(32)}");

        Console.WriteLine();

        Aluno aluno1 =new Aluno("Pedro");
        Aluno aluno2 =new Aluno("João");
        Aluno aluno3 =new Aluno("Sara");

        Aluno.ExibirTotalAlunos();

        Console.WriteLine();

        Curso curso1 = new Curso("matemática");
        Curso curso2 = new Curso("portugues", 40);
        curso1.ExibirDados();
        Console.WriteLine();
        curso2.ExibirDados();
        
    }
}