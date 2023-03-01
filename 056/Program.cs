// 56. Написать программу копирования массива

int[] arr= new int[10];
Random random=new Random();
int i;

for (i=0; i<arr.Length; i++)
{
    arr[i]=random.Next(1,10);
}

int[] b=new int[arr.Length];
Array.Copy(arr,b,arr.Length);

for (i=0; i<arr.Length; i++)
System.Console.Write($"{arr[i]} ");
System.Console.WriteLine();
for (i=0; i<arr.Length; i++)
System.Console.Write($"{b[i]} ");
