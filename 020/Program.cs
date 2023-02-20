// Дано число. Проверить, кратно ли он 7 и 23.

int N=2;

if (N%7==0) System.Console.WriteLine("Число кратно 7");
if (N%23==0) System.Console.WriteLine("Число кратно 23");
    else 
    if (N%7!=0 && N%23!=0) System.Console.WriteLine("Число не кратно ни 7, ни 23");

// Если в задаче имелась ввиду одновременная кратность, то:
// if (N%7===0 && N%23==0) System.Console.WriteLine("Число кратно 7 и 23");
