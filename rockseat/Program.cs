
namespace Rocktseat;
using Calculadora;
using PegarDado;

class Program 
{

    public static void MensagemDeBoasVindas(string nome)
    {
        Console.WriteLine($"Olá, {nome.ToUpper().Trim()}! Seja muito bem-vindo");
    }

    public static string TratarNome(string nome)
    {
        return nome.ToUpper().Trim();
    }

    public static void ConcaterNomeSobrenome(string nome, string sobrenome)
    {
        string nomeCompleto = $"Ola, {TratarNome(nome)} {TratarNome(sobrenome)}";
        Console.WriteLine(nomeCompleto);
    }

    //----------------------------------------------------------

    public static int TamanhoDeUmaString(string str) {

        string partes = str.Replace(" ", "");
        partes = partes + ' ';
        int n = 0;
        while (true)
        {

            if (partes[n] == ' ')
            {
                break;
            }
            n++;
        }

        return n;
    }

    //--------------------------------------------------------------------------

    public static bool VerificadorDeLetra(string str)
    {
        
        bool temLetra = false;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]) == false)
            {
                temLetra = true;
                return true;
            }
        }

        return temLetra;
    }
    public static void VerificadorDePlaca(string texto)
    {
        string placa = texto.Trim();
        Console.WriteLine($"3 primeiros {placa.Substring(0, 3)}");

        bool primeirosCaracteres = placa.Substring(0, 3).Any(char.IsDigit);
        bool ultimosCaracteres = VerificadorDeLetra(placa.Substring(3,4));

        
        Console.WriteLine(placa.Length == 7 & primeirosCaracteres == false & ultimosCaracteres == false ? "***Verdadeiro***" : "***Falso***");  
    }

    //--------------------------------------------------------------------------
    static void Main()
    {

        Console.WriteLine("Primeiro exercicio: Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!\n\n");
        /*
             Crie um programa em que o usuário precisa digitar um nome e uma mensagem de 
                boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!

         */
        string nome = PegarDado.Texto("Digite o seu nome: ");
        MensagemDeBoasVindas(TratarNome(nome));

        //-----------------------------------------------------------------------------------------------------

        /*
                Crie um programa que concatene um nome e um  sobrenome inseridos pelo usuário e ao final exiba o nome completo.
         */

        Console.WriteLine("\n\nCrie um programa que concatene um nome e um  sobrenome inseridos pelo usuário e ao final exiba o nome completo.\n\n");

        string nomeUsario = PegarDado.Texto("Digite o seu nome: ");
        string sobreNomeUsuario = PegarDado.Texto("Digite o seu sobrenome: ");

        ConcaterNomeSobrenome(nomeUsario, sobreNomeUsuario);

        //-----------------------------------------------------------------------------------------------------


        /*
            1. Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
                - A soma entre esses dois números;
                - A subtração entre os dois números;
                - A multiplicação entre os dois números;
                - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
                - A média entre os dois números.
         */

        Console.WriteLine("\n\n");
        Console.WriteLine(@"Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
                - A soma entre esses dois números;
                - A subtração entre os dois números;
                - A multiplicação entre os dois números;
                - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
                - A média entre os dois números.");
        Console.WriteLine("\n\n");

        Calculadora.Calcular();

        //-----------------------------------------------------------------------------------------------------

        /*
                 Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de 
                caracteres que a palavra inserida tem.
         */

        Console.WriteLine("\n\nCrie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.\n\n");

        string nome3 = PegarDado.Texto("Digite uma palavra ou texto");
        //essa funçao que eu fiz conta so as palavras e ignora os espaços
        Console.WriteLine($"Numero de caracteres sem contara os espaços: {TamanhoDeUmaString(nome3)}");
        //da p
        Console.WriteLine($"Numero de caracteres contando os espaços: {nome3.Length}");

        /*
         1. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, 
        seguindo o padrão brasileiro válido até 2018:
            - A placa deve ter 7 caracteres alfanuméricos;
            - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
            - Os quatro últimos caracteres são números;
    
            Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.
         */
        Console.WriteLine("\n\n");
        Console.WriteLine(@"1. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, 
        seguindo o padrão brasileiro válido até 2018:
            - A placa deve ter 7 caracteres alfanuméricos;
            - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
            - Os quatro últimos caracteres são números;
    
            Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.");

        string placa = PegarDado.Texto("Digite uma placa de carro");
        VerificadorDePlaca(placa);
        Console.WriteLine("\n\n");
        //---------------------------------------------------------------------------------------------------------

        /*
         1. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
            - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
            - Apenas a data no formato "01/03/2024".
            - Apenas a hora no formato de 24 horas.
            - A data com o mês por extenso.
         */

        Console.WriteLine(@"Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
            - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
            - Apenas a data no formato ""01/03/2024"".
            - Apenas a hora no formato de 24 horas.
            - A data com o mês por extenso.");

        Console.WriteLine("\n\n");

        int dia = PegarDado.Inteiro("Digite o dia:");
        int mes = PegarDado.Inteiro("Digite o mes");
        int ano = PegarDado.Inteiro("Digite o ano");

        DateOnly data = new DateOnly(ano,mes,dia);
        DateTime hora = DateTime.UtcNow;

        Console.WriteLine(data.ToLongDateString() + hora);
        Console.WriteLine(data.ToShortDateString());

    }
}
