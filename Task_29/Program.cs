//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]
int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < 8; i++)
{
     array[i] = rand.Next(10, 99);
}
Console.WriteLine($"Выводится массив псевдослучайных чисел из 8 элементов: ");
Console.WriteLine();
Console.Write("[");
for(int i = 0; i < array.Length -1; i++)
    {
        Console.Write(array[i] + ",");
    }
Console.Write(array[array.Length -1]); 
Console.Write("]");
Console.WriteLine();
