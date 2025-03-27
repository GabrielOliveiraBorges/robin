using Exercicio_4;

class Program
{
    static void Main()
    {
        Lampada lampada = new Lampada();

        while (true)
        {
            Console.WriteLine("\nEscolha uma opcao:");
            Console.WriteLine("1. Liga");
            Console.WriteLine("2. Disliga");
            Console.WriteLine("3. Mostrar estado da lâmpada");
            Console.WriteLine("4. Sair");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                lampada.Ligar();
            }
            else if (opcao == 2)
            {
                lampada.Desligar();
            }
            else if (opcao == 3)
            {
                lampada.MostrarEstado();
            }
            else if (opcao == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Opcaoo invalida.");
            }
        }
    }
}