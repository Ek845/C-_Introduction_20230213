// 41. задать массив из 8 элементов, заполненных нулями и единицами. 
// Вывести их на экран.

int[] arr=new int[8];
Random random=new Random();

for (int i=0; i<arr.Length; i++)
    arr[i]=random.Next(0,2);

for (int i=0; i<arr.Length; i++)
    System.Console.Write($"{arr[i]} ");

