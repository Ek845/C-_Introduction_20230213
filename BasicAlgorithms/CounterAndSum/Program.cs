// Подсчитать количество цифр и их сумму.

int N=1234;
int counter=0;
int sum=0;

while (N!=0)
{
    counter++;
    int d=N%10;
    //sum=sum+d;
    sum+=d;
    //N=N/10;
    N/=10;
}
System.Console.WriteLine(counter);
System.Console.WriteLine(sum);
