using System.ComponentModel;
using static System.Console;

Console.ForegroundColor = ConsoleColor.Green;

int Option = 10;
while(Option != 0)
{
    WriteLine("Escolha qual programa você quer executar:\n[1] Para o calculo do desconto para um produto\n[2] Para inverter o valor de duas variáveis\n[0] Sair");
    try{Option = Convert.ToInt32(ReadLine());} catch (Exception ex) {}
    
    if (Option == 1)
    {
        ProdutoComDesconto();
    }
    else if (Option == 2)
    {
        InverterNumeros();
    }
    Clear();
}
ReadKey();

static void ProdutoComDesconto()
{
    Clear();
    double Price = 0, Desc = 0.1, Price_With_Desc, Price_Desc;
    String Name;
    
    WriteLine("Digite o NOME do produto que você deseja comprar:");
    Name = ReadLine();
    Clear();

    bool _loc_ = true;
    while(_loc_)
    {
        WriteLine("Digite o PREÇO do produto que você deseja comprar:");
        try { 
            Price = Convert.ToDouble(ReadLine());
            _loc_ = false;
        } catch (Exception ex) { 
            Clear(); 
        }
    } 
    Clear();

    Price_Desc = Price * Desc;
    Price_With_Desc = Price - Price_Desc;

    WriteLine($"Produto: {Name}\nValor Total: R${Price.ToString("F")}\nValor Cobrado: R${Price_With_Desc.ToString("F")} ({Desc}%) -- Valor Abatido: R${Price_Desc.ToString("F")}");
    ReadKey();
}

static void InverterNumeros()
{
    Clear();
    int Number_A = 0, Number_B = 0;
    WriteLine("Digite dois valores");
    bool _loc1_ = true;
    while(_loc1_)
    {
        try { 
            Number_A = Convert.ToInt32(ReadLine());
            _loc1_ = false;
        } catch (Exception ex) {
            Clear();
        }
    }
    bool _loc2_ = true;
    while (_loc2_)
    {
        try
        {
            Number_B = Convert.ToInt32(ReadLine());
            _loc2_ = false;
        }
        catch (Exception ex)
        {
            Clear();
        }
    }
    WriteLine($"Valor A: {Number_A}, Valor B: {Number_B}");
    Number_A += Number_B;
    Number_B = Number_A - Number_B;
    Number_A += -Number_B;
    WriteLine($"Valor A: {Number_A}, Valor B: {Number_B}");
    ReadKey();
}