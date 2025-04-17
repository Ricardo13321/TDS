using System;

namespace menu
{
    class MainClass
    {
        public static void printMenu(String[] options)
        {
            foreach (String option in options)
            {
                Console.WriteLine(option);
            }
            Console.Write("Escolha a sua opção : ");
        }



        public static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<<<<<<<<<<< NOMES >>>>>>>>>>>>>>>");
            String[] options = 
                {
                    "1- Cadastrar",
                    "2- Editar",
                    "3- Excluir",
                    "4- Gravar",
                    "5- Carregar",
                    "6- Sair"
                };

            int option = 0;
            while (true)
            {
                printMenu(options);
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Por favor, digite uma opção entre 1 e " + options.Length);
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Um erro aconteceu! Tente novamente.");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        Editar();
                        break;
                    case 3:
                        Excluir();
                        break;
                    case 4:
                        Gravar();
                        break;
                    case 5:
                        Carregar();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Por favor, digite uma opção entre 1 e  " + options.Length);
                        break;
                }

            }
        }

        private static void Cadastrar()
        {

        }

        private static void Editar()
        {

        }

        private static void Excluir()
        {

        }

        private static void Gravar()
        {

        }

        private static void Carregar()
        {

        }

    }
}