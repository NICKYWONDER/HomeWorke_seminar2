// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
//Обязательна проверка на ввод чисел больше/меньше 3-х знаков

// 456 -> 5
// 782 -> 8
// 918 -> 1
// Решение:

// int number = new Random().Next(100,1000);
// int second_number = number / 10 % 10;
// Console.WriteLine($"Вторая цифра в числе {number} -> {second_number}");
// Console.WriteLine("Введите трехзначное число: ");

// int number1 = int.Parse(Console.ReadLine()!);
// string num1 = Convert.ToString(number1);
// if (num1.Length == 3){
//     Console.WriteLine($"Вторая цифра в числе {number1} -> {num1[1]}");
// }
// else{
//     Console.WriteLine($"Нет! Введите трехзначное число: ");
// }
// int number2 = int.Parse(Console.ReadLine()!);
// string num2 = Convert.ToString(number2);
// if (num2.Length == 3){
//     Console.WriteLine($"Вторая цифра в числе {number2} -> {num2[1]}");
// }



//__________________________________________________________________________________________________________________________________________________
// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
// Решение:

// Console.WriteLine($"Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if (number < 100){
//     Console.WriteLine($"Нету трех цифр");
// }

// if (number >= 100 && number <= 1000){
//     int third_number = number % 10;
//     Console.WriteLine($"Третья цифра числа {number} -> {third_number} ");
// }
// if (number >= 1000 && number <= 9999){
//     int third_number = (number % 100) / 10;
//     Console.WriteLine($"Третья цифра числа {number} -> {third_number} ");
// }
// if (number >= 10000 && number <= 100000){
//     int third_number = (number % 1000) / 100;
//     Console.WriteLine($"Третья цифра числа {number} -> {third_number} ");
// }
// if (number > 100000){
//     Console.WriteLine($"Нет! Введите трехзначное число: ");
//     return;
// }

//__________________________________________________________________________________________________________________________________________________
// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
//Обязательна проверка на ввод числа <1 и >7

// 6 -> да
// 7 -> да
// 1 -> нет
// Решение:

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if ((number > 7) ||(number < 1 )){
//     Console.WriteLine($"Попробуй в диапазоне 1 - 7: ");
// }
// if (number > 5){
//     Console.WriteLine("ДА");
// }
// else{
//     Console.Write("НЕТ");
// }
