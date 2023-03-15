// Определить являются ли введенные с клавиатуры символы правильно записью целого числа. 
// Вычислить сумму цифр введенного числа
int sum=0;
string s=Console.ReadLine();
string[] s1=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=new int[s1.Length];
int[] b=Array.ConvertAll<string, int>(s1, Convert.ToInt32);
for(int i=0; i<s1.Length; i++)
    System.Console.Write($"{b[i]}");
    System.Console.WriteLine();

for (int i=0;i<b.Length; i++)
    if(b[i]>=0 && b[i]<=9)
        System.Console.WriteLine("Введенный символ верен");
    else
        System.Console.WriteLine("Введенный символ не верен");
System.Console.WriteLine();
for (int i=0; i<(b.Length-1); i++)
    sum=b[i]+b[i+1];

System.Console.WriteLine($"Сумма цифр введенного числа: {sum}");


