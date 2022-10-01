// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 3: ");
int c = int.Parse(Console.ReadLine()!);

if (a>b)
{
    if(a>c)
    {
        Console.WriteLine($"max= {a} "); 
    }
    else
    {
        Console.WriteLine($"max= {c} "); 
    }   
}  
else if (b>c)
{
    Console.WriteLine($"max= {b} ");
}  
else 
{
    Console.WriteLine($"max= {c} ");
}    

   