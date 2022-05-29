using System;
using jogoRPG.src.Entities;

namespace jogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "Wizard");

            Console.WriteLine(wizard.Attack());
            Console.WriteLine(hero.Attack());
        }
    }
}
