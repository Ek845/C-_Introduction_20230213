// Вводишь символ с клавиатуры, программа проверяет, является ли он цифрой,
// Большой латинской буквой. Продолжается до тех пор, пока не нажмешь Esc.

// ConsoleKeyInfo keyInfo;
// do
// {
//     keyInfo=Console.ReadKey();
//     char c=keyInfo.KeyChar;
//     System.Console.WriteLine();
//     System.Console.WriteLine((int)c);
//     if (c>='0' && c<-'9') System.Console.WriteLine("Digit");
//     if (c>='A' && c<='Z') System.Console.WriteLine("Big latin");
//     if (char.IsDigit(c)) System.Console.WriteLine("Digit");
//     System.Console.WriteLine(keyInfo.Key);
// }
// while (keyInfo.Key!=ConsoleKey.Escape);


// Strings are immutable
// Создаем массив символов, в нем уже меняем то, что нужно,
// в строку присваиваем измененный масив и выводим ее.

// string s="Hello!";
// System.Console.WriteLine(s[2]);
// char[] chars=s.ToCharArray();
// chars[0] ='h';
// s=new string(chars);
// System.Console.WriteLine(s);


// ReadLN(a,b,c) 3 4 5 -- Pascal
// Ввод нескольких значений в С#

// string s=Console.ReadLine();
// string[] s1=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
// int[] a=new int[s1.Length];
// // for(int i=0;i<a.Length;i++)
// //  a[i]=Convert.ToInt32(s1[i]);
// int[] b=Array.ConvertAll<string, int>(s1, Convert.ToInt32);
// for (int i=0; i<s1.Length; i++)
//     System.Console.WriteLine(b[i]);


//String VS StringBuilder (Когда большие массивы данных)

// using System.Text;
// System.Diagnostics.Stopwatch stopwatch=new System.Diagnostics.Stopwatch();
// stopwatch.Start();
// string s="";
// int N=10000;
// for (int i=0; i<N; i++)
//     s=s+"ABCDEFGHIJKLMNOPQRSTUVWXYZ";
// stopwatch.Stop();
// System.Console.WriteLine(stopwatch.ElapsedMilliseconds);
// stopwatch.Reset();
// stopwatch.Start();
// StringBuilder sb=new StringBuilder();
// for (int i=0; i<N; i++)
//     sb.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
// stopwatch.Stop();
// string s3=sb.ToString();
// System.Console.WriteLine(stopwatch.ElapsedMilliseconds);

//
// int a=1, b=2;
// Random r1=new Random(100);
// Random r2=new Random(100);
// r2=r1;
// System.Console.WriteLine(r1==r2);
// string s1="Hello!";
// string s2="hello";
// System.Console.WriteLine(s1.IndexOf("lo"));


string[] s3= new string[3];
s3[0]="word1";
s3[1]="word2";
s3[2]="word3";
string s4=String.Join(" ", s3); //статический метод
System.Console.WriteLine(s4);