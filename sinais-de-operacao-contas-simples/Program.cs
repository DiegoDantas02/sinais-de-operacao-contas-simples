using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        int operacao = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = 0;

        switch (operacao)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }

        Console.WriteLine("O resultado da operação é: " + resultado);

        Console.ReadLine();
    }
}
