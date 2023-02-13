// 11. Дано число больше 9. Вывести на экран вторую цифру числа с конца.

int n=123;
int d0,d1,d2;
d0=n%10;
d1=n/10%10;
d2=n/100;
System.Console.WriteLine($"{d0} {d1} {d2}");


// 7. Выяснить, является ли число четным.
int N2=7;
bool odd=N2%2==0;
if (odd==true)
{
    System.Console.WriteLine($"Число {N2} четное");
};
else 
{
    System.Console.WriteLine($"Число {N2} нечетное");
};