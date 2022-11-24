Console.WriteLine("Привет! Введи по порядку 3 разных числа и мы найдем большее среди них");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
} 
if (c > max)
{
    max = c;
}
Console.WriteLine("Наибольшее из введенных чисел -> " + (max));
