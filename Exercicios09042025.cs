___________________________________________________________________________________________________________
Aluno: Ricardo Gabriel Gomes
___________________________________________________________________________________________________________
1- Faça um programa que peça dois números e verifique (usando if e else) e imprima o maior deles.
using static System.Console;

int Number_1, Number_2;

Number_1 = Convert.ToInt32(ReadLine());
Number_2 = Convert.ToInt32(ReadLine());

if (Number_1 > Number_2)
{
    WriteLine($"Entre {Number_1} e {Number_2} o maior valor é {Number_1}");
} else
{
    WriteLine($"Entre {Number_1} e {Number_2} o maior valor é {Number_2}");
}
___________________________________________________________________________________________________________
2- Faça um programa que leia três números, verifique (usando if e else) e mostre o maior e o menor deles

using static System.Console;

int Number_1, Number_2, Number_3;

WriteLine("Digite o primeiro valor");
Number_1 = Convert.ToInt32(ReadLine());

WriteLine("Digite o segundo valor");
Number_2 = Convert.ToInt32(ReadLine());

WriteLine("Digite o terceiro valor");
Number_3 = Convert.ToInt32(ReadLine());

if (Number_1 < Number_2 && Number_1 < Number_3)
{
    Write($"Entre {Number_1}, {Number_2} e {Number_3} o menor valor é {Number_1} e o de maior valor é " + (Number_2 > Number_3 ? Number_2 : Number_3));
}
else if (Number_2 < Number_1 && Number_2 < Number_3)
{
    WriteLine($"Entre {Number_1}, {Number_2} e {Number_3} o menor valor é {Number_2} e o de maior valor é " + (Number_1 > Number_3 ? Number_1 : Number_3));
}
else if (Number_3 < Number_1 && Number_3 < Number_2)
{
    WriteLine($"Entre {Number_1}, {Number_2} e {Number_3} o menor valor é {Number_3} e o de maior valor é " + (Number_1 > Number_2 ? Number_1 : Number_2));
}
___________________________________________________________________________________________________________
3- Faça um programa para a leitura de duas notas parciais de um aluno.
✓ A mensagem “Aprovado”, se a média alcançada for maior ou igual a sete;
✓ A mensagem “Aprovado com Distinção”, se a média for igual a dez;
✓ A mensagem “Reprovado” se a média for menor de do que sete.

using static System.Console;

double Nota_1, Nota_2, Media;

Nota_1 = Convert.ToDouble(ReadLine());
Nota_2 = Convert.ToDouble(ReadLine());

Media = (Nota_1 + Nota_2) / 2;

if(Media >= 7)
{
    WriteLine("Aprovado!");
} else if( Media == 10)
{
    WriteLine("Aprovado com Distinção!");
} else
{
    WriteLine("Reprovado!");
}
___________________________________________________________________________________________________________
4- Faça um programa que pergunte o preço de três produtos e informe qual produto você deve comprar, sabendo que a decisão é sempre o mais barato.

using static System.Console;

double Produto_1, Produto_2, Produto_3;

WriteLine("Informe o preço do primeiro produto:");
Produto_1 = Convert.ToDouble(ReadLine());

WriteLine("Informe o preço do segundo produto:");
Produto_2 = Convert.ToDouble(ReadLine());

WriteLine("Informe o preço do terceiro produto:");
Produto_3 = Convert.ToDouble(ReadLine());

if(Produto_1 < Produto_2 && Produto_1 < Produto_3)
{
    WriteLine($"Entre os produtos R${Produto_1:F2}, R${Produto_2:F2} e R${Produto_3:F2}, o que você deveria comprar é o produto com o valor R${Produto_1:F2}");
} else if(Produto_2 < Produto_1 && Produto_2 < Produto_3)
{
    WriteLine($"Entre os produtos R${Produto_1:F2}, R${Produto_2:F2} e R${Produto_3:F2}, o que você deveria comprar é o produto com o valor R${Produto_2:F2}");
} else if(Produto_3 < Produto_1 && Produto_3 < Produto_2)
{
    WriteLine($"Entre os produtos R${Produto_1:F2}, R${Produto_2:F2} e R${Produto_3:F2}, o que você deveria comprar é o produto com o valor R${Produto_3:F2}");
} else if(Produto_1 == Produto_2 || Produto_1 == Produto_3)
{
    WriteLine($"Entre os produtos R${Produto_1:F2}, R${Produto_2:F2} e R${Produto_3:F2}, o que você deveria comprar são os produtos com o valor R${Produto_1:F2}");
} else if(Produto_2 == Produto_3)
{
    WriteLine($"Entre os produtos R${Produto_1:F2}, R${Produto_2:F2} e R${Produto_3:F2}, o que você deveria comprar são os produtos com o valor R${Produto_2:F2}");
}
ReadLine();
___________________________________________________________________________________________________________
5- Escreva um programa em C que recebe um inteiro e diga se é par ou ímpar. Use o operador matemático % (resto da divisão ou módulo) e o teste condicional if.

