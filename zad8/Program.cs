int a,b;
Console.WriteLine("Введи первое число - ");
a = Convert.ToInt32(Console.ReadLine());
b=1;
while (b<=a)
{
    if (b%2==0)
    Console.WriteLine(b++);
    else
    b++;
}
