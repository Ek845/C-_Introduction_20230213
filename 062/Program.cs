// 62. В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]). 
// Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.

int[,] Random2DArray(int n, int k, int min, int max)
{
    int[,] arr=new int[n,k];
    Random random=new Random();
        for(int i=0;i<arr.GetLength(0); i++)
            for(int j=0; j<arr.GetLength(1); j++)
                arr[i,j]=random.Next(0,100);
    return arr;
}
void Print2DArray(int[,] arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
        for(int j=0; j<arr.GetLength(1); j++)
            System.Console.Write($"{arr[i,j], 6}");
            System.Console.WriteLine();
}
void ChangeElements(int[,] arr)
{
    for(int i=0;i<arr.GetLength(0); i++)
        for(int j=0; j<arr.GetLength(1); j++)
            if (arr[i,j]%2==0)
                arr[i,j]=-arr[i,j];
   
}
void PrintChangedArray(int[,] arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
        for(int j=0; j<arr.GetLength(1); j++)
            System.Console.Write($"{arr[i,j],6}");
            System.Console.WriteLine();
}


int[,] arr=Random2DArray(5,4,0,100);
Print2DArray(arr);
ChangeElements(arr);
PrintChangedArray(arr);

