// 44. Определить, присутствует ли в заданном массиве некоторое число

int[] arr=new int[10];
Random random=new Random();
for (int i=0; i<arr.Length; i++)
    arr[i]=random.Next(1,10);

for (int i=0; i<arr.Length; i++)
    System.Console.Write($"{arr[i]} ");
    System.Console.WriteLine();

int find=7;
int j=0;
while (j<arr.Length && arr[j]!=find) j++;
if (j==arr.Length)
    System.Console.WriteLine("NO");
else 
    System.Console.WriteLine($"Element {find} is found at index {j}");
    