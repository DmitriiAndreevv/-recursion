// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

// M = 28; N = 7 -> 7

Console.Clear();

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int Recurs(int m, int n)
{
    if(n == 0) return m;
    else return Recurs(n,m % n);
}
Console.WriteLine($"Наибольший общий делитель этих чисел: {Recurs(m,n)} ");
