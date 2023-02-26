using System;

// void Swap(int x, int y)
// {
//     int t=x;
//     x=y;
//     y=x;
// }

void Swap(ref int x, ref int y) // передача по ссылке
{
    int t=x;
    x=y;
    y=x;
}

void Calculator(int a, int b, out int sum, out int sub)
{
    sum=a+b;
    sub=a-b;
}

int a=4;
int b=5;
int s,sb;
Calculator(a,b,out s, out sb);

Console.WriteLine($"a={a} b={b}");
Swap(ref a, ref b);
Console.WriteLine($"a={a} b={b}");

// a=a+b
// b=a-b;
// a=a-b;
