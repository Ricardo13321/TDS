using System;
using static System.Console;

/* Essa forma de implementar está criando uma lista
string[] nomes = {"Beto", "Renato", "Juan", "Jubileu"};

foreach(string pessoa in nomes)
{
    WriteLine("{0}, {1}", pessoa);
}


//Essa forma está criando um array
int[] array = new int[] {1,2,3,4,5,6};

foreach(int item in array)
{
    WriteLine(item);
}

ReadLine();
*/

int Number_1 = 0;
int[] Tabuada = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

WriteLine("Vamos criar uma tabuada digite um valor:");

bool _loc_ = true;
while(_loc_)
{
    try
    {
        ForegroundColor = ConsoleColor.Green;
        Number_1 = Convert.ToInt32(ReadLine());
        ForegroundColor = ConsoleColor.White;
        _loc_ = false;
    }
    catch (Exception ex)
    {
        Clear();
        WriteLine("Vamos criar uma tabuada digite um valor:");
        ForegroundColor = ConsoleColor.Red;
        WriteLine("Digite um valor inteiro!");
        ForegroundColor = ConsoleColor.White;
        
    }
}




foreach (var item in Tabuada)
{
    WriteLine($"{Number_1} x {item} = {Number_1*item}");
}
WriteLine("Aperte enter para ir para o próximo exercício.");
ReadLine();
Clear();

string[] Estados = { "DF - Distrito Federal","GO - Goiás", "MT - Mato Grosso", "MS - Mato Grosso do Sul", "AL Alagoas", "BA Bahia", "CE Ceará","MA Maranhão","PB Paraíba","PE Pernambuco","PI Piauí","RN Rio Grande do Norte","SE Sergipe","AC Acre","AP Amapá","AM Amazonas","PA Pará","RO Rondônia","RR Roraima","TO Tocantis","Região Sudeste","ES Espírito Santo","MG Minas Gerais","RJ Rio de Janeiro","SP São Paulo","Região Sul","PR Paraná","RS Rio Grande do Sul","SC Santa Catarina"};

foreach (var item in Estados)
{
    WriteLine(item);
}

ReadLine();