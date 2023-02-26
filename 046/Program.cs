// 46. Создать массив из 123 элементов. Заполнить случайными положительными числами от 0 до 1000.
// Найти количество элементов, которые подлежат отрезку [10;99].

int[] arr= new int[123];
int j=0; 
Random random=new Random();
for (int i=0; i<arr.Length; i++)
    arr[i]=random.Next(0,1000);

for (int i=0; i<arr.Length; i++)
    System.Console.Write($"{arr[i]} ");
    System.Console.WriteLine();

for (int i=0; i<arr.Length; i++)
    if (arr[i]>=10 && arr[i]<=99)
    j++;

System.Console.WriteLine($"{j}");
  


