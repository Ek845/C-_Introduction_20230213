// 74. Найти сумму цифр числа

// Для простоты задача решена для цифр и двузначных чисел. Можно добавить большее количество разрядов.

int Sum(int n)
{
    if (n>=10 && n<100 || n<=-10 && n>-100) return Sum(n/10+n%10);
        else    
            // if (n<10 && n>-10)
            return Sum(n);
}
Sum(92);