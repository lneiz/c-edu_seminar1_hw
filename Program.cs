// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 < num2) Console.WriteLine($"max = {num2}, min = {num1}");
else Console.WriteLine($"max = {num1}, min = {num2}");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
int max = 0;
Console.WriteLine("Введите числа: ");

for(int i = 0; i < 3; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    if(max < num)
    {
        max = num;
    }
}

Console.WriteLine("Максимальное число: " + max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;

while(i <= num)
{
    Console.Write(i + " ");
    i += 2;
} 
*/