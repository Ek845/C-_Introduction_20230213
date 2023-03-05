// 60. Показать двумерный массив размером m×n заполненный целыми случайными числами

int[,] Random2DArray(int m, int n, int min, int max)
{
int[,] arr=new int[m,n];
Random random=new Random();
 for(int i=0; i<arr.GetLength(0); i++)
    for(int j=0; j<arr.GetLength(1); j++)
        arr[i,j]=random.Next(min,max+1);
return arr;
}

void Print2DArray(int[,] arr)

{
    for (int i=0; i<arr.GetLength(0); i++)
        for(int j=0; j<arr.GetLength(1); j++)
            System.Console.Write($"{arr[i,j], 5}");
            System.Console.WriteLine();
}  

int [,] arr=Random2DArray(4,4,0,100);
Print2DArray(arr);