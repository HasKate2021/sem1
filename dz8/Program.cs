// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите целое положительное число: ");
int n = int.Parse(Console.ReadLine()!);

int i=0;
int m=1;

if (n>0)
{
    while (i<n)
    {
        int s=(m/2)*2;
        if(s==m)
        {
            Console.WriteLine($" {m} ");  
        }
        
        i=i+1;
        m=m+1;
    }
}
else 
{
    Console.WriteLine("неверное число");   
}  