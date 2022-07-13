int a,b,c;
Console.WriteLine("Введи первое число - ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число - ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье число - ");
c = Convert.ToInt32(Console.ReadLine());
int []  numbers = {a,b,c};
int MaxValue = numbers.Max();
Console.WriteLine(MaxValue);

