/* Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

int Prompt(string message)  //Ввод числа с приглашением
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int SumNum(int num) // Функция вычисления суммы цифр введенного числа
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int number = Prompt("Введите число ->");

System.Console.WriteLine($"Сумма цифр числа {number} равна " + SumNum(number));

