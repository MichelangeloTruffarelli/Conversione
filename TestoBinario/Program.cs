using System;

namespace TestoBinario
{
    class Program
    {
        static void Main(string[] args)
        {
          string s;
          Console.WriteLine(" Inserisci parola: ");
          s = Console.ReadLine();
          foreach (char c in s)
           {
              Console.WriteLine((int)c);
           }
            Console.ReadLine();
        }
    }
}
