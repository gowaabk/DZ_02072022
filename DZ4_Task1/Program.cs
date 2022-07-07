/* Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int Prompt(string message)  //Ввод числа с приглашением
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int numberA = Prompt("Введите число A ->");
int numberB = Prompt("Введите число B ->");
int numB = numberB; //переменнная только для вывода ввеленного числа В
int Mult = 1;
while (numberB > 0)
{
    Mult = Mult * numberA;
    numberB--;
}
//System.Console.WriteLine($"Число {numberA} в степени {numberB} = {Math.Pow(numberA, numberB)}");
System.Console.WriteLine($"Число {numberA} в степени {numB} = {Mult}");