Ricardo Gabriel Gomes
______________________________________________________________________________________
Exercício 1:

using System.Text.Json.Serialization;
using static System.Console;

List<string> NameList = new List<string> {"Marcos", "Maria", "Patrícia", "Bernadete", "João", "Gabriel", "João Cleber", "Lucas", "Silvana", "Roberto"};
List<int> Idade = new List<int> {15,18,16,17,19,13,20,24,17,25};
WriteLine("--------------------------------------------------");
for (int i = 0; i < 10; i++)
{
    WriteLine($"Nome: {NameList[i]} -- Idade: {Idade[i]}");
}

for (int i = 0; i < 10; i++)
{
    for (int x = i + 1; x < 10; x++)
    {
        if (Idade[i] < Idade[x])
        {
            string _loc0_ = NameList[i];
            int _loc1_ = Idade[i];
            Idade[i] = Idade[x];
            Idade[x] = _loc1_;
            NameList[i] = NameList[x];
            NameList[x] = _loc0_;
        }
    }
}
WriteLine("--------------------------------------------------");

for (int i = 0; i < 10; i++)
{
    WriteLine($"Nome: {NameList[i]} -- Idade: {Idade[i]}");
}
WriteLine("--------------------------------------------------");
WriteLine($"O estudante mais velho é {NameList[0]} com {Idade[0]} anos");
WriteLine($"O estudante mais novo é {NameList[9]} com {Idade[9]} anos");
ReadLine();
______________________________________________________________________________________
Exercício 2:

using System.Text.Json.Serialization;
using static System.Console;

List<string> NameList = new List<string> {};
List<int> Nota = new List<int> {};
int Media = 0;

for (int i = 0; i < 10; i++)
{
    WriteLine($"Digite o nome do {i + 1}º aluno(a):");
    NameList.Add(ReadLine());
    WriteLine($"Agora digite a nota de {NameList[i]}");
    Nota.Add(Convert.ToInt32(ReadLine()));
    Media += Nota[i];
}
Media = Media / 10;
WriteLine($"\nA média da turma de TDS é :{Media}\n");

for (int i = 0; i < 10; i++)
{
    WriteLine($"Aluno: {NameList[i]} - Nota: {Nota[i]}");
}
ReadLine();

______________________________________________________________________________________
Exercício 3:

using static System.Console;

List<string> NameList = new List<string> { "Ana", "Beatriz", "Camila", "Daniela", "Elisa", "Fernanda", "Gabriela", "Helena", "Isabela", "Juliana", "Karine", "Lara", "Mariana", "Natália", "Olivia", "Priscila", "Rafaela", "Sabrina", "Tatiane", "Vitória" };
List<int> Idade = new List<int> { 17, 22, 18, 21, 19, 22, 20, 17, 21, 18, 22, 19, 20, 21, 17, 22, 18, 19, 20, 21 };
List<string> MulherApta = new List<string> { };
List<int> IdadeApta = new List<int> { };
for (int i = 0; i < 20; i++)
{
    WriteLine($"Nome: {NameList[i]} - Idade: {Idade[i]}");
    if (Idade[i] >= 18 && Idade[i] <= 20)
    {
        MulherApta.Add(NameList[i]);
        IdadeApta.Add(Idade[i]);
    }
}
WriteLine("_________________________________________________________");
for (int i = 0;i < IdadeApta.Count;i++)
{
    WriteLine($"Nome: {NameList[i]} - Idade: {Idade[i]}");
}

ReadLine();

______________________________________________________________________________________
Exercício 4:

using System.Text.Json.Serialization;
using static System.Console;

List<int> V1 = new List<int> {8, 12, 5, 2, 11, 9, 4, 15, 7, 10, 1, 13, 3, 6, 0, 14, 12, 15, 8, 14};
List<int> V2 = new List<int> {6, 14, 2, 10, 4, 13, 8, 1, 7, 15, 12, 5, 9, 3, 11, 0, 6, 4, 10, 14};
int count = 0;

for (int i = 0; i < 20; i++)
{
    if (V1[i] == V2[i])
    {
        count++;
    }
}

WriteLine($"V1 e V2 possuem {count} valore(s) idênticos nas mesmas posições");

ReadLine();

______________________________________________________________________________________
Exercício 5:

using System.Text.Json.Serialization;
using static System.Console;

List<double> NotaList = new List<double> {};
int Count = 0;
bool NotaAcimade50= false;
WriteLine("____________________________________________");
WriteLine("------------Notas dos Alunos----------------");
WriteLine("____________________________________________");
WriteLine("--------------------------------------------");
WriteLine("Use valores entre 0 e 10.0");
WriteLine("--------------------------------------------");
for (int i = 0; i < 15; i++)
{
    Write($"Digite a nota do {i + 1}º Aluno(a):");
	NotaList.Add(Convert.ToDouble(ReadLine()));
}

foreach (var item in NotaList)
{
	if (item >= 7)
	{
		Count++;
	}
    NotaAcimade50 = item >= 5 ? true:false;
}
WriteLine("____________________________________________");
WriteLine(NotaAcimade50? $"{Count} alunos estão com a média acima de 7.0!":"Nenhum aluno(a) tirou nota acima de 5.0!");

ReadLine();

______________________________________________________________________________________
Exercício 6:

using System.Text.Json.Serialization;
using static System.Console;

