using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a primeira nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2) / 2;
        Console.WriteLine($"A média é: {media}");
    }
}
