-----------------------------------------------------------------------------
Exercício 1:

using static System.Console;

WriteLine("Escreva um valor inteiro para descobrir se ele é ímpar ou par");
int Number = Convert.ToInt32(ReadLine());

if(Number%2 == 0)
{
    WriteLine($"O número {Number} é par");
} else
{
    WriteLine($"O número {Number} é ímpar");
}

-----------------------------------------------------------------------------
Exercício 2:

using static System.Console;

WriteLine("Descobri a classificação da sua idadei");
int Idade = Convert.ToInt32(ReadLine());

if(Idade >= 0 && Idade <=12)
{
    WriteLine($"A idade {Idade} é de um(a) criança");
} else if (Idade <= 17)
{
    WriteLine($"A idade {Idade} é de um(a) adolescente");
} else if (Idade < 60)
{
    WriteLine($"A idade {Idade} é de um(a) adulto");
} else
{
    WriteLine($"A idade {Idade} é de um(a) idoso");
}

-----------------------------------------------------------------------------
Exercício 3:

using static System.Console;


double Number_1, Number_2; 
String Op;

WriteLine("Digite um valor");
Number_1 = Convert.ToDouble(ReadLine());
WriteLine("Digite outro valor");
Number_2 = Convert.ToDouble(ReadLine());
WriteLine("Digite a operação que deseja fazer, use: \n[-] para subtrair, \n[+] para somar, \n[/] para dividir e \n[*] para multiplicar");
Op = ReadLine();


if(Op == "-")
{
    WriteLine($"{Number_1} - {Number_2} = {Number_1-Number_2}");
} else if(Op == "+")
{
    WriteLine($"{Number_1} + {Number_2} = {Number_1+Number_2}");
} else if(Op == "*")
{
    WriteLine($"{Number_1} * {Number_2} = {Number_1*Number_2}");
} else if(Op == "/")
{
    if(Number_1 == 0 || Number_2 == 0)
    {
        WriteLine("É impossível realizar uma divisão por zero");
    } else
    {
        WriteLine($"{Number_1} / {Number_2} = {Number_1 / Number_2}");
    }
} else {
	WriteLine("Erro!");
}

-----------------------------------------------------------------------------
Exercício 4:

using static System.Console;

WriteLine("Descubra qual é o dia da semana digitando um valor de 1 a 7");
int Value = Convert.ToInt32(ReadLine());

switch (Value)
{
    case 1:
        WriteLine("O dia da semana é Domingo! :D");
        break;
    case 2:
        WriteLine("O dia da semana é Segunda-Feira! ;-;");
        break;
    case 3:
        WriteLine("O dia da semana é Terça-Feira! ;-;");
        break;
    case 4:
        WriteLine("O dia da semana é Quarta-Feira! -_-");
        break;
    case 5:
        WriteLine("O dia da semana é Quinta-Feira! -_-");
        break;
    case 6:
        WriteLine("O dia da semana é Sexta-Feira! :)");
        break;
    case 7:
        WriteLine("O dia da semana é Sábado! :D");
        break;
    default:
        WriteLine("O nosso programa mágico que descobre qual é o dia da semana só aceita valores de 1 à 7!");
        break;
}

-----------------------------------------------------------------------------
Exercício 5:

using static System.Console;

WriteLine("Digite uma letra para descobrir se é vogal ou consoante");
String Letra = ReadLine();

switch (Letra.ToUpper())
{
    case "A":
    case "E":
    case "I":
    case "O":
    case "U":
        WriteLine($"{Letra} é uma vogal");
        break;
    case "B":
    case "C":
    case "D":
    case "F":
    case "G":
    case "H":
    case "J":
    case "K":
    case "L":
    case "M":
    case "N":
    case "P":
    case "Q":
    case "R":
    case "S":
    case "T":
    case "V":
    case "W":
    case "X":
    case "Y":
    case "Z":
        WriteLine($"{Letra} é uma consoante");
        break;
    default:
        WriteLine("Por favor digite um valor válido!");
        break;
}

-----------------------------------------------------------------------------
Exercício 6:

using static System.Console;
double Nota_1, Nota_2, Nota_3, Media;
WriteLine("Digite a primeira nota do aluno de 0 a 10");
Nota_1 = Convert.ToDouble(ReadLine());
WriteLine("Digite a segunda nota do aluno de 0 a 10");
Nota_2 = Convert.ToDouble(ReadLine());
WriteLine("Digite a terceira nota do aluno de 0 a 10");
Nota_3 = Convert.ToDouble(ReadLine());
Media = (Nota_1+Nota_2+Nota_3)/3;
WriteLine( Media >= 7 ? $"Sua média é {Media:F2}, portanto você está aprovado! :)" : $"Sua média é {Media:F2}, portanto você está reprovado! :)");

