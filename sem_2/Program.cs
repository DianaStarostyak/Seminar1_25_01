//Задача1
// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// int number = 971;
// int firstDigit = number / 100; // 256 / 100 = 2
// int thirdDigit = number % 10; // 256 % 10 = 6
// int result = firstDigit * 10 + thirdDigit; // 2 * 10 + 6 = 26
// $"Текст {number} текст {number / 100} текст"
// Console.WriteLine($"Результат от числа {number} => {result}");

//Задача2
// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// int number = 972;
// int thirdDigit = number % 10; // 972 % 10 = 2
// int secondDigit = number / 10 % 10; // 972 / 10 % 10 = 97 % 10 = 7
// // Math.Pow(2, 3) => 2 в 3 степени, 2*2*2 = 8
// int result = (int)Math.Pow(secondDigit, thirdDigit);
// Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");
// 7 ^ 2 = 49

//Задача3
// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

        // int number = 12345678;
        // if (number < 100) // Число не ТРЕХЗНАЧНОЕ
        // {
        //     Console.WriteLine("Третьей цифры нет");
        // }
        // else
        // {
        //     int thirdDigitFromEnd = number / 100 % 10;
        //     // 7812 / 100 % 10 = 78 % 10 = 8
        //     Console.WriteLine($"Третья цифра от {number} c конца: {thirdDigitFromEnd}");
        // }

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int number = 972;
//         if (number < 100) // Число не ТРЕХЗНАЧНОЕ
//         {
//             Console.WriteLine("Третьей цифры нет");
//         }
//         else // Третья цифра есть
//         {
//             int thirdDigitFromEnd = number / 100 % 10;
//             // 7812 / 100 % 10 = 78 % 10 = 8
//             Console.WriteLine($"Третья цифра от {number} с конца: {thirdDigitFromEnd}");
//         }
//     }
// }
// ошиблась:
// if (number < 100) поставила ; , не нужно этот знак ставить
// Console.WriteLine($"Третья цифра от {number} с конца: {thirdDigitFromEnd}"); Здесь забыла $

// int a = 8;
// // && - "И": апельсины И яблоки ()
// if (a % 2 == 0 && a % 3 == 0)
// {
//     Console.WriteLine("+"); // Число кратно 2 и 3(нацело делится)
// }

