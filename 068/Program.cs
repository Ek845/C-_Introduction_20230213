// 68. Написать программу, которая обменивает элементы первой строки и последней строки.

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
    for (int i=0; i<arr.GetLength(0); i++)
        for (int j=0; j<arr.GetLength(1); j++)
            System.Console.Write($"{arr[i,j], 6}");
            System.Console.WriteLine();
}
void ChangeStringElements(int[,] arr)
{
    int t=0;
    int l=arr.GetLength(0)-1;
    int i=0; int j=0;
    for (i=0; i<arr.GetLength(0); i++)
    {
    for (j=0; j<arr.GetLength(1); j++) 
            if (i==0)
            {
                t=arr[0,j];
                arr[0,j]=arr[l,j];
                arr[l,j]=t;
            }
    }
}
void PrintChangedArray3(int[,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
        for (int j=0; j<arr.GetLength(1); j++)
            System.Console.Write($"{arr[i,j], 6}");
            System.Console.WriteLine();
}

int[,] arr=Random2DArray(4,5,0,100);
Print2DArray(arr);
ChangeStringElements(arr);
PrintChangedArray3(arr);