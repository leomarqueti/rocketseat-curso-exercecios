using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegarDado;
public class PegarDado
{

    public static string Texto(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }

    public static int Inteiro(string prompt)
    {
        Console.WriteLine(prompt);
        return int.Parse((Console.ReadLine()));
    }

    public static double Double(string prompt)
    {
        Console.WriteLine(prompt);
        return double.Parse((Console.ReadLine()));
    }

}
