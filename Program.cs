using System;
using jogoRPG.src.Entities;

namespace jogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 23, "Knight", 100.0);
            Wizard wizard = new Wizard("Jenica", 23, "Wizard", 100.0);

            Console.WriteLine(wizard.Attack("Arus", 10.0));
            Console.WriteLine(wizard.Attack(10));
            Console.WriteLine(hero.Attack("Jenica", 8.3));
        }
    }
}
