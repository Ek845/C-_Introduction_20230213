// 36. Написать программу вычисления произведения чисел от 1 до N

int CompNumbers(int N)
{int i=0;
int comp=1;
    while (i!=N)
    {
        i++;
        comp=comp*i;
    }
    return comp;
}
int N;
System.Console.WriteLine("Введите число N");
N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CompNumbers(N));