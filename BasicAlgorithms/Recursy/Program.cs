// Вывести на экран числа от 1 до N без использования цикла. goto ЗАПРЕЩЕНО

int N=10;
int i=0;
 
//  System.Console.WriteLine(i++); -- постинкремент
//  System.Console.WriteLine(++i); -- прединкремент

// while (i<N)
// {
//     i++ -- инкремент
//     System.Console.Write($"{i++,4}");
// }

// GOTO
// metka:
// System.Console.Write($"{i++,4}");
// if (i<N) goto metka; -- оператор безусловного перехода


// Рекурсивный метод

void Loop(int i, int N)
{
    System.Console.Write($"{i,4}");
    if (i<N) Loop(i+1,N);
}

// Нахождение факториала 

int F(int N)
{
    if (N>0) return F(N-1)*N;
    else return 1;
}

// Фибоначчи

int Fib(int N)
{
    if (N==0) return 0;
        else 
            if (N==1) return 1;
                else 
                    return Fib(N-1)+Fib(N-2);
}

// Возведение числа в степень

double Power(int a, int b)
{
    if (b==0) return 1;
        else
            if (b>0)
                return Power(a,b-1)*a;
                    else
                        return Power(a,b+1)*1/a;
}

