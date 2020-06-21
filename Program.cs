using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua altura em M: ");
            double altura=Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite seu sexo Masculino / Feminino: ");
            string sexo=Console.ReadLine();

            double resultado1=(altura * 72.7) - 58.0;
            double resultado2=(altura * 62.1) - 44.7;

            Console.Clear();

            if(sexo=="Masculino")
            Console.WriteLine($"Seu peso ideal é {resultado1}kg");
            else if(sexo=="Feminino")
            Console.WriteLine($"Seu peso ideal é {resultado2}kg");

        }
    }
}
