// Подсчитать сумму цифр в числе. Сделать подпрограмму

int SumDigit(int n)
{
    if (n==0)
    return 0;
int sum=0;
while (n!=0)
{
    int d=n%10;
     sum+=d;
     n/=10;
}
return sum;
}
 int n=Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine(SumDigit(n));