// принимает число (N), а на выходе показывает все чётные числа от 1 до N


int N;

string input_N;

Console.WriteLine("Введите число");
input_N = Console.ReadLine();
N = Int32.Parse(input_N);

int count = 1;
    
while (count < N ) // включительно("N-1" , будет выдовать до числа N)
{
     if (count % 2 > 0)
     {
         count++;
     }
     {
     Console.WriteLine(count + " ");
     count++;
     }
}
