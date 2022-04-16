/* 
Задача 2: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30

*/

int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    int Value = Convert.ToInt32(Console.ReadLine());
    return Value;
}

int SumNumbers(int M, int N)
{
    if (M == N) return M;
    return M + SumNumbers(M + 1, N);
}

int M = Prompt("Введите M:  ");
int N = Prompt("Введите N:  ");
System.Console.WriteLine();
System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} => {SumNumbers(M, N)}");

