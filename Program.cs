using System.Xml.Serialization;
using System.IO;
public class DataTarefa
{
    public int dia;
    public int mes;
    public int ano;
    public int hora;
    public int minuto;
}
public class Tarefa
{
    public int Id;
    public string descricao;
    public DataTarefa momento;
    public int prioridade;
}
public class ServicoTarefa
{
    private List<Tarefa> CarregarLista()
    {
        if (!File.Exists("tarefas.xml"))
            return new List<Tarefa>();

        XmlSerializer serializer = new XmlSerializer(typeof(List<Tarefa>));

        using (StreamReader reader = new StreamReader("tarefas.xml"))
        {
            return (List<Tarefa>)serializer.Deserialize(reader);
        }
    }
    private void SalvarLista(List<Tarefa> lista)
    {
        XmlSerializer formatador = new XmlSerializer(typeof(List<Tarefa>));

        using (StreamWriter escritor = new StreamWriter("tarefas.xml"))
        {
            formatador.Serialize(escritor, lista);
        }
    }
    private int GerarProxID()
    {
        if (ListaTarefas.Count == 0)
            return 1;

        return ListaTarefas.Max(t => t.Id) + 1;
    }
    private List<Tarefa> ListaTarefas;
    public ServicoTarefa()
    {
        ListaTarefas = CarregarLista();
    }
    public void CriarTarefa()
    {
        Tarefa nova = new Tarefa();

        nova.Id = GerarProxID();

        Console.Write("Informe a descrição da tarefa: ");
        nova.descricao = Console.ReadLine();

        nova.momento = new DataTarefa();
        //====================Validação da data==========================

        //DIA
        int dia = 0;
        bool valido = false;
        while (!valido)
        {
            Console.WriteLine("Informe a data da tarefa");
            Console.Write("Dia: ");

            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out dia))
            {
                Console.WriteLine("Entrada inválida");
                continue;
            }
            if (dia < 1 || dia > 31)
            {
                Console.WriteLine("O dia deve estar entre 1 e 31");
                continue;
            }
            valido = true;
        }
        nova.momento.dia = dia;


        //MES
        valido = false;
        int mes = 0;
        while (!valido)
        {
            Console.Write("Mês: ");
            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out mes))
            {
                Console.WriteLine("Entrada inválida");
                continue;
            }
            if (mes < 1 || mes > 12)
            {
                Console.WriteLine("O mês deve ser 1 até 12");
                continue;
            }
            valido = true;
        }
        nova.momento.mes = mes;

        //ANO
        Console.Write("Ano: ");
        nova.momento.ano = int.Parse(Console.ReadLine());

        //PRIORIDADE
        int prioridade = 0;
        valido = false;
        while (!valido)
        {
            Console.Write("Informe a prioridade da tarefa de 1 a 5: ");
            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out prioridade))
            {
                Console.WriteLine("Entrada inválida");
                continue;
            }
            if (prioridade < 0 || prioridade > 5)
            {
                Console.WriteLine("Prioridade deve ser entre 1 e 5");
                continue;
            }
            valido = true;
        }
        nova.prioridade = prioridade;


        ListaTarefas.Add(nova);
        SalvarLista(ListaTarefas);

        Console.WriteLine("Tarefa criada com sucesso!");
        Console.ReadKey();
    }
    public void MostraLista()
    {
        if (ListaTarefas.Count == 0)
            Console.WriteLine("Lista de tarefas vazia");
        else
        {
            Console.WriteLine("====TAREFAS====");
            foreach (Tarefa T in ListaTarefas)
            {
                Console.WriteLine($"ID:{T.Id} - {T.descricao} - {T.momento.dia}/{T.momento.mes}/{T.momento.ano} - Prioridade {T.prioridade}");
            }
        }
        Console.WriteLine();
        Console.WriteLine("Precione para voltar");
        Console.ReadKey();

    }
    public void ExcluirTarefa()
    {
        Console.Write("Informe o ID da tarefa a ser excluída: ");
        int IDdelete = int.Parse(Console.ReadLine());
        bool removeu = false;
        if (ListaTarefas.Count == 0)
        {
            Console.WriteLine("Lista vazia");
            Console.ReadKey();
        }
        else
        {
            for (int i = 0; i < ListaTarefas.Count; i++)
            {
                if (ListaTarefas[i].Id == IDdelete)
                {
                    ListaTarefas.RemoveAt(i);
                    removeu = true;
                }
            }
        }
        if (!removeu)
        {
            Console.WriteLine("Tarefa não encontrada");
        }
        else
        {
            Console.WriteLine("Tarefa removida");
        }
        Console.ReadKey();
    }
}
public class Menu
{
    public void Mostramenu(ServicoTarefa service)
    {
        Console.WriteLine("=====MENU=====");
        Console.WriteLine("1 - Criar Tarefa");
        Console.WriteLine("2 - Listar Tarefas");
        Console.WriteLine("3 - Excluir Tarefas");
        Console.Write("Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            /*Criar Tarefa*/
            case 1:
                Console.Clear();
                service.CriarTarefa();
                break;
            /*Listar Tarefas*/
            case 2: /*Aqui depois vai ter um escopo de data ou opção para listar todas as tarefas*/
                Console.Clear();
                service.MostraLista();
                break;
            /*Excluir Tarefa*/
            case 3:
                Console.Clear();
                service.ExcluirTarefa();
                break;
        }
    }
}
public class Program
{
    static void Main()
    {
        ServicoTarefa servico = new ServicoTarefa();
        Menu menutarefas = new Menu();
        do
        {
            Console.Clear();
            menutarefas.Mostramenu(servico);
        } while (true);
    }
}