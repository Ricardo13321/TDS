using static System.Console;

int Number_A=0, Number_B=0;
WriteLine("Digite dois valores");
Number_A = Convert.ToInt32(ReadLine());
Number_B = Convert.ToInt32(ReadLine());
WriteLine($"Valor A: {Number_A}, Valor B: {Number_B}");
Number_A += Number_B;
Number_B = Number_A - Number_B;
Number_A += -Number_B;
WriteLine($"Valor A: {Number_A}, Valor B: {Number_B}");
ReadKey();