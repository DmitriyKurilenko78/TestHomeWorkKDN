Console.Clear();
Console.Write("Введите число a = ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число b = ");
int b = int.Parse(Console.ReadLine()!);

if (a > b)
    Console.Write($"max = {a}, min = {b}");
else 
    Console.Write($"max = {b}, min = {a}");

    

Console.Clear();
Console.Write("Введите числo a ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите числo b ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите числo c ");
int c = int.Parse(Console.ReadLine()!);

if (a > b && a > c)
    Console.Write(a);
else if (b > a && b > c)    
    Console.Write(b);
else 
    Console.Write(c);
    
    
    
    Console.Clear();
Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0 )
    Console.WriteLine("Да");
else
     Console.WriteLine("Нет");
     
  /// Вывод четных чисел  ///
     Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
    
for (int i = 1; i <= n; i++)
   if (i % 2 == 0)                // изменяя == на != выведем все нечетные числа
      Console.Write($"{i}, ");
      
      
      
      
    


    

