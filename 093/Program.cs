// Задача 93: Задайте две матрицы. Напишите программу с подпрограммой MultiMatrix, которая будет находить произведение двух матриц. 
// Простым поэлементным перемножением
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int[,] Random2DArray(int N, int M, int min, int max)
{
int[,] a=new int[N, M];
Random random= new Random();
for (int i=0; i<a.GetLength(0); i++)
    for (int j=0; j<a.GetLength(1); j++)
    a[i,j]=random.Next(min, max+1);
    return a;
}
void PrintArray(int[,] a)
{
for (int i=0; i<a.GetLength(0); i++)
    for (int j=0; j<a.GetLength(1); j++)
    System.Console.Write($"{a[i,j], 3}");
System.Console.WriteLine();
}
int[,] MultiMatrix(int[,] a, int[,] b)
{
int[,] c=new int[4,4];
for (int i=0; i<a.GetLength(0); i++)

     for (int j=0; j<a.GetLength(1); j++)
                    
                        c[i,j]=a[i,j]*b[i,j];
                        return c;
}
                    
int[,] a=Random2DArray(4, 4, 0, 10);
PrintArray(a);
int[,] b=Random2DArray(4, 4, 0, 10);
PrintArray(b);
int[,] c= MultiMatrix(a,b);
PrintArray(c);

    
   
 