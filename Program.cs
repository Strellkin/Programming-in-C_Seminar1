/*
//Console.Write ("Good morning!");
Console.WriteLine ("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine ()); //запись значения
//Console.WriteLine (number);
*/

/*
//Задача 1.
//Напишите программу, которая на вход принимает число и выдаёт его квадрат
Console.Write ("Input your number: ");
int number_1 = Convert.ToInt32(Console.ReadLine ());

int result = number_1*number_1;

//Console.WriteLine ("Your number is " + number_1 + ". Square of this number is " + result);// Конкатинация (склеивание )

Console.WriteLine ($"Your number is {number_1}. Square of this number is {result}");
*/

//Задача 3. 
//Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.

//a = 5, b = 25 -> no
//a = 25, b = 5 -> yes
/*
/* 
1. запросить два значения ( 11 +12 строки) +
2. возвести второе число в квадрат
3. проверить на равенство первому числу
Console.Write ("Input your first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Input your second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine ());

if (number_1 * number_2 == number_1)
{
    Console.WriteLine($"Your first number is a square of the second one");
}
else
{
    Console.WriteLine($"Your first number is not a square of the second one");
}
*/
/*

//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine ("Input your 1st number: ");
int number_N = Convert.ToInt32(Console.ReadLine());

int current_i = number_N * (-1);

while (current_i <= number_N)
{
    Console.Write (current_i + " ");
    current_i ++; // current_i +=; current_i =current_i + 1
}
*/

//Задача 7.
//Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа.

//1. ввод числа
//2. проверить его на 3х значность (N > 99 + N < 1000) + отрицательные значения
//3. найти последнюю цифру (%10) % - остаток от деления

//456 % 10 -> 6
//456 % 100 -> 56
//456 / 10 -> 45    / - деление нацело
//456 / 100 -> 4

Console.Write ("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 99 && number < 1000 || number > -1000 && number < -99)  //&&  (или &) - логич оператор И  || - логич оператор ИЛИ
{
    //int dev = number % 10;
    //Console.WriteLine ($"Last digit {number} is {dev}");
    Console.WriteLine ("Last num is: " + number%10);
}
else
{
Console.WriteLine ("your number is not 3-digit!");
}


