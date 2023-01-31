//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
Console.WriteLine("Введите число возводимое в степень");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень возведения числа");
int p_ow= Convert.ToInt32(Console.ReadLine());
int num = 1;
for( int i = 1; i <=p_ow; i++)
{
    num *= number;

}
Console.WriteLine($"Полученное число: {num}");