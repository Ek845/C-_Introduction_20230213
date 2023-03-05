// 64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

int[,] Random2DArray(int N, int M, int min, int max)
{
    int[,] arr=new int[N,M];
    Random random=new Random();
        for(int i=0; i<arr.GetLength(0); i++)
            for(int j=0; j<arr.GetLength(1); j++)
                arr[i,j]=random.Next(min,max+1);
return arr;
}
void Print2DArray(int[,] arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
        for(int j=0; j<arr.GetLength(1); j++)
            System.Console.Write($"{arr[i,j], 6}");
            System.Console.WriteLine();
}
void ChangeElements2(int[,] arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
        for(int j=0; j<arr.GetLength(1); j++)
         if (i%2==0 && j%2==0)
            arr[i,j]=(int)Math.Pow(arr[i,j],2);
}
void PrintChangedArray(int[,] arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
        for(int j=0; j<arr.GetLength(1); j++)
            System.Console.Write($"{arr[i,j], 6}");
            System.Console.WriteLine();
}

int[,] arr=Random2DArray(4,5,0,100);
Print2DArray(arr);
ChangeElements2(arr);
PrintChangedArray(arr);