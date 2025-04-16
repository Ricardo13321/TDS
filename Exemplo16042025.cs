using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyNamespace
{
    class ManipuladorNumero
    {
        public int fatorial(int num)
        {
            int resultado;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                resultado = num;
                for (int i = num - 1; i >= 1; i--)
                {
                    resultado = resultado * i;
                }
                return resultado;

            }
        }
        static void Main(string[] args)
        {
            ManipuladorNumero n = new ManipuladorNumero();
            WriteLine("Digite um número inteiro");
            int numero = Convert.ToInt32(ReadLine());
            WriteLine("O fatorial do número digitado é: {0}", n.fatorial(numero));
            int _loc_ = 41534634165446464654564;
            WriteLine(_loc_);
        }
    }
}

________________________________________________________________________________________

using static System.Console;

namespace MyNamespace
{
    class MainClass
    {
        public static int CalculaIdade(int num)
        {
            int resultado;
            resultado = DateTime.Today.Year - num;
            return resultado;
        }

        static void Main()
        {
            WriteLine("Digite o ano que você nasceu");
            int Ano = Convert.ToInt32(ReadLine());
            WriteLine($"A sua idade é {CalculaIdade(Ano)}");
        }
    }
}