-----------------------------------------------------------------------------
Exercício 7:

using static System.Console;
double VT;

WriteLine("Digite o valor do Produto:");
VT = Convert.ToDouble(ReadLine());

if (VT < 50)
{
    WriteLine($"Esse produto tem o preço abaixo de R$50,00 portanto não tem desconto:\nValor Total: {VT}");
}
else if (VT <= 100)
{
    WriteLine($"Esse produto tem um desconto de 5%\nValor Total: {VT.ToString("F")}\nValor descontado: {(VT * 0.05).ToString("F")}\nValor com desconto: {(VT - (VT * 0.05)).ToString("F")}");
}
else
{
    WriteLine($"Esse produto tem um desconto de 10%\nValor Total: {VT.ToString("F")}\nValor descontado: {(VT * 0.1).ToString("F")}\nValor com desconto: {(VT-(VT * 0.1)).ToString("F")}");
}

-----------------------------------------------------------------------------
Exercício 8:

using static System.Console;
int Ano;

WriteLine("Descubra se o ano é bissexto");
Ano = Convert.ToInt32(ReadLine());

if ((Ano % 4 == 0 && Ano % 100 != 0) || Ano % 400 == 0) 
{
    WriteLine($"{Ano} é bissexto!");}
else
{
    WriteLine($"{Ano} não é bissexto!");
}

ReadLine();

-----------------------------------------------------------------------------
Exercício 9:

using static System.Console;

double Number_1, Number_2;
String Op;


Console.ForegroundColor = ConsoleColor.Red;
//Console.BackgroundColor = ConsoleColor.DarkBlue;
WriteLine("Digite um valor");
Console.ForegroundColor = ConsoleColor.White;
//Console.BackgroundColor = ConsoleColor.Black;
Number_1 = Convert.ToDouble(ReadLine());
WriteLine("Digite outro valor");
Number_2 = Convert.ToDouble(ReadLine());
WriteLine("Digite a operação que deseja fazer, use: \n[-] para subtrair, \n[+] para somar, \n[/] para dividir e \n[*] para multiplicar");
Op = ReadLine();

switch (Op)
{
    case "-":
        WriteLine($"{Number_1} - {Number_2} = {Number_1 - Number_2}");
        break;
    case "+":
        WriteLine($"{Number_1} + {Number_2} = {Number_1 + Number_2}");
        break;
    case "*":
        WriteLine($"{Number_1} * {Number_2} = {Number_1 * Number_2}");
        break;
    case "/":
        if (Number_1 == 0 || Number_2 == 0)
        {
            WriteLine("É impossível realizar uma divisão por zero");
        }
        else
        {
            WriteLine($"{Number_1} / {Number_2} = {Number_1 / Number_2}");
        }
        break;
    default:
        WriteLine("Você não forneceu um operador válido");
        break;
}

-----------------------------------------------------------------------------
Exercício 10:

using static System.Console;

string nivel;

WriteLine("Escreva o nível de alerta:\n[1] Para nível baixo\n[2] Para nível moderado\n[3] Para nível elevado\n[4] Nível de alerta crítico\n[5]EMERGÊNCIA!\n[*] Qualquer outra coisa para sair");

nivel = ReadLine();

switch (nivel)
{
    case "1":
        Console.ForegroundColor = ConsoleColor.Green;
        WriteLine("Nível de alerta baixo!");
        break;
    case "2":
        Console.ForegroundColor = ConsoleColor.Blue;
        WriteLine("Nível de alerta moderado!");
        break;
    case "3":
        Console.ForegroundColor = ConsoleColor.Yellow;
        WriteLine("Nível de alerta elevado!");
        break;
    case "4":
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine("Nível de alerta crítico!");
        break;
    case "5":
        Console.ForegroundColor = ConsoleColor.Red;
        WriteLine("EMERGÊNCIA!");
        break;
    default:
        Clear();
        break;
}
Console.ForegroundColor = ConsoleColor.White;
ReadLine();

-----------------------------------------------------------------------------
Exercício 11:

using static System.Console;

int Number_1, Number_2, Number_3;

WriteLine("Escreva o primeiro valor:");
Number_1 = Convert.ToInt32(ReadLine());
Clear();

WriteLine("Escreva o segundo valor:");
Number_2 = Convert.ToInt32(ReadLine());
Clear();

WriteLine("Escreva o terceiro valor:");
Number_3 = Convert.ToInt32(ReadLine());
Clear();

if(Number_1 > Number_2 && Number_1 > Number_3)
{
    WriteLine($"O maior valor entre {Number_1}, {Number_2}, {Number_3} é {Number_1}.");
} else if (Number_2 > Number_3)
{
    WriteLine($"O maior valor entre {Number_1}, {Number_2}, {Number_3} é {Number_2}.");
} else
{
    WriteLine($"O maior valor entre {Number_1}, {Number_2}, {Number_3} é {Number_3}.");
}

