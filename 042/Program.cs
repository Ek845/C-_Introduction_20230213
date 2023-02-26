// 42. Задать массив из 12 элементов, заполненный числами [-9;9].
// Найти сумму положительных/отрицательных элементов массива.

int[] arr=new int[12];
Random random=new Random();
for (int i=0; i<arr.Length; i++)
    arr[i]=random.Next(-9,10);

for (int i=0; i<arr.Length; i++)
    System.Console.Write($"{arr[i]} ");
System.Console.WriteLine();

int sp=0;
for (int i=0; i<arr.Length; i++)
    if (arr[i]>0)
        sp=sp+arr[i];

int sn=0;
for (int i=0; i<arr.Length; i++)
    if (arr[i]<0)
        sn=sn+arr[i];
    
System.Console.WriteLine($"Sum of positive numbers: {sp}");
System.Console.WriteLine($"Sum of negative numbers: {sn}");




