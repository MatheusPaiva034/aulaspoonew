//Matheus Paiva Batista - 032064
using System;

namespace EXERCICIO__ROBINSON
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // PRODUTO
            PRODUTO prod = new PRODUTO();

            Console.Write("Digite o nome do produto: ");
            prod.Nome = Console.ReadLine();

            Console.Write("Digite a quantidade: ");
            prod.quantidade = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço: ");
            prod.Preco = double.Parse(Console.ReadLine());


            Console.Write("Digite a categoria: ");
            prod.Categoria = Console.ReadLine();


            // CLIENTE
            CLIENTE cliente = new CLIENTE();

            Console.Write("Digite o nome do cliente: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Digite o CPF: ");
            cliente.CPF = Console.ReadLine();

            Console.Write("Digite o email: ");
            cliente.Email = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            cliente.Telefone = Console.ReadLine();


            // LOJA
            LOJA loja = new LOJA();

            Console.Write("Digite o nome da loja: ");
            loja.Nome = Console.ReadLine();

            Console.Write("Digite a cidade da loja: ");
            loja.Cidade = Console.ReadLine();

            Console.Write("Digite a taxa de entrega: ");
            loja.TaxaEntrega = double.Parse(Console.ReadLine());

            // PEDIDO
            PEDIDO ped = new PEDIDO();

            Console.Write("Digite o número do pedido: ");
            ped.Numero = int.Parse(Console.ReadLine());


            Console.Write("Digite o percentual de desconto: ");
            ped.DescontoPercentual = double.Parse(Console.ReadLine());

            // ===== CÁLCULOS =====

            double ValorBruto = prod.Preco * prod.quantidade;
            double ValorDesconto = ValorBruto * (ped.DescontoPercentual / 100);
            double ValorFinal = ValorBruto - ValorDesconto;
            double ValorTotal = ValorFinal + loja.TaxaEntrega;

            ped.ValorTotal = ValorTotal;

            // ===== SAÍDA =====
            Console.WriteLine("\n===== RESUMO DO PEDIDO =====");
            Console.WriteLine("Valor Bruto: R$ " + ValorBruto);
            Console.WriteLine("Valor Desconto: R$ " + ValorDesconto);
            Console.WriteLine("Valor Final (sem entrega): R$ " + ValorFinal);
            Console.WriteLine("Valor Total (com entrega): R$ " + ValorTotal);
            Console.WriteLine("Obrigado por comprar na " + loja.Nome + "!");
            Console.WriteLine("Cliente: " + cliente.Nome + "  VOLTE SEMPRE!");
            Console.ReadKey();
        }
    }
}