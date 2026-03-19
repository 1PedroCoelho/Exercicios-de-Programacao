class Veiculo
{
    public string placa;
    private string modelo;
    private int horaEntrada;
    public bool estacionado;
    public static int totalVeiculos=0;

    public Veiculo(string placa, string modelo, int horaEntrada)
    {
        this.placa=placa;
        setHoraEntrada(horaEntrada);
        setModelo(modelo);
        estacionado=true;
        totalVeiculos+=1;

    }
    public void setHoraEntrada(int hora)
    {
        horaEntrada= hora;
    }
    public void setModelo(string model)
    {
        modelo = model;
    }
    public string getPlaca()
    {
        return placa;
    }
    public string getModelo()
    {
        return modelo;
    }
    public int getHoraEntrada()
    {
        return horaEntrada;
    }
    public bool getStatus()
    {
        return estacionado;
    }

    public void registrarSaida()
    {
        this.estacionado=false;
    }
    public void mostraDados()
    {
        Console.WriteLine($"{this.placa}");
        Console.WriteLine($"{this.modelo}");
        Console.WriteLine($"{this.horaEntrada}");
    }

}
class Program
{
    public static void Main()
    {
        Veiculo carro1 = new Veiculo("123P23", "honda", 09);
        Veiculo carro2 = new Veiculo("290LM", "Fiat",10);
        Veiculo carro3 = new Veiculo("9012KL2","BMW",11);
        carro1.mostraDados();
        carro2.mostraDados();
        carro3.mostraDados();
        carro3.registrarSaida();
        carro1.mostraDados();
        carro2.mostraDados();
        carro3.mostraDados();
        Console.WriteLine($"{Veiculo.totalVeiculos}");

    }
}