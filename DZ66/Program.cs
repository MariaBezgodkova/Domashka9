// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число:");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int N = int.Parse(Console.ReadLine());
void Summ(int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (M++);
    Summ(M, N, sum);
}

Summ(M, N, 0);
