// Программа, к-рая на вход принимает два числа и выдает, какое число
// большее, а какое меньшее
// a = 5, b = 7 -> max = 7
// a = -9, b = -3 -> max = -3
/*
Console.Write("Введите первое число -  ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число -  ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber + " больше чем " + secondNumber);
}
else
{
    Console.WriteLine(secondNumber + " больше чем " + firstNumber);
}
*/


// Программа, которая на вход принимает три числа и выдает 
// максимальное из этих чисел
// 2, 3, 8 -> 8
// 24, 2, 78 -> 78
/*
Console.Write("Введите первое число -  ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число -  ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число -  ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (secondNumber > max)
{
    max = secondNumber;
}
if (thirdNumber > max)
{
    max = thirdNumber;
}

Console.WriteLine("максимальное число -  " + max);
*/


// Программа, которая на вход принимает число и выдает, является ли 
// число четным
// 4 -> да
// -7 -> нет
/*
Console.Write("Введите число -  ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 2 == 0)
{
    Console.WriteLine(Number + " - четное число ");
}
else
{
    Console.WriteLine(Number + " - нечетное число ");
}
*/


// Программа, к-рая на вход принимает число N, а на выходе показывает
// все четные числа от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число -  ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number < 0)
{
    Number = Number * (-1);
}
int i = 1;

 while (i <= Number)
 {
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i = i + 1;
 }