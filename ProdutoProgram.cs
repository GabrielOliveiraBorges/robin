using Exercicio_3;

class Program
{
    static void Main()
    {
        Produto produto = new Produto();

        Console.Write("Digite o nome do produto: ");
        produto.Nome = Console.ReadLine();
        Console.Write("Digite o preço do produto: ");
        produto.Preco = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a quantidade em estoque: ");
        produto.Quantidade = int.Parse(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("\nEscolha uma opcao:");
            Console.WriteLine("1. Adicionar ao estoque");
            Console.WriteLine("2. Remover do estoque");
            Console.WriteLine("3. Exibir detalhes");
            Console.WriteLine("4. Sair");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Digite a quantidade para adicionar ao estoque: ");
                int quantidade = int.Parse(Console.ReadLine());
                produto.AdicionarEstoque(quantidade);
            }
            else if (opcao == 2)
            {
                Console.Write("Digite a quantidade para remover do estoque: ");
                int quantidade = int.Parse(Console.ReadLine());
                produto.RemoverEstoque(quantidade);
            }
            else if (opcao == 3)
            {
                produto.ExibirDetalhes();
            }
            else if (opcao == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("invalido.");
            }
        }
    }
}
