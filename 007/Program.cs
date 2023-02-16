//  7. Выяснить, является ли число четным.
 Int32 N2;
 bool odd;
 System.Console.WriteLine("Введите число для проверки на четность");
 N2=System.Convert.ToInt32(Console.ReadLine());
 odd=N2%2==0;
 if (odd==true)
 {
     System.Console.WriteLine($"Число {N2} четное");
 }
 
 else 
 {
     System.Console.WriteLine($"Число {N2} нечетное");
 }
