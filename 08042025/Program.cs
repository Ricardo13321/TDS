using static System.Console;

ConsoleColor[] Cores = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
int Number_1 = Convert.ToInt32(ReadLine());
Random randnum = new Random();
Clear();
for (int i = 0; i < Number_1; i++)
{
    for (int x = 1; x < Cores.Length; x++)
    {
        ForegroundColor = Cores[x];
        //BackgroundColor = Cores[x];
        //WriteLine(randnum.Next(100000000, 900000000));
        WriteLine("☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻☻");
        Thread.Sleep(1000);
    }
}
BackgroundColor = ConsoleColor.Black;
ReadLine();