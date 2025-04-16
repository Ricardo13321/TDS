using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace menu
{
    class MainClass
    {
        public static void printMenu(String[] options)
        {
            foreach(String option in options)
            {
                WriteLine(option);
            }
            Write("Escolha a sua opção: ");
        }

        private static void option1()
        {
            int Number_1, Number_2, Sum;
            WriteLine("Digite o primeiro valor");
            Number_1 = Convert.ToInt32(ReadLine());
            WriteLine("Digite o primeiro valor");
            Number_2 = Convert.ToInt32(ReadLine());
            Sum = Number_1 + Number_2;
            WriteLine($"A soma dos valres {Number_1} e {Number_2} é {Sum}");
        }

        private static void option2()
        {
            int Number_1, Number_2;
            WriteLine("Digite o primeiro valor");
            Number_1 = Convert.ToInt32(ReadLine());
            WriteLine("Digite o primeiro valor");
            Number_2 = Convert.ToInt32(ReadLine());
        }

        private static void option3()
        {
            WriteLine("Executando a opção 4");
        }

        private static void Exit()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("Programa finalizado...");
            ForegroundColor = ConsoleColor.Black;
            CursorVisible = false;
            Write("");
            Environment.Exit(0);
        }

        public static void Main(String[] args)
        {
            WriteLine("<<<<<<< MENU >>>>>>>>");
            String[] options = { "1 - Opção 1", "2 - Opção 2", "3 - Opção 3", "4 - Exit" };
            int option = 0;
            Title = "Menu :3";

            while(true)
            {
                printMenu(options);

                try
                {
                    option = Convert.ToInt32(ReadLine());
                }
                catch (System.FormatException exception)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"Error: {exception}");
                    ForegroundColor = ConsoleColor.White;
                }
                catch (Exception exception)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"Error Fatal: {exception}");
                    ForegroundColor = ConsoleColor.White;
                }
                switch (option)
                {
                    case 1:
                        option1();
                        break;
                    case 2:
                        option2();
                        break;
                    case 3:
                        option3();
                        break;
                    case 4:
                        Exit();
                        break;
                    default:
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine($"POR FAVOR DIGITE UMA OPÇÃO ENTRE 1 e {options.Length}!");
                        ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
    }
}