/*
Решение в группах задач:
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/


Console.Clear();
int A, B, C;
Console.Write("Введите длины сторон треугольника: ");
while (!int.TryParse(Console.ReadLine(), out A) || A < 0) {
Console.Write("Ошибка! Введите положительное число: ");
}
Console.Write("Введите длины сторон треугольника: ");
while (!int.TryParse(Console.ReadLine(), out B) || B < 0) {
Console.Write("Ошибка! Введите положительное число: ");
}
Console.Write("Введите длины сторон треугольника: ");
while (!int.TryParse(Console.ReadLine(), out C) || C < 0) {
Console.Write("Ошибка! Введите положительное число: ");
}

if (A < B + C & B < A + C & C < A + B) 
    Console.Write("Может!");
else 
    Console.Write("Не может!");
Console.WriteLine( );


Console.Clear();
int A, B, C;
Console.Write("Введите длины сторон треугольника: ");
while (!int.TryParse(Console.ReadLine(), out A) || A < 0) {
Console.Write("Ошибка! Введите положительное число: ");
}
Console.Write("Введите длины сторон треугольника: ");
while (!int.TryParse(Console.ReadLine(), out B) || B < 0) {
Console.Write("Ошибка! Введите положительное число: ");
}
Console.Write("Введите длины сторон треугольника: ");
while (!int.TryParse(Console.ReadLine(), out C) || C < 0) {
Console.Write("Ошибка! Введите положительное число: ");
}

if (A < B + C & B < A + C & C < A + B) 
    Console.Write("Может!");
else 
    Console.Write("Не может!");
Console.WriteLine( );
Console.WriteLine( );

