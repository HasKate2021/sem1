// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

int m=(n/2)*2;
if (m==n)
{
    Console.WriteLine(" Да ");   
}     
else   
{
    Console.WriteLine(" Нет ");   
} 