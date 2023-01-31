//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12
int rez = 0;
int rez1 = 0;
Console.WriteLine("Введите любое число");
string? input = Console.ReadLine();
bool result = int.TryParse(input, out var number);
if (result == true)
    {
       while(number > 9)
           {
                rez1 = number % 10;
                rez = rez + rez1;
                number = number / 10; 
            }
        rez = rez + number;
        Console.WriteLine(rez);    
    }
else
    {
        Console.WriteLine("Вы ввели не число");   
    }

