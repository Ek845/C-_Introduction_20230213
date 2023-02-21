// Ввести число n от 1 до 10 с проверкой 

int n;
do 
{
    n=Convert.ToInt32(Console.ReadLine());
}
while (n<0 || n>10);


// Вывести на экран числа от 1 до 10

for (int i=1; i<=10; i++)
{
    System.Console.WriteLine(i);
}


// foreach для работы с коллекциями. интерфейс IEnumerable

string s=abcdef;
foreach (char c in s );
{
    System.Console.WriteLine(c);
}

