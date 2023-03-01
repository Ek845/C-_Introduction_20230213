// Выяснить, являются ли 3 числа сторонами треугольника.

int a=6, b=2, c=3;

if (a+b>c && a+c>b && b+c>a)
    System.Console.WriteLine("Являются");
else System.Console.WriteLine("Не являются");