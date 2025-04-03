using static System.Console;

Console.ForegroundColor = ConsoleColor.Green;
bool _loc_ = true;
while (_loc_)
{
    WriteLine("Escolha qual opção você quer digite:\n[0] para sair\n[1] para SwitchCase\n[2] para If Else");
    int Option = 0;
    try
    {
        Option = Convert.ToInt32(ReadLine());
    } catch (Exception ex)
    {
        Clear();
        WriteLine("Escreva um valor númerico inteiro");
    }
    if(Option == 0)
    {
        _loc_ = false;
    } else if(Option == 1)
    {
        SwitchCase();
    } else if(Option == 2)
    {
        IfElse();
    }

}

static void SwitchCase()
{
    String Mes;
    WriteLine("Digite um mês-->");
    Mes = ReadLine();

    switch (Mes.ToUpper())
    {
        case "JANEIRO":
        case "MARÇO":
        case "MAIO":
        case "JULHO":
        case "AGOSTO":
        case "OUTUBRO":
        case "DEZEMBRO":
            WriteLine("Esse mês possuem 31 dias!");
            break;
        case "FEVEREIRO":
            WriteLine("Esse mês tem 28 ou 29 dias!");
            break;
        case "ABRIL":
        case "JUNHO":
        case "SETEMBRO":
        case "NOVEMBRO":
            WriteLine("Esse mês tem 30 dias!");
            break;
        default:
            WriteLine("Por favor informe um mês!");
            break;
    }
}

static void IfElse()
{
    int a = Convert.ToInt32(ReadLine());

    if (a > 4)
    {
        WriteLine($"O número {a} é maior que Quatro!");
    }
    else if (a > 3)
    {
        WriteLine($"O número {a} é maior que Tres!");
    }
    else if (a > 0)
    {
        WriteLine($"O número {a} é maior que 0!");
    }
    else if (a == 0)
    {
        WriteLine($"O número {a} é igual a Zero");
    }
    else
    {
        WriteLine($"O {a} é menor que Zero!");
    }
}