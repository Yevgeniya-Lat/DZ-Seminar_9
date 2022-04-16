/* 
Задача 1: 
Задайте значения M и N. Напишите программу, 
которая выведет все чётные натуральные числа в промежутке от M до N.

M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"

*/

int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    int Value = Convert.ToInt32(Console.ReadLine());
    return Value;
}

void EvenNumbers(int M, int N) 
{
    if (M > N) return;
    if (M % 2 == 0) Console.Write(M + ", ");
    EvenNumbers(M + 1, N);
}

int M = Prompt("Введите M:  ");
int N = Prompt("Введите N:  ");
System.Console.WriteLine();
System.Console.Write($"Чётные натуральные числа в промежутке от {M} до {N} => ");
EvenNumbers(M, N);