ReadLine();

-----------------------------------------------------------------------------
Exercício 12:

using static System.Console;

int Number_1, Number_2, Number_3;

WriteLine("Escreva o comprimento do primeiro lado do triângulo:");
Number_1 = Convert.ToInt32(ReadLine());
Clear();

WriteLine("Escreva o comprimento do segundo lado do triângulo:");
Number_2 = Convert.ToInt32(ReadLine());
Clear();

WriteLine("Escreva o comprimento do terceiro lado do triângulo:");
Number_3 = Convert.ToInt32(ReadLine());
Clear();

if(Number_1 > Number_2+Number_3)
{
    WriteLine($"Não é possível existir um triângulo onde seus lados tenham {Number_1}, {Number_2}, {Number_3}, pois  a soma dos lados {Number_2} e {Number_3} é menor que o lado {Number_1}");
} else if(Number_2 > Number_1+Number_3) 
{
    WriteLine($"Não é possível existir um triângulo onde seus lados tenham {Number_1}, {Number_2}, {Number_3}, pois  a soma dos lados {Number_1} e {Number_3} é menor que o lado {Number_2}");
} else if(Number_3 > Number_1+Number_2)
{
    WriteLine($"Não é possível existir um triângulo onde seus lados tenham {Number_1}, {Number_2}, {Number_3}, pois  a soma dos lados {Number_2} e {Number_1} é menor que o lado {Number_3}");
} else
{
    WriteLine($"Esse é um trângulo como os lados medindo {Number_1}, {Number_2}, {Number_3}");
}

ReadLine();

-----------------------------------------------------------------------------
Exercício 13:

using static System.Console;

double Nota;

WriteLine("Informe a nota do aluno para converter em um conceito!");
try
{
    Nota = Convert.ToDouble(ReadLine());

    switch (Nota)
    {
        case < 0:
            WriteLine("A nota do aluno não pode ser menor que 0!");
            break;
        case < 5:
            WriteLine("A nota do aluno é D :(");
            break;
        case < 7:
            WriteLine("A nota do aluno é C :|");
            break;
        case < 9:
            WriteLine("A nota do aluno é B :)");
            break;
        case <= 10:
            WriteLine("A nota do aluno é A :D");
            break;
        default:
            WriteLine("A nota do aluno não pode ser maior que 10!");
            break;
    }
} catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    WriteLine($"ERRO!!!\n{ex}\nO programa encerrou!");
    Console.ForegroundColor = ConsoleColor.White;
}

ReadLine();

-----------------------------------------------------------------------------
Exercício 14:

using static System.Console;

int Number_1, Number_2;

WriteLine("Informe o primeiro valor");
Number_1 = Convert.ToInt32(ReadLine());

WriteLine("Informe o segundo valor");
Number_2 = Convert.ToInt32(ReadLine());

if(Number_1%2 == 0 && Number_2%2 == 0)
{
    WriteLine($"A soma dos valores {Number_1} e {Number_2} é {Number_1 + Number_2}");
} else if(Number_1%2 != 0 && Number_2%2 != 0)
{
    WriteLine($"A multiplicação entre os valores {Number_1} e {Number_2} é {Number_1 * Number_2}");
} else if(Number_1 > Number_2)
{
    Write($"A subtração de {Number_1} por {Number_2} é {Number_1 - Number_2}");
} else
{
    Write($"A subtração de {Number_2} por {Number_1} é {Number_2 - Number_1}");
}

ReadLine();

-----------------------------------------------------------------------------
Exercício 15:

using static System.Console;
int Option, Number_1, Number_2;

WriteLine("Escolha uma das opções:\n[1] Soma\n[2] Subtração\n[3] Sair");
Option = Convert.ToInt32(ReadLine());

switch (Option)
{
	case 1:
		WriteLine("Vamos somar os valores!\nEscreva um valor:");
		Number_1 = Convert.ToInt32(ReadLine());

		WriteLine("Escreva outro valor");
		Number_2 = Convert.ToInt32(ReadLine());

		WriteLine($"A soma entre os valores {Number_1} e {Number_2} é {Number_1+Number_2}");
		break;
	case 2:
        WriteLine("Vamos subtrair os valores!\nEscreva um valor:");
        Number_1 = Convert.ToInt32(ReadLine());

        WriteLine("Escreva outro valor");
        Number_2 = Convert.ToInt32(ReadLine());

        WriteLine($"A subtração entre os valores {Number_1} e {Number_2} é {Number_1 - Number_2}");
        break;
	case 3:
		WriteLine("Adeus! ;-;");
		break;
	default:
		WriteLine("O valor que você digitou é inválido!");
		break;
}

ReadLine();
