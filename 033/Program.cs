// 33. Возведите число А в натуральную степень В, используя цикл

int A, B;

System.Console.WriteLine("Введите число А");
A=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень В");
B=Convert.ToInt32(Console.ReadLine());

if (B>0)
{
    System.Console.WriteLine($"{A}^{B}="+Math.Pow(A,B));
}

// while, do while, for , foreach


