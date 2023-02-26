// Подсчитать среднюю температуру за неделю
// double t1, t2, t3, t4, t5, t6, t7;
// t1=Convert.ToDouble(Console.ReadLine());
// t2=Convert.ToDouble(Console.ReadLine());
// t3=Convert.ToDouble(Console.ReadLine());
// t4=Convert.ToDouble(Console.ReadLine());
// t5=Convert.ToDouble(Console.ReadLine());
// t6=Convert.ToDouble(Console.ReadLine());
// t7=Convert.ToDouble(Console.ReadLine());
// double sr=(t1+t2+t3+t4+t5+t6+t7)/7;
// System.Console.WriteLine(sr);

double[] temp=new double[7];
for (int i=0; i<temp.Length; i++)
    temp[i]=Convert.ToDouble(Console.ReadLine());

double s =0;
for (int i=0; i<temp.Length;i++)
s=s+temp[i];
System.Console.WriteLine(s/temp.Length);