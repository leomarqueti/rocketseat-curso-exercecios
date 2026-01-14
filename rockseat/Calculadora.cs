namespace Calculadora;

using PegarDado;
public class Calculadora
{
    public static double Somar(double numero1, double numero2)
    {
        return numero1 + numero2;
    }

    public static double Subtracao(double numero1, double numero2)
    {
        return numero1 - numero2;
    }

    public static double Multiplicacao(double numero1, double numero2)
    {
        return numero1 * numero2;
    }

    public static double Dividir(double numero1, double numero2)
    {
        return numero1 / numero2;
    }


    public static double Media(double numero1, double numero2)
    {
        return (numero1 + numero2) / 2;
    }
    public static void Calcular()
    {


        double numero1 = PegarDado.Double("Digite o primeiro numero: ");
        double numero2 = PegarDado.Double("Digite o segundo numero:");

        Console.WriteLine($"Soma: {Calculadora.Somar(numero1, numero2)}");
        Console.WriteLine($"Subtração: {Calculadora.Subtracao(numero1, numero2)}");
        Console.WriteLine($"Multiplicação: {Calculadora.Multiplicacao(numero1, numero2)}");

        if (numero2 != 0)
        {
            Console.WriteLine($"Divisão: {Calculadora.Dividir(numero1, numero2)}");
        }
        else
        {
            Console.WriteLine($"O segundo numero é 0 , impossivel dividir por 0");
        }

        Console.WriteLine($"Media: {Calculadora.Media(numero1, numero2)}");

    }


}
