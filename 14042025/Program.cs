using static System.Console;

List<int> numberList = new List<int> { };

numberList.Add(21);
numberList.Add(13);
numberList.Add(17);
numberList.Insert(1, 234);
numberList.RemoveAt(0);
//numberList.Clear();

foreach (var _loc_ in numberList)
{
    WriteLine(_loc_);
}
try
{
    WriteLine("2º elemento da lista:  " + numberList[1].ToString());
    WriteLine("Números de elementos na lista: " + numberList.Count().ToString());
    WriteLine("Capacidade da minha lista: " + numberList.Capacity.ToString());
}
catch (Exception erro)
{
    ForegroundColor = ConsoleColor.Red;
    WriteLine($"Aconteceu um erro inesperado:\n{erro}");
    ForegroundColor = ConsoleColor.White;
}

int Number = numberList.IndexOf(99999999);

WriteLine(Number != -1 ? $"O valor foi encontrado e está na posição: {Number.ToString()}!" : "O valor não foi encontrado!");

ReadLine();