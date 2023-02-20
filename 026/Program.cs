// 26. Программа проверяет пятизначное число на палиндром.

int N=53835;
int numb=N;
int n=0;

while (N!=0)

{
    n=10*n+N%10;
    N/=10;
}

if (numb==n) System.Console.WriteLine("Число является палиндромом");
else System.Console.WriteLine("Число не является палиндромом");


