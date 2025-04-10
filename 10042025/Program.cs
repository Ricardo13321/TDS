using static System.Console;

string[] Nomes = {"Maria", "Judas", "Nilson", "Marcos", "Carlos"};

Array.Sort(Nomes);

foreach (var car in Nomes)
{
    WriteLine(car);
}

ReadLine();