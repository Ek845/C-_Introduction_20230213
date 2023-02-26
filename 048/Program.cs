// 48. Задан массив а из N элементов. Заполнить массив случайными числами от 1 до 10.
// Создайте массив, который является произведением пар чисел в одномерном массиве а.
// Парой считается первый и последний элемент, второй и предпоследний и т.д.
// а) вариант, когда в массиве четное количество элементов.
// б) вариант, когда в массиве нечетное количество элементов. (и четное, и нечетное).


//ВАРИАНТ А
int[] a=new int[10];
Random random=new Random();

for (int i=0; i<a.Length; i++)
    a[i]=random.Next(1,11);

for (int i=0; i<a.Length; i++)
    System.Console.Write($"{a[i]} ");
    System.Console.WriteLine();

int[] b=new int[5];

b[0]=a[0]*a[9];      
b[1]=a[1]*a[8];        
b[2]=a[2]*a[7];
b[3]=a[3]*a[6];
b[4]=a[4]*a[5];

for (int j=0, i=0, l=(a.Length-1); j<b.Length && i<a.Length; j++, i++, l--)
b[j]=a[i]*a[l];

for (int j=0; j<b.Length; j++)
     System.Console.Write($"{b[j]} ");
     System.Console.WriteLine();


// ВАРИАНТ Б

// Для варианта б, когда в массиве и четное, и нечетное количество элементов алгоритм будет работать
// Необходимо задать количество элементов для массива b
// Пример: массив а из 11 элементов, массив b из 5 эелементов -- алгоритм посчитает элементы для массива b, 
// но элемент "посередине" оставит нетронутым
// Пример 2 (ниже): массив а из 11 элементов, массив b из 6 эелементов -- алгоритм посчитает элементы для массива b, последним его элементом будет
// помноженный сам на себя элемент "посередине" массива b


int[] a=new int[11];
Random random=new Random();

for (int i=0; i<a.Length; i++)
    a[i]=random.Next(1,11);

for (int i=0; i<a.Length; i++)
    System.Console.Write($"{a[i]} ");
    System.Console.WriteLine();

int[] b=new int[6];

for (int j=0, i=0, l=(a.Length-1); j<b.Length && i<a.Length; j++, i++, l--)
b[j]=a[i]*a[l];

for (int j=0; j<b.Length; j++)
     System.Console.Write($"{b[j]} ");
     System.Console.WriteLine();
