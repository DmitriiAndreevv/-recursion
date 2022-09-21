// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


Console.Clear();

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m > n) Console.WriteLine("значение m не должно быть больше значения n!");
    else
    {
        int Recursia(int m, int n)
        {
            if(m == n) return n;
            else if(m % 2 == 1 & m + 1 == n) return n;
            else if( n % 2 == 0) Console.WriteLine(n); 
            return Recursia(m,n -1);
        }
        Console.WriteLine();
        Console.WriteLine(Recursia(m,n));
    }





