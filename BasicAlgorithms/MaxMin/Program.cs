// Дано число. Найти максимальную и минимальную цифру.

int N=150234;
int min, max;
int d;
min=10;
max=-1;
while (N!=0)
{
    d=N%10;
    if (d>max) max=d;
    if (d<min) min=d;
    N/=10;
}
System.Console.WriteLine($"min={min} max={max}");
