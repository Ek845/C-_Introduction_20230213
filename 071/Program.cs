// 71. Показать натуральные числа от N до 1, N задано

void Numbers2(int i, int N)
{
    System.Console.Write($"{i,4}");
    if (i>1) Numbers2(i-1, N);
}

Numbers2(20, 20);