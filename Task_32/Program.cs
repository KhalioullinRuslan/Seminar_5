// Задача 32: Напишите программу замена элементов массива: положительные элементы
//  замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] FillArray(int number, int leftRange, int rightRange)
{
    int[] collection = new int[number];
    int length = collection.Length;
    int index =0;
    while (index < length)
    {
        collection[index] = new Random().Next(leftRange, rightRange + 1);
        index++;
    }
    return collection;
}

int size = 10;
int leftRange = -9;
int rightRange = 9;

int[] array = FillArray(size, leftRange, rightRange);

System.Console.WriteLine('[' + string.Join(",", array) + ']');

for (int i=0; i < array.Length; i++)
{
    array[i] = -array[i];
}
System.Console.WriteLine('[' + string.Join(",", array) + ']');