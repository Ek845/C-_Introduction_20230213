// 14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

int a,b,w;

System.Console.WriteLine("Введите число а: ");
a=System.Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b: ");
b=System.Convert.ToInt32(Console.ReadLine());
w=a%b;

 if (a%b==0)
 {
    System.Console.WriteLine("Число a кратно числу b");
 }

 else
 {
    System.Console.WriteLine($"Остаток от деления a на b: {w}");
 }