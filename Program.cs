using static System.Console;

List<string> NameList = new List<string> { };

for (int i = 0; i < 10; i++)
{
    Write($"Escreva o nome: ");
    NameList.Add(ReadLine());
}
WriteLine("\n####################################");
WriteLine("              LISTA DE NOMES");
WriteLine("####################################");
foreach (var _loc_ in NameList)
{
    WriteLine(_loc_);
}
ReadLine();