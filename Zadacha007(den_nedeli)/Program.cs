// : Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//1. вводим цифру
Console.WriteLine("Введите цифру от 1-7: ");
string day_number = Console.ReadLine();
switch (day_number)
{
    case "1" :
        {
            Console.WriteLine("(Понедельник) не выходной");
            break;
        }
    case "2" :
        {
            Console.WriteLine("(Вторник)) не выходной");
            break;
        }
    case "3" :
        {
            Console.WriteLine("(Среда) не выходной");
            break;
        }
    case "4" :
        {
            Console.WriteLine("(Четверг) не выходной");
            break;
        }
    case "5" :
        {
            Console.WriteLine("(Пятница) не выходной");
            break;
        }
    case "6" :
        {
            Console.WriteLine("(Суббота) УРА выходной");
            break;
        }
    case "7" :
        {
            Console.WriteLine("(Воскресенье) УРА выходной");
            break;
        }
}