// 69. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int [,] Random2DArray(int N, int M, int min, int max)
{
    int [,] arr= new int[N,M];
    Random random=new Random();
        for (int i=0; i<arr.GetLength(0); i++)
            for (int j=0; j<arr.GetLength(1); j++)
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
void Sort2DArray(int[,] arr)
{   
    int j=0;
    for (int i=0; i<arr.GetLength(0); i++)
        {
            int iM=j;
            if (arr[i,j]>arr[iM,j])
                iM=i;
        int t=arr[i,j];
        arr[i,j]=arr[iM,j];
        arr[iM,j]=t;
        }
}
void PrintChangedArray4(int[,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
        for (int j=0; j<arr.GetLength(1); j++)
            System.Console.Write($"{arr[i,j], 6}");
            System.Console.WriteLine();
}

int[,] arr=Random2DArray(5,4,0,100);
Print2DArray(arr);
Sort2DArray(arr);
PrintChangedArray4(arr);