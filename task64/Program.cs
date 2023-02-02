/* Задача 64: Задайте значение N.
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии. */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
void NumberToLow(int number)
{
    if (number == 0)
        return;
    else
    {
        Console.Write(number + "  ");
        NumberToLow(number - 1);
    }
}

NumberToLow(number);
System.Console.WriteLine();