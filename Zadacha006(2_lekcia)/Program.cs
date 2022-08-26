// Задача 2: Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.
//1 диапазон 
int start = 1;
int stop = 65536;

// 2 генерируем числа
//int value = new Random().Next(start,stop);
int value = 123;
Console.WriteLine(value);

// 3 извлечение 2й цифры
int digit_numb1 = value / 100;
int digit_numb2 = digit_numb1 % 10;
int digit_numb3 = digit_numb2 % 1000;

// Выводим результат
Console.WriteLine("Третье число " +digit_numb3);

if (value < 99)
{
    Console.WriteLine("Третьего числа нет");
}