// 40. Задать массив из 8 целых элементов и вывести их на экран

int[] arr=new int[8];
Random random=new Random();
for (int i=0; i<arr.Length; i++)
    arr[i]=random.Next(0,100);

for (int i=0; i<arr.Length; i++)
System.Console.WriteLine($"{arr[i]}");