using static System.Console;

int Number = Convert.ToInt32(ReadLine());

WriteLine($"O valor {Number} é " +(Number%2==0?"par":"ímpar"));
ReadLine();
___________________________________________________________________________________________________________
6- Para doar sangue é necessário ter entre 18 e 67 anos. Faça um aplicativo que pergunte a idade de uma pessoa e diga se ela pode doar sangue ou não. Use alguns dos operadores lógicos OU (||) e E (&&).

using static System.Console;

WriteLine("Informe a sua idade");
int Idade = Convert.ToInt32(ReadLine());

if(Idade >= 18 && Idade <= 67)
{
    WriteLine("Você pode doar sangue");
} else
{
    WriteLine("Você não pode doar sangue");
}

ReadLine();
___________________________________________________________________________________________________________
7- Escreva um algoritmo que armazene o valor 10 em uma variável A e o valor 20 em uma variável B. A seguir (utilizando apenas atribuições entre variáveis) troque os seus conteúdos fazendo com que o valor que está em A passe para B e vice-versa. Ao final, escrever os valores que ficaram armazenados nas variáveis.

using static System.Console;

int A = 10, B = 20;

A += B;
B = A - B;
A += -B;

WriteLine($"O valor de A é {A} e o de B é {B}");

ReadLine();
___________________________________________________________________________________________________________
8- Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês, mais uma comissão também fixa para cada carro vendido e mais 5% do valor das vendas por ele efetuadas. Escrever um algoritmo que leia o número de carros por ele vendidos, o valor total de suas vendas, o salário fixo e o valor que ele recebe por carro vendido. Calcule e escreva o salário final do vendedor.

using static System.Console;

double Carros_Vendidos, Valor_Total_de_Venda, Salario_Fixo, Valor_Por_Venda, Salario_Final;

WriteLine("Qual o número de carros vendidos por ele?");
Carros_Vendidos = Convert.ToDouble(ReadLine());

WriteLine("Qual o valor total de suas vendas?");
Valor_Total_de_Venda = Convert.ToDouble(ReadLine());

WriteLine("Qual o salário fixo?");
Salario_Fixo = Convert.ToDouble(ReadLine());

WriteLine("Qual o valor que ele recebe por venda?");
Valor_Por_Venda = Convert.ToDouble(ReadLine());

Salario_Final = (Carros_Vendidos * Valor_Por_Venda) + (Valor_Total_de_Venda * 0.05) + Salario_Fixo;

WriteLine($"O salário final dele será R${Salario_Final:F2}");

ReadLine();
___________________________________________________________________________________________________________
9- Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, calcular e escrever o valor correspondente em graus Celsius

using static System.Console;

int Temperatura, Resultado;

WriteLine("Escreva a temperatura atual em Fahrenheit");
Temperatura = Convert.ToInt32(ReadLine());

Resultado = (Temperatura - 32) * 5 / 9;

WriteLine($"{Temperatura}°F é equivalente à {Resultado}°C");

ReadLine();
___________________________________________________________________________________________________________
10- Faça um algoritmo que transforme uma velocidade fornecida em m/s pelo usuário para Km/h. Para tal, multiplique o valor em m/s por 3,6.
using static System.Console;

double Velocidade, Km_h;

WriteLine("Escreva a velocidade em m/s para converter para km/h");
Velocidade = Convert.ToDouble(ReadLine());
Km_h = Velocidade * 3.6;
WriteLine($"{Velocidade:F1}m/s é igual a {Km_h:F1}Km/h");

ReadLine();
