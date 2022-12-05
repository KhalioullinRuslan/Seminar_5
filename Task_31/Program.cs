// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

int[] array = new int [12];
Random rand = new Random();

int sumPositive = 0;
int sumNegative = 0;

for (int i=0; i<array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}

System.Console.WriteLine('[' + string.Join(", ", array) + ']');

for (int i=0; i<array.Length; i++)
{
    if(array[i]>0)
    {
        sumPositive+=array[i];
    }

    else
    {
    sumNegative+=array[i];
    }
}

Console.WriteLine($"Сумма положительных элементов = {sumPositive}, отрицательных = {sumNegative}");