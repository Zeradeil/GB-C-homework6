// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

float b1 = Readnum("b1");
float k1 = Readnum("k1");
float b2 = Readnum("b2");
float k2 = Readnum("k2");

float x = (b1 - b2) / (k2 - k1);
float y = k2 * x + b2;
System.Console.WriteLine($"x = {x}, y = {y}");

int Readnum(string massage)
{
    System.Console.Write($"Введите {massage} => ");
    return Convert.ToInt32(System.Console.ReadLine());
}

