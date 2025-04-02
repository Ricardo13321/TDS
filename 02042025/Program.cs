using static System.Console;

int Number_A, Number_B;

WriteLine("Digite um valor A de 0 a 10");
Number_A = Convert.ToInt32(ReadLine());
WriteLine("Digite mais um valor B de 0 a 10");
Number_B = Convert.ToInt32(ReadLine());
WriteLine($"Valor de A: {Number_A}, Valor de B: {Number_B}");
ReadKey();