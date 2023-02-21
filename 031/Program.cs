// 31. Вывести на экран кубы чисел от 1 до N

int N;
System.Console.WriteLine("Введите максимальное число диапазона");
N=Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=N;i++)
{
    System.Console.WriteLine(Math.Pow(i,3));
}
