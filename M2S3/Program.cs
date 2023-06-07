using M2S3.Carros;

Proprietarios proprietario1 = new Proprietarios() 
    { Nome = "José", CPF = "077.589.394-24", Telefone = "048 3265 1456" };
Proprietarios proprietario2 = new Proprietarios() 
    { Nome = "João", CPF = "077.589.354-24", Telefone = "048 3265 1556" };
Proprietarios proprietario3 = new Proprietarios() 
    { Nome = "Josefa", CPF = "077.589.343-24", Telefone = "048 3265 5456" };

CadastroCarros carro1 = new CadastroCarros()
{
    Marca = "Volkswagen",
    Modelo = "Fusca",
    Placa = "XYZ-1234",
    Cor = "Amarelo",
    Proprietario = proprietario3
};

CadastroCarros carro2 = new CadastroCarros()
{
    Marca = "Volkswagen",
    Modelo = "Gol",
    Placa = "XRZ-1256",
    Cor = "Rosa",
    Proprietario = proprietario2
};

CadastroCarros carro3 = new CadastroCarros()
{
    Marca = "Volkswagen",
    Modelo = "Polo",
    Placa = "XWZ-2341",
    Cor = "Preto",
    Proprietario = proprietario1
};

List<CadastroCarros> carros = new List<CadastroCarros>();
carros.Add(carro1);
carros.Add(carro2);
carros.Add(carro3);

MostrarCarros(carros);
static void CadastraCarro()
{
    Proprietarios novoProprietario = new Proprietarios();
    Console.WriteLine("Favor informar o nome do proprietário: ");
    novoProprietario.Nome = Console.ReadLine();
    Console.WriteLine("Favor informar o CPF do proprietário: ");
    novoProprietario.CPF = Console.ReadLine();
    Console.WriteLine("Favor informar o telefone do proprietário: ");
    novoProprietario.Telefone = Console.ReadLine();

    CadastroCarros novoCarro = new CadastroCarros();
    Console.WriteLine("Favor informar a marca do carro: ");
    novoCarro.Marca = Console.ReadLine();
    Console.WriteLine("Favor informar modelo: ");
    novoCarro.Modelo = Console.ReadLine();
    Console.WriteLine("Favor informar placa: ");
    novoCarro.Placa = Console.ReadLine();
    Console.WriteLine("Favor informar cor: ");
    novoCarro.Cor = Console.ReadLine();
};

static void MostrarCarros(List<CadastroCarros> carros)
{
    foreach (var carro in carros)
    {
        Console.WriteLine($"{carro}");
    }
}
public static class Math
{
    public static int Soma(int num1, int num2)
    {
        return num1 + num2;
    }

    public static double Soma(double num1, double num2) 
    {
        return num1 + num2; 
    }

    public static double Soma(double num1, double num2, double num3)
    {
        return num1 + num2 + num3;
    }
}

