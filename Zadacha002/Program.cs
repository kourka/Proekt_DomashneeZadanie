// принимает на вход три числа и выдаёт максимальное из этих чисел
double num1, num2, num3;
string input1, input2, input3;

Console.WriteLine("Введите 3 числа:");
input1 = Console.ReadLine();
input2 = Console.ReadLine();
input3 = Console.ReadLine();

num1 = double.Parse(input1);
num2 = double.Parse(input2);
num3 = double.Parse(input3);

double max;
max = num1;

if (max < num2)
{
    max = num2;
}
if (max < num3) // когда пишу else выдает ошибку просит поставить ;
{
    max = num3;
}

Console.WriteLine("max число = " +max);


