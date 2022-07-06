/* Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int RandomNum(int min, int max) // Функция создания рандомных чисел  от min до max
{
    int a = new Random().Next(min, max + 1);
    return a;
}

int[] NewArray(int length, int min, int max)    //Функция создания массива и его заполнения случаными числами.
{
    int[] arr = new int[length];
    int i = 0;
    while (i < length)
    {
        arr[i] = RandomNum(min, max);
        i++;
    }
    return arr;
}

void Print(int[] array) //  Функция вывода массива.
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int[] array1 = NewArray(8, -1000, 1000);
Print(array1);