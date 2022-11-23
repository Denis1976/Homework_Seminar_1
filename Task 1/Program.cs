Console.WriteLine("Привет! Введи в строке 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи в строке 2 число, тогда мы узнаем большее их них");
int b = Convert.ToInt32(Console.ReadLine());

if(b > a)
{
   Console.WriteLine("Мы нашли! Ура! Большее число " +(b));
}
else 
{
   Console.WriteLine("Мы нашли! Ура! Большее число " +(a));
} 