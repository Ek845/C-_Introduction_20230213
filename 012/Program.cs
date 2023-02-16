// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

int n;
int d1,d2; 

System.Console.WriteLine("Введите целое число от 10 до 99");
n=System.Convert.ToInt32(Console.ReadLine());
d1=n%10;
d2=n/10%10;


if (d1>d2)
    {
        System.Console.WriteLine($"Наибольшая цифра введенного числа: {d1}");
    }

if (d1<d2)
    {
         System.Console.WriteLine($"Наибольшая цифра введенного числа: {d2}");
    }   

if (d1==d2)
    {
         System.Console.WriteLine($"Цифры данного числа равны между собой");
    }

