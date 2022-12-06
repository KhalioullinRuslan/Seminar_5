// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
int leftRange = 0;
int rightRange = 999;

int[] array = FillArray(size, leftRange, rightRange);

System.Console.WriteLine('[' + string.Join(",", array) + ']');

System.Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
bool result = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        result = true;
        break;
    }
}
   if (result) System.Console.WriteLine("Да");
   
   
   else 
{
    System.Console.WriteLine("Нет");
}