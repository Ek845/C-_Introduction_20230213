﻿// По месяцу определить время года, использовать ИЛИ. 
// int month= 4;
// if (month==1 || month==2 || month==12) System.Console.WriteLine("Winter");
// if (month==3 || month==4 || month==5) System.Console.WriteLine("Spring");
// if (month==6 || month==7 || month==8) System.Console.WriteLine("Summer");
// if (month==9 || month==10 || month==11) System.Console.WriteLine("Autumn");

// Вводится возраст человека, нужно определить, подходит ли он для работы (25-40).
int age=15;
// if (age>=25)
//     if (age<=40)
//         System.Console.WriteLine("Подходит");
//     else 
//         System.Console.WriteLine("Не подходит");
// else 
//     System.Console.WriteLine("Не подходит");    

if (age>=25 && age<=45)
    System.Console.WriteLine("Подходит");
else 
    System.Console.WriteLine("Не подходит");
