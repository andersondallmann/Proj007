using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //Start(6);// Passando um parâmetro para o método
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); //ToLower converte tudo em minusculo!!!
            char type = char.Parse(data.Substring(data.Length - 1, 1));

            int time = int.Parse(data.Substring(0, data.Length - 1));
            /* data.Length conta quantos caracteres contém a string, portanto podemos "pegar" 
            o último caracter digitado */

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready.....");
            Thread.Sleep(1000);
            Console.WriteLine("Set.....");
            Thread.Sleep(1000);
            Console.WriteLine("Go.....");
            Thread.Sleep(2500);
            Start(time);
        }

        static void Start(int time)
        {
            int currenteTime = 0;

            while (currenteTime != time)
            {
                Console.Clear();
                currenteTime++;
                Console.WriteLine(currenteTime);
                Thread.Sleep(1000); // Comando para esperar uma determinado tempo, 1000 = 1segundo.
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2000);
            Menu();
        }
    }
}