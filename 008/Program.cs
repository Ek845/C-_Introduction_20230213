// 8. Вывести на экран числа от -N до N.

Int32 N,s;

System.Console.WriteLine("Введите число N");
N=Convert.ToInt32(Console.ReadLine());
s=-N;

while (s!=N)
{
    System.Console.WriteLine($"{s}");
    s=(s+1);
}
System.Console.WriteLine($"{N}");