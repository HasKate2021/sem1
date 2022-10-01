// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine()!);
if (a>b)
{
    Console.WriteLine($"max= {a} ");  
}    
else if (a<b)
{
    Console.WriteLine($"max= {b} ");   
}   
else if (a==b)
{
    Console.WriteLine("числа равны");   
}  