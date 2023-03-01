// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

int N;
int i;
int n=0;

N=Convert.ToInt32(Console.ReadLine());

int[] arr= new int[N];

for (i=0; i<arr.Length; i++)
    {
        arr[i]=i;
    }

for (i=0; i<arr.Length; i++)
System.Console.Write(arr[i]);
System.Console.WriteLine();
System.Console.Write($"{0} ");


for (i=1, n=1; i<arr.Length; i++)
{
  n*=i;
  System.Console.Write($"{n} ");
}
