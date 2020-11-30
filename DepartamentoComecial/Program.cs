using System;

namespace DepartamentoComecial
{
    class Program
    {

        static void Main(string[] args)
        {
            Vendedores vendedores = new Vendedores();
            //
            int resp;
            do
            {
                Console.WriteLine("0-sair\n1-Cadastrar Vendedor\n2-Consultar Vendedor\n3-Excluir Vendedor\n4-Registrar Venda\n5-Listar vendedores");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (x)
                {
                    case 0:
                        break;
                    case 1:
                        int id;
                        string nome;
                        double percComissao;
                        Console.WriteLine("ID do vendedor:");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("nome do vendedor:");
                        nome = Console.ReadLine();
                        Console.WriteLine("% das vendas:");
                        percComissao = double.Parse(Console.ReadLine());
                        Vendedor vendedor = new Vendedor(id, nome, percComissao);
                        vendedores.addVendedor(vendedor);
                        break;
                    case 2:
                        Console.WriteLine("ID do vendedor para consultar:");
                        id = int.Parse(Console.ReadLine());
                        vendedor = new Vendedor(id);
                        vendedores.searchVendedor(vendedor);
                        break;
                    case 3:
                        Console.WriteLine("ID do vendedor para deletar:");
                        id = int.Parse(Console.ReadLine());
                        vendedor = new Vendedor(id);
                        vendedores.delVendedor(vendedor);
                        break;
                    case 4:
                        int qtde, dia;
                        double valor;
                        Console.WriteLine("ID do vendedor:");
                        id = int.Parse(Console.ReadLine());
                        vendedor = new Vendedor(id);
                        Console.WriteLine("Quantidade:");
                        qtde = int.Parse(Console.ReadLine());
                        Console.WriteLine("Valor:");
                        valor = Double.Parse(Console.ReadLine());
                        Venda venda = new Venda(qtde,valor);
                        //int dia =  0;
                        Console.WriteLine("Dia:");
                        dia = int.Parse(Console.ReadLine());
                        vendedor.registrarVenda(dia,venda);
                        break;
                    case 5:
                        vendedores.listarVendedor();
                        break;
                }
                
                Console.WriteLine("Deseja voltar ao menu?\n1-Sim\n2-Não");
                resp = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (resp == 1);
            
        }
    }
}