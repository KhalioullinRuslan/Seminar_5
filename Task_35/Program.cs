// Задача №35 Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


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

int FindCol(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] >= 10) && (arr[i] <= 99))
        {
            count++;
        }
    }
    return count;
}

// ----------------------------------------------------


int size = 123;
int lRange = -100;
int rRange = 100;


int[] array = new int[size];

array = FillArrayWithRandomNumbers(size, lRange, rRange);
// Console.WriteLine("[" + string.Join(",", array) + "]");
Console.WriteLine($"Количество цифр заданого периода в массиве: {FindCol(array)}");
