using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Aluno
    {
        public int RA;
        public string Nome;
        public double NotaProva;
        public double NotaTrabalho;
        public double NotaFinal;
        public void CalcularMedia()
        {
            NotaFinal = (NotaProva + NotaTrabalho) / 2;
        }

        public bool CalcularNotaFinal()
        {
            double notaNecessaria = 6 - NotaFinal;
            Console.WriteLine($"Nota que precisa para prova final: {notaNecessaria}");
            return NotaFinal >= 6;
        }

        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"Nota final {Nome}: {NotaFinal}");
        }

        public void ReceberDados()
        {
            Console.Write("RA: ");
            RA = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Nota: ");
            NotaProva = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota do trabalho : ");
            NotaTrabalho = Convert.ToDouble(Console.ReadLine());
        }
    }

}
