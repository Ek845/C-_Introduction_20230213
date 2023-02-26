// 45. Задать массив, заполнить случайными положительными трехзначными числами.
// Показать количество нечетных/четных чисел.

int[] arr= new int[10];
Random random=new Random();
for (int i=0; i<arr.Length; i++)
    arr[i]=random.Next(100,1000);

for (int i=0; i<arr.Length; i++)
    System.Console.Write($"{arr[i]} ");
    System.Console.WriteLine();

for (int i=0; i<arr.Length; i++)
    if (arr[i]%2==0) 
        System.Console.Write($"{arr[i]} ");
        System.Console.WriteLine();

for (int i=0; i<arr.Length; i++)
    if (arr[i]%2!=0)
        System.Console.Write($"{arr[i]} ");