List<double> Timer = new List<double> {};
double MelhorTempo, Media = 0;
int VoltaDoMelhorTempo = 0;
WriteLine("____________________________________________");
WriteLine("---------------Stop Watch-------------------");
WriteLine("____________________________________________");
WriteLine("--------------------------------------------");
WriteLine("Use valores como 1,20 para representar 01:30s");
WriteLine("--------------------------------------------");
for (int i = 0; i < 12; i++)
{
    Write($"Digite o tempo da {i + 1}º Volta: ");
    Timer.Add(Convert.ToDouble(ReadLine()));
}
MelhorTempo = Timer[0];
for (int i = 0; i < 12; i++)
{
	if (Timer[i] < MelhorTempo)
	{
		MelhorTempo = Timer[i];
		VoltaDoMelhorTempo = i;
	}
	Media += Timer[i]; 
}

Media = Media / 12;
WriteLine("____________________________________________");
WriteLine($"O melhor tempo: {MelhorTempo:F2}");
WriteLine($"Melhor volta foi: {VoltaDoMelhorTempo}");
WriteLine($"Media: {Media:F2}");

ReadLine();

______________________________________________________________________________________
Exercício 7:

using System.Text.Json.Serialization;
using static System.Console;

List<int> list = new List<int>();
int MaiorValor = 0, Media = 0;

WriteLine("Quantos alunos você quer salvar?");
int _loc_ = Convert.ToInt32(Console.ReadLine());
Clear();
for (int i = 0; i < _loc_; i++)
{
    Write($"Digite o {i+1}º valor: ");
    list.Add(Convert.ToInt32(ReadLine()));
    MaiorValor = MaiorValor < list[i] ? list[i] : MaiorValor;
    Media += list[i];
    Clear();
}
Media = Media / _loc_;
Clear();
WriteLine($"Média: {Media}");
WriteLine($"O valor mais alto: {MaiorValor}");

ReadLine();
Clear();

______________________________________________________________________________________
Exercício 8:

using System.Text.Json.Serialization;
using static System.Console;

List<double> G1 = new List<double>();
List<double> G2 = new List<double>();
List<double> Media = new List<double>();
int _loc_;

Write("Informe a quantidades de alunos: ");
_loc_ = Convert.ToInt32(Console.ReadLine());

WriteLine("Informe as notas dos alunos de 0 à 10");
for (int i = 0; i < _loc_; i++)
{
    Write($"Digite a nova do {i+1}º Aluno(a): ");
    G1.Add(Convert.ToDouble(Console.ReadLine()));
    Write($"Digite a nova do {i + 1}º Aluno(a): ");
    G2.Add(Convert.ToDouble(Console.ReadLine()));
    Media.Add((G1[i] + G2[i]) / 2);
}
WriteLine("|Aluno | G1 | G2|");
WriteLine("|---------------|");
for (int i = 0; i < _loc_; i++)
{
    WriteLine($"|   {i+1}  | {G1[i]}  | {G2[i]} |");
}

ReadLine();
Clear();
______________________________________________________________________________________
Exercício 9:

using System.Text.Json.Serialization;
using static System.Console;

List<int> list = new List<int>();
List<int> Par = new List<int>();
List<int> Impar = new List<int>();

WriteLine("Digite 10 valores");
WriteLine("---------------------------------------");
for (int i = 0; i < 10; i++)
{
    Write($"Digite o {i}º valor: ");
    list.Add(Convert.ToInt32(ReadLine()));
    if (list[i]%2 == 0)
    {
        Par.Add(list[i]);
    } else
    {
        Impar.Add(list[i]);
    }
}
list.Sort();
Par.Sort();
Impar.Sort();

WriteLine("---------------------------------------");

Write("Todos os valores: ");
foreach (var  _loc_ in list)
{
    Write($"{_loc_} ");
}

Write("\nPares: ");
foreach (var _loc_ in Par)
{
    Write($"{_loc_} ");
}

Write("\nÍmpares: ");
foreach (var _loc_ in Impar)
{
    Write($"{_loc_} ");
}
ReadLine();
Clear();
______________________________________________________________________________________
Exercício 10:

using System.Text.Json.Serialization;
using System.Xml.Serialization;
using static System.Console;

List<int> Gabarito = new List<int>() {3, 1, 5, 2, 4, 1, 3, 5, 2, 4, 1, 5, 3};
List<int> R1 = new List<int>() { 2, 5, 1, 4, 3, 2, 5, 1, 3, 4, 2, 5, 1 };
List<int> R2 = new List<int>() { 3, 1, 5, 2, 4, 1, 3, 5, 2, 4, 1, 5, 3 };
List<int> R3 = new List<int>() { 5, 3, 2, 4, 1, 5, 2, 3, 1, 4, 5, 2, 3 };
List<string> Nomes = new List<string>() {"Maria", "Bruno", "João Cleber"};
List<List<int>> Listas = new List<List<int>>() {R1, R2, R3};
int Count = 0;

for (int i = 0; i < 3; i++)
{
    WriteLine("----------------------------------------");
    WriteLine($"Nome: {Nomes[i]}");
	Write("Respostas: ");
    for (int x = 0; x < 13; x++)
    {
        Write(Listas[i][x]+" ");
        Count = Listas[i][x] == Gabarito[x]? Count+1 : Count;
    }
    WriteLine($"\nAcertos: {Count}");
    if (Count == 13)
    {
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Ganhou!");
        ForegroundColor = ConsoleColor.White;
    }
    Count = 0;
}


ReadLine();
Clear();
