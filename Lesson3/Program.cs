// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 2;

if(result == 0)
{
   System.Console.WriteLine("четное");
}
else
{
    System.Console.WriteLine("нечетное");
}
