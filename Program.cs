using DesafioEstacionamento.Models;
Estacionamento estacionamento = new Estacionamento();

Console.WriteLine("Bem-vindo ao Sistema de Estacionamento!");
Console.WriteLine("Digite o valor Inicial: ");
estacionamento.valorInicial = decimal.Parse(Console.ReadLine());
Console.WriteLine("\nDigite o valor por hora: ");
estacionamento.valorPorHora = decimal.Parse(Console.ReadLine());

bool exibirMenu = true;
string opcao;

while (exibirMenu == true)
{
    Console.Clear();
    Console.WriteLine("Digite a Opção Desejada");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar Programa");

   opcao = Console.ReadLine();

   Console.Clear();

    switch(opcao)
    {
    case "1":
        Console.WriteLine("Digite a placa do veículo: ");
        estacionamento.CadastrarVeiculo(Console.ReadLine());
        break;

    case "2":
        Console.WriteLine("Digite a placa do veículo: ");
        estacionamento.RemoverVeiculo(Console.ReadLine());
        break;
    
    case "3":
        estacionamento.ListarVeiculos();
        break;
    case "4":
        exibirMenu = false;
        break;  

    default:
    Console.WriteLine("Opção inválida");
    break;      
    }

    Console.WriteLine("\nPressione Enter para continuar");
    Console.ReadLine();
    
} 