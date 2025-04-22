using System.Numerics;
using static System.Console;

namespace menu
{
    class MainClass
    {
        public static void printMenu(String[] options)
        {
            Carregar();
            foreach (String option in options)
            {
                Console.WriteLine(option);
            }
            Console.Write("Escolha a sua opção : ");
        }



        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<<<<<<<<<<<<<<<< MENU >>>>>>>>>>>>>>>");
            ForegroundColor = ConsoleColor.White;
            String[] options =
                {
                    "1- Registrar Nova Turma",
                    "2- Registrar Novo Aluno",
                    "3- Registrar Nota",
                    "4- Exibir Aprovados",
                    "5- Exibir Recuperação",
                    "6- Exibir Reprovados",
                    "7- Exibir Lista Geral",
                    "8- Sair"
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
                        CadastrarTurma();
                        break;
                    case 2:
                        CadastrarAluno();
                        break;
                    case 3:
                        RegistrarNota();
                        break;
                    case 4:
                        ExibirListaAlunos(7,10);
                        break;
                    case 5:
                        ExibirListaAlunos(5,6.9);
                        break;
                    case 6:
                        ExibirListaAlunos(0,4.9);
                        break;
                    case 7:
                        ExibirListaAlunos(0,10);
                        break;
                    case 8:
                        Gravar();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Por favor, digite uma opção entre 1 e  " + options.Length);
                        break;
                }

            }
        }

        static List<List<double>> Exame1 = new List<List<double>>();
        static List<List<double>> Exame2 = new List<List<double>>();
        static List<List<String>> Turmas = new List<List<String>>();
        static List<String> NomeDasTurmas = new List<string>();

        private static void CadastrarTurma()
        {
            EscreverCabecalho("=              CADASTRAR TURMA               =");
            WriteLine("\nDigite o nome da turma: ");
            String Turma = ReadLine();
            if (VerificarNome(Turma))
            {
                NomeDasTurmas.Add(Turma);
                List<String> _loc_ = new List<String>();
                Turmas.Add(_loc_);
            }
        }

        private static void CadastrarAluno()
        {
            EscreverCabecalho("=              CADASTRAR ALUNO               =");
            WriteLine("\nDigite o nome do(a) aluno(a): ");
            String Aluno = ReadLine();
            WriteLine("Digite o nome da turma: ");
            int Turma = PegarIdTurma(ReadLine());
            Turmas[Turma].Add(Aluno);
        }

        private static void RegistrarNota()
        {
            WriteLine("LISTA DE ALUNOS");
            ExibirListaAlunos(0, 10);
            WriteLine("Digite o nome do aluno");
            string Aluno = ReadLine();

            WriteLine("Qual exame você quer alterar o valor: ");
            int Op = Convert.ToInt32(ReadLine());

            WriteLine($"Digite o valor do {Op}º exame");
            int Nota = Convert.ToInt32(ReadLine());
            int Id = PegarIdAluno(Aluno);
            
            if (Op == 1)
            {
                Exame1[Id].Add(Nota);
            } 
            else  if(Op == 2)
            {
                Exame2[Id].Add(Nota);
            }
        }

        private static void ExibirListaAlunos(double min, double max)
        {

        }

        private static int PegarIdTurma(String Nome)
        {
            return 0;
        }

        private static int PegarIdAluno(String Aluno)
        {
            return 0;
        }

        private static Boolean VerificarNome(String turma)
        {
            Boolean repetido = NomeDasTurmas.Any(x => x.Contains(turma));
            if (repetido)
            {
                WriteLine($"A turma {turma} já consta em nossos registros!");
                return false;
            }
            else
            {
                return true;
            }
        }
        
        /*
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
            /*int index = nomes.IndexOf(nome);
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
        */
        private static void Gravar()
        {
            EscreverCabecalho("=            GRAVAR NO ARQUIVO              =");
            try
            {
                StreamWriter dadosnomes;
                string arq = @"C:\Cu\Turmas.txt";
                dadosnomes = File.CreateText(arq);
                foreach (var item in Turmas)
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
            var nome = File.ReadAllLines(@"C:\\Cu\\Turmas.txt");
            for (int i = 0; i < nome.Length; i++)
            {
                Turmas.Add(nome[i]);
            }
        }

        private static void EscreverCabecalho(String Titulo)
        {
            Clear();
            WriteLine($"=============================================\n{Titulo}\n=============================================");
        }

    }
}