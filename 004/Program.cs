// 4. По заданному с клавиатуры номеру дня недели вывести его название

Int32 N;

System.Console.WriteLine("Введите номер дня недели: ");
N=Convert.ToInt32(Console.ReadLine());

if (N==1)
{
    System.Console.WriteLine("Понедельник");
}

if (N==2)
{
    System.Console.WriteLine("Вторник");
}

if (N==3)
{
    System.Console.WriteLine("Среда");
}

 if (N==4)
 {
    System.Console.WriteLine("Четверг");
 }

 if (N==5)
 {
    System.Console.WriteLine("Пятница");
 }

 if (N==6)
 {
    System.Console.WriteLine("Суббота");
 }

 if (N==7)
 {
    System.Console.WriteLine("Воскресенье");
 }

 if (N>7)
 {
    System.Console.WriteLine("Число не попадает в интервал от 1 до 7");
 }

 if (N<1)
 {
    System.Console.WriteLine("Число не попадает в интервал от 1 до 7");
 }
