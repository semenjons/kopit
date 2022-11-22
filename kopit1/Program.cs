Console.Write("Введите  число А:");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число В:");
int B = int.Parse(Console.ReadLine());

if (A > B)
{
    Console.WriteLine("Да, A является max");
}
else
{
    Console.WriteLine("Да, B является max");
}