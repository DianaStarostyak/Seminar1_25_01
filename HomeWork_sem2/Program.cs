//Задача 1
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// int digit = 322;
// int FirstNumber = 7;
// int SecondNumber = 23;

// if (digit % FirstNumber == 0 && digit % SecondNumber == 0)
// {
//     Console.WriteLine ($"Да");
// }
// else
// {
//     Console.WriteLine ($"Нет");
// }

//Задача 2
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// int x = 4;
// int y = -2;

// if (x > 0 && y > 0)
// {
//     Console.WriteLine($"1-ая координатная четверть плоскости");
// }
// if (x < 0 && y > 0)
// {
//     Console.WriteLine($"2-ая координатная четверть плоскости");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine($"3-я координатная четверть плоскости");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine($"4-ая координатная четверть плоскости");
// }

//Задача 3
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int number = 39;
// int FirsDigit = number / 10; // 40 / 10 = 4
// int SecondDigit = number % 10; // Остаток от деления на 10

// if (FirsDigit > SecondDigit)
// {
//     Console.WriteLine(FirsDigit);
// }
// else
// {
//     Console.WriteLine(SecondDigit);
// }

// Задача 4
//Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

int number = 186;
int firsDigit_1 = number / 10;
int secondDigit_1 = number % 10;
int firsDigit_2 = number / 10 / 10;
int secondDigit_2 = number / 10 % 10;
int thirdDigit_2 = number % 10;

if (number < 10)
{
    Console.WriteLine(number);
}
if (number > 10 && number < 100)
{
    Console.WriteLine($"{firsDigit_1} ; {secondDigit_1}");
}
if (number > 100)
{
    Console.WriteLine($"{firsDigit_2} ; {secondDigit_2} ; {thirdDigit_2}");
}
