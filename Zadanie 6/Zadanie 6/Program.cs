Console.Write("Введите число: ");
int i = int.Parse(Console.ReadLine());

if (i % 2 == 1)
{
    Console.WriteLine("Число " + i + " нечетное");
}
else
{
    Console.WriteLine("Число " + i + " четное");
}