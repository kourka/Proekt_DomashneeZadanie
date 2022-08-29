// Задача 2: Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.
//1. диапазон 
int start = 1;
int stop = 65536;

// 2. генерируем числа
//int value = new Random().Next(start,stop);
int value = 7234568;
Console.WriteLine(value);

// 3. извлечение 3й цифры   считает справа на лево
//int digit_numb1 = value % 10;
//int digit_numb2 = (value % 100) / 10;

int digit_numb3 = (value % 1000) / 100;

// 4. Выводим результат


if (value <= 99)
{
    Console.WriteLine("Третьего числа нет");    
}
else 
{
     Console.WriteLine("Третье число " +digit_numb3);
}