using System.ComponentModel.Design;
using static System.Console;

int a = Convert.ToInt32(ReadLine());

if (a>4)
{
    WriteLine($"O número {a} é maior que 4!");
} else  if (a>3)
{
    WriteLine($"O número {a} é maior que 3!");
} else if (a>0)
{
    WriteLine($"O número {a} é maior que 0!");
} else
{
    WriteLine($"O {a} é menor que 0!");
}
ReadLine();