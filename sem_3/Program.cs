﻿// Задача №1

//Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// 1)тип данных
// 2) []- обозначение масссива. мы показываем, что задаем не число, а массив
// 3) имя массива
// 4) = присваиваем значение
// 5) само значение

// int[] array = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
// int numberForSearch = 44;

// точка старта, условие, переход к след. элементу (увеличение переменной счетчика)
// for (int i = 0; i < array.Length; i++)
// {
// if (numberForSearch == array[i])
// {
//     Console.WriteLine("Да");
//     break; //сломали цикл, когда нашли число
// }
// else
// {
//     Console.WriteLine("Нет");
// }
// }
 // по такому принципу мы получим ответ по каждому элементу: "НЕТ", "НЕТ", "НЕТ", "ДА", "НЕТ".
 //чтобы вывести один ответ есть ли элемент в массиве, убираем Console.WriteLine

// int[] array = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
// int numberForSearch = 120;
// bool isFound = false; //Число не найдено изначально, false. 
// //Эта переменная дает в конце вывести один ответ, а не отписывать покаждой переменной. 
// //Отвечает на вопрос есть искомая переменная в массиве или нет.

// for (int i = 0; i < array.Length; i++)
// {
// if (numberForSearch == array[i])
// {
//     isFound = true;
//     break; //сломали цикл, когда нашли число
// }
// }
// // else не нужно прописывать, потому что он в начале указан. Это будет лишним действием.

// if (isFound) // isFound == true
// {
//     Console.WriteLine("Да");
// }
// else //isFound == false
// {
//     Console.WriteLine("Нет");
// }



//Задача №2

// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// int[] array = { -1, -2, -3, -4, -5, 0, 1, 2, 3, 4 };
// Console.WriteLine($"Исходный массив: [ {string.Join("; ", array)} ]");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = -array[i]; 
// 1 вариант решения
// Console.Write(array[i] + " ");
// }
//2- ой способ решения
// Console.WriteLine($"Результат: [ {string.Join("; ", array)} ]");

//Задача №3

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

// int[] array = { 11, 22, 33, 44, 2, 3, 2 }; // 7 элементов в массиве
// int[] result = new int[array.Length / 2]; // 7 / 2 = 3 (округляем в меньшую сторону). 3 элемента в новом массиве
// // i - индекс 0 эл. j - номер последнего эл.
// for (int i = 0, j = array.Length - 1; i < result.Length; i++, j--)
// // array.Length - 1 - i (так можно без переменной j выполнить)
// {
//     result[i] = array[i] * array[j];
//     //result[0] = array[0] * array[6];
//     // result[0] = 11 * 2 = 22
// }
// Console.WriteLine($"Результат: [ {string.Join("; ", result)} ]");




