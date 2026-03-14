class ContaBancaria
{
    private string titular;
    private double saldo;

    public string getTitular()
    {
        return titular;
    }
    public void setTitular(string novoTitular)
    {
        titular = novoTitular;
    }
    public double getSaldo()
    {
        return saldo;
    }
    public void setSaldo(double novoSaldo)
    {
        saldo = novoSaldo;
    }
    public void Depositar(double valor)
    {
        saldo += valor;
        Console.WriteLine($"Valor de R${valor} depositado na sua conta. Seu saldo: {saldo}");
    }
    public void Sacar(double valor)
    {
        if (saldo < valor)
        {
            Console.WriteLine($"Saldo insuficiente para realizar o saque. Seu saldo:{saldo}");
        }
        else
        {
            Console.WriteLine($"Valor de R${valor} sacado da sua conta. Seu saldo: {saldo}");
        }
    }
}

class Funcionario
{
    private string nome;
    private double salario;

    public string getNome()
    {
        return nome;
    }
    public void setNome(string novoNome)
    {
        nome = novoNome;
    }
    public double getSalario()
    {
        return salario;
    }
    public void setSalario(double novoSalario)
    {
        salario = novoSalario;
    }
    public void aumentarSalario(double percentual)
    {
        double salarioaAntigo = salario;
        salario *= 1 + percentual;
        Console.WriteLine($"Salário anteriror: {salarioaAntigo}. Seu novo salário com aumento de {percentual}: {salario}");

    }

}
class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine();
        ContaBancaria MinhaConta = new ContaBancaria();
        MinhaConta.setTitular("Pedro Coelho");
        Console.WriteLine($"{MinhaConta.getTitular()}");
        MinhaConta.setSaldo(100);
        MinhaConta.Depositar(20);
        MinhaConta.Sacar(50);
        Console.WriteLine($"Saldo: {MinhaConta.getSaldo()}");
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer telcla para prosseguir para o exercício dos funcionários");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine();
        Funcionario FuncionarioLegal = new Funcionario();
        FuncionarioLegal.setNome("Pedro Coelho");
        FuncionarioLegal.setSalario(1000);
        Console.WriteLine($"{FuncionarioLegal.getNome()}");
        Console.WriteLine($"Salário inicial: {FuncionarioLegal.getSalario()}");
        FuncionarioLegal.aumentarSalario(0.10);
    }
}