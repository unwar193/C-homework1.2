﻿/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int number3 = int.Parse(Console.ReadLine());


if (number1 > number2){
    if (number1 > number3){
        Console.WriteLine("Max = " + number1);
    } else {
        Console.WriteLine("Max = " + number3);
    }
} else if (number2 > number1){
        if (number2 > number3){
            Console.WriteLine("Max = " + number2);
        } else {
    Console.WriteLine("Max = " + number3);
    };
};