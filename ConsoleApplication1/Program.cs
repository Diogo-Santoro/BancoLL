using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
using BancoLL;
List<Cliente> Clientes = new List<Cliente>();
ConsultarCliente();

void ConsultarCliente()
{
    Console.WriteLine("Olá! Bem Vindo ao Banco LL.");
    Console.WriteLine("Digite seu Código:");
    string codigo = Console.ReadLine();
    Cliente cliente = null;
    foreach (Cliente cli in Clientes)
    {
        if(cli.Codigo == codigo)
        {
            cliente = cli;
        }
    }
    if (cliente == null)
    {
        Console.WriteLine("Este cliente não existe. Para cadastrar digite S, caso contrário digite N");
        string cadastrarCliente = Console.ReadLine();
        if (cadastrarCliente == "S")
        {
            Console.WriteLine("Digite seu código:");
            string codigoClienteNovo = Console.ReadLine();
            Console.WriteLine("Digite seu nome:");
            string nomeClienteNovo = Console.ReadLine();
            Console.WriteLine("Digite PF ou PJ");
            string tipoPessoa = Console.ReadLine();
            if (tipoPessoa == "PF")

                cliente = new PessoaFisica(codigoClienteNovo, nomeClienteNovo);
            else
                cliente = new PessoaJuridica(codigoClienteNovo, nomeClienteNovo);
            Clientes.Add(cliente);
            ExibirMenu(cliente);

        }
        else
            ConsultarCliente();
   }

}
void ExibirMenu(Cliente cliente)
{
    Console.WriteLine($"Olá {Cliente.Nome}");
    Console.WriteLine("Digite a opção desejada:");
    Console.WriteLine("1 - Extrato");
    Console.WriteLine("2 - Saque");
    Console.WriteLine("3 - Deposito");

    string menu = Console.ReadLine;

    switch (menu)
    {
        case "1":
            ExibirExtrato(cliente);
        case "2":
            RealizarSaque(cliente);
        case "3":
            ReazlizarDeposito(cliente);
            break;
        default:
            Console.WriteLine("Digite a opção correta.");
            ExibirMenu(cliente);
            break;
    }
}
void ExibirExtrato()
{
    Console.WriteLine("----- EXTRATO -----");
    foreach Movimentacao mov in cliente.Movimentacoes)
    {
        Console.WriteLine($"{mov.Tipo} - {mov.Valor}");
    }
    Console.WriteLine("Deseja exibir o menu novamente? Digite S ou N");
    string exibirMenu = Console.ReadLine();
    if (exibirMenu == "S")
    { 
        ExibirMenu(cliente);
    }
    else
    {
        Console.WriteLine("Deseja consultar outro cliente? Digite S ou N");
        string consultarCliente = Console.ReadLine();
        if (consultarCliente == "S")
            ConsultarCliente();
    }
}

void RealizarSaque(Cliente cliente)
{
    Console.WriteLine("Digite o valor que deseja sacar:");
    string valor = Console.ReadLine();
    cliente.RealizarSaque(Convert.ToDecimal(valor));
    Console.WriteLine("Deseja realizar outra transação? Digite S ou N");
    string realizarOutraTransacao = Console.ReadLine();
    if (realizarOutraTransacao == "S")

        ExibirMenu(cliente);
    else
        Console.WriteLine("Foi um prazer lhe atender! Até mais!");
}

void RealizarDeposito(Cliente cliente)
{

}
#endregion