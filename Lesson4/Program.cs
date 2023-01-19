// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите пожалуйста число : ");
int numN = Convert.ToInt32(Console.ReadLine());

int num = 1;

while (num <= numN)
{
    if(num % 2 == 0)
    {
        System.Console.WriteLine(num);
        num++;
    }
    else
    {
        num++;
    }

}

