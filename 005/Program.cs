// 5. C клавиатуры вводятся три числа. Найти максимальное из трех чисел

Int32 a,b,c,max;

System.Console.WriteLine("Введите число a: ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b: ");
b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число с: ");
c=Convert.ToInt32(Console.ReadLine());
max=a;

if (b>max)
{
    max=b;
}

if (c>max)
{
    max=c;
}

System.Console.WriteLine($"Максимальное число: {max}");
