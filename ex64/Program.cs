//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Программа для вывода натуральных чисел в промежутке от N до 1.");

int n = GetIntFromUserInput("Введите число N: ");

Console.Write($"N = {n} -> ");
GetNaturalDigits(n);


void GetNaturalDigits(int n)
{
    if (n < 1)
        return;
    Console.Write(n + " ");
    GetNaturalDigits(--n);
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