// Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
// N = 4532 -> 4
int CountDigitsInNumber(int num)
{
    if (num / 10 != 0) return 1 + CountDigitsInNumber(num / 10);
    else return 1;
}

Console.WriteLine("Enter the number:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number of digits in number: " + CountDigitsInNumber(num));