// Задача 44: Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы
//Задаю рандомно числа, которые по условию заданы
//Делаю вычисления х, далее проверяю по у и выдаю в консоль точку пересечения
Random rand = new Random();
float k1 = rand.Next(0,20);
float b1 = rand.Next(0,20);
float k2 = rand.Next(0,20);
float b2 = rand.Next(0,20);
float y1;
float y2;
float x;
x = (b2 - b1) / (k1 - k2);
y1 = (k1 * x) + b1;
y2 = (k2 * x) + b2;
Console.WriteLine($"Заданные переменные k1 = {k1} b1 = {b1} k2 = {k2} b2 = {b2}");
Console.WriteLine($"х = {x} у1 = {y1} у2 = {y2}");
if (k1 != k2)
    Console.WriteLine($"Точка пересечения прямых ({x};{y1})");
else
    Console.WriteLine("Прямые не пересекаются");