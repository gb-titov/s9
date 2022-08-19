//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.WriteLine("Программа для нахождения суммы натуральных чисел в промежутке от M до N.");

int m = GetIntFromUserInput("Введите число M: ");
int n = GetIntFromUserInput("Введите число N: ");

int sum = SumNaturalDigits(m, n);
Console.Write($"M = {m}, N = {n} -> {sum}");



int SumNaturalDigits(int m, int n)
{
    if (m > n) return 0;
    return m + SumNaturalDigits(++m, n);
}


int GetIntFromUserInput(string msg)
{
    Console.Write(msg);
    string? n = Console.ReadLine();
    if (string.IsNullOrEmpty(n) & int.TryParse(n, out int num))
    {
        Console.WriteLine("Неверный ввод!");
        GetIntFromUserInput(msg);
    }
    return num;

}