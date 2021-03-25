using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string c , i , t ;
            double capital , taxaJuros , tempo , juros , montante;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------");
            Console.WriteLine("/Juros simples/");
            Console.WriteLine("---------------\n");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Digite o capital: ");
            c = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite a taxa de juros: ");
            i = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite o tempo: ");
            t = Console.ReadLine();
            Console.WriteLine();

            capital = Convert.ToDouble(c);
            
            taxaJuros = Convert.ToDouble(i);

            tempo = Convert.ToDouble(t);

            juros = capital * (taxaJuros / 100) * tempo;

            montante = capital + juros;
        
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Juros .....: {juros:C}\n");
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"Montante ..: {montante:C}\n");
            Console.ResetColor();





        }
    }
}
