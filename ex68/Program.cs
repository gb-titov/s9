//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.WriteLine("Программа для вычисления функции Аккермана");

int m = GetIntFromUserInput("Введите число M: ");
int n = GetIntFromUserInput("Введите число N: ");

int sum = AkkermanFunc(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {sum}");


int AkkermanFunc(int m, int n)
{
    if (m == 0)
        return n + 1;

    if (n == 0)
        return AkkermanFunc(m - 1, 1);

    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
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