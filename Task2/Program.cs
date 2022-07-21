// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int ShowNums(int m, int n)
{
    if (n > m) return n + ShowNums(m, n - 1);
    return n;
}

Console.WriteLine("Enter the number of the beginning of the interval:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a number for the end of the interval:");
int n = Convert.ToInt32(Console.ReadLine());

if (m != n) Console.WriteLine("The sum of the numbers in the interval including the beginning and the end is equal to: " + ShowNums(m, n));
else
    Console.WriteLine($"I can't calculate the sum of digits from {m} to {n} because the numbers are equal!");



