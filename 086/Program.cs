// 86.  Подсчитать сколько раз определенный символ 
// (например 'a') встречается в строке.

int i=0;
string s="jkdhbaslkиииjfhlbsaaa";
char[] chars=s.ToCharArray();

foreach(int el in chars)
    if(el=='b')
        i++;

System.Console.WriteLine($"Символ b встречается {i} раз(a)");
