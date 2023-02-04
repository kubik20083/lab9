// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное число M:");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numN = Convert.ToInt32(Console.ReadLine());

// Функция нахождения суммы натуральных чисел в промежутке от M до N
void SumNumber(int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма натуральных чисел в промежутке от M до N: {sum}"); 
        return;
    }
    else
    {
    sum = sum + (numM++);
 SumNumber(numM, numN, sum);
    }
}
 SumNumber(numM, numN, 0);