// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

Int32 n;
int d0,d1,d2;
System.Console.WriteLine("Введите целое число: ");
n=System.Convert.ToInt32(Console.ReadLine());
d0=n%10;
d1=n/10%10;
d2=n/100;
System.Console.WriteLine($"{d0}");
