// 6. Написать программу вычисления значения функции y = sin(a). (Класс Math). 

Double y,a;

System.Console.WriteLine("Введите число а: ");
a=Convert.ToDouble(Console.ReadLine());

y = Math.Sin(a);
System.Console.WriteLine($"Значение функции y={y}");