using System.Numerics;
using static System.Console;

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

        static List<string> nomes = new List<string>();

        private static void Cadastrar()
        {
            EscreverCabecalho("=              CADASTRAR NOME               ="); 
            WriteLine("\nDigite um nome: ");
            String nome = ReadLine();
            if (VerificarNome(nome))
            {
                nomes.Add(nome);
            }
        }

        private static void Editar()
        {
            EscreverCabecalho("=               EDITAR NOME                 =");
            WriteLine("\nDigite o nome que você deseja editar: ");
            string nome = ReadLine();
            int index = nomes.IndexOf(nome);
            if (index >= 0)
            {
                WriteLine($"\n O nome que será editado é {nomes[index]}\n Redigite o nome:");
                string novonome = ReadLine();
                if (VerificarNome(novonome))
                {
                    nomes[index] = novonome;
                }
            }
            
        }

        private static void Excluir()
        {
            EscreverCabecalho("=              EXCLUIR NOME                 =");
            WriteLine("\nDigite o nome que deseja excluir: ");
            string nome = ReadLine();
            int index = nomes.IndexOf(nome);
            if (index >= 0)
            {
                WriteLine($"\nO nome que será excluído é {nomes[index]}\nConfirma (s/n)?");
                string confirma = ReadLine();
                if (confirma == "s")
                {
                    nomes.RemoveAt(index);
                }
            }
        }

        private static void Gravar()
        {
            EscreverCabecalho("=            GRAVAR NO ARQUIVO              =");
            try
            {
                StreamWriter dadosnomes;
                string arq = @"C:\nomes\nomes.txt";
                dadosnomes = File.CreateText(arq);
                foreach (var item in nomes)
                {
                    dadosnomes.WriteLine($"{item}");
                }
                dadosnomes.Close();
            }
            catch (Exception e)
            {
                WriteLine($"{e.Message}");
            } 
            finally
            {
                WriteLine("<<<<<<<< DADOS GRAVADOS COM SUCESSO! >>>>>>>>>");
            }
        }

        private static void Carregar()
        {
            EscreverCabecalho("=            CARREGAR NO ARQUIVO            =");
            var nome = File.ReadAllLines(@"C:\\nomes\\nomes.txt");
            for (int i = 0; i < nome.Length; i++)
            {
                nomes.Add(nome[i]);
            }
        }

        private static void EscreverCabecalho(String Titulo)
        {
            Clear();
            WriteLine($"=============================================\n{Titulo}\n=============================================");
        }

        private static Boolean VerificarNome(String nome)
        {
            Boolean repetido = nomes.Any(x => x.Contains(nome));
            if (repetido)
            {
                WriteLine("Este nome já consta em nossos registros!");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}