
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Write("Введите два числа: ");

int number1 = Convert.ToInt32(Console.ReadLine());
 
int number2 = Convert.ToInt32(Console.ReadLine());
 
if (number1 > number2)
{
Console.Write("Наибольшее число: "+number1);
}
else
{
Console.Write("Наибольшее число:"+number2);
}
 

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите 3 числа:");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
max = num_2;
}

if (num_3 > max)
{
max = num_3;
}

Console.Write("Наибольшее из введённых чисел -> " + max);


/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.Write("Введите число:");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
Console.Write("Число " + num + "нечетное");
}
else
{
Console.WriteLine("Число " + num + "чётное");
}

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */
int  firstEven = 2;

Console.Write("Введите число:");
num = Convert.ToInt32(Console.ReadLine());

if (firstEven > num)
{
Console.WriteLine("Нет чётных чисел!");
}

Console.Write("Чётные числа от 1 до " + num);
while (firstEven <= num)
{
Console.Write(firstEven + ", ");
firstEven = firstEven + 2;
}

