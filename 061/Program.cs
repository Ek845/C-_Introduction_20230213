// 61. Показать двумерный массив размером m×n заполненный вещественными случайными числами.

double[,] RandomDouble2DArray(int m, int n, int min, int max)
{
    double[,] arr=new double[m,n];
    Random random=new Random();
        for (int i=0; i<arr.GetLength(0); i++)
            for (int j=0; j<arr.GetLength(1); j++)
                arr[i,j]=random.NextDouble();
    return arr;
}
void PrintDouble2DArray(double[,] arr)
{
    for(int i=0;i<arr.GetLength(0); i++)
        for(int j=0; j<arr.GetLength(1); j++)
            System.Console.Write($"{arr[i,j],6:F2}");
            System.Console.WriteLine();
}

double[,] arr=RandomDouble2DArray(4,4,0,100);
PrintDouble2DArray(arr);