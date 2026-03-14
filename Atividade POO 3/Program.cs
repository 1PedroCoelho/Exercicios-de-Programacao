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
        
    }
}