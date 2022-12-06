﻿// // Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21


int[] FillArrayWithRandomNumbers(int size, int leftrange, int rightrange)
{
    Console.Clear();
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftrange, rightrange + 1);
    }

    return arr;
}


int[] FillNewArray(int[] arr)
{
    int[] arrayNew = new int[(arr.Length / 2) + arr.Length % 2];
    if (arr.Length % 2 == 0)
    {
        for (int i = 0; i < (arr.Length / 2); i++)
        {
            arrayNew[i] = arr[i] * arr[(arr.Length - 1) - i];
        }
    }
    else
    {
        for (int i = 0; i < (arr.Length / 2); i++)
        {
            int count = (arr.Length - 1) - i;
            arrayNew[i] = arr[i] * arr[count];
        }
        arrayNew[arrayNew.Length - 1] = arr[arr.Length / 2];

    }


    return arrayNew;
}

// // -----------------------------------------------------

int size = 5;
int lRange = 0;
int rRange = 10;

int[] array = new int[size];
int[] arrayNew = new int[0];
array = FillArrayWithRandomNumbers(size, lRange, rRange);

arrayNew = FillNewArray(array);
Console.WriteLine("Заданый массив: [" + string.Join(",", array) + "]");
Console.WriteLine("Новый массив: [" + string.Join(",", arrayNew) + "]");