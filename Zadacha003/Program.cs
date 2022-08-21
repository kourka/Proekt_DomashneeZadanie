// принимает число и выдаёт, является ли число чётным?
int a;
string input_a;

Console.WriteLine("Введите число");
input_a = Console.ReadLine();

a = Int32.Parse(input_a);

if (a % 2 > 0)
{
    Console.WriteLine("не четное: " +a);
}
else 
{
    Console.WriteLine("четное: " +a);
}

