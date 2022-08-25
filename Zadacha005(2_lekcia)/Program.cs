// принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа.
//1 диапазон 
int start = 100;
int stop = 1000;

// 2 генерируем числа
int value = new Random().Next(start,stop);
Console.WriteLine(value);

// 3 извлечение 2й цифры
int digit_first = value / 10;
int digit_second = digit_first % 10;

// Выводим результат
Console.WriteLine("второе число " +digit_second);