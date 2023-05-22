/*
Console.Clear();            // Очищает консоль
Console.WriteLine("Hello");  // Выводит данные на одной строчке
Console.Write(", word!");            // Выводит на той же строчке

Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
*/
// ctrl и /

// Ввод чисел
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{n} + {m} = {n + m}");

// желтое выделение - это предупрежденеи
// красное выделение - это ошибка
// $"" - это интерполяция строк

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n > m)
//    Console.WriteLine("Первое число больше второго");
// else if (n < m)
//    Console.WriteLine("Второе число больше первого");
// else
//    Console.WriteLine("Числа равны");

// int i = 1;
// while (i < 10)
// {
//     Console.Write($"{i} ");
//     i++;
// }

// int i = 1;
// do{
//     Console.Write($"{i} ");
//     i++;
// }
// while (i < 10);

// For
// for (begin; condition; step)


// for (int i = 0; i < 10; i++)
//      Console.Write($"{i} ");

// Console.WriteLine();


// for (int i = 10; i > 0; i--)
//      Console.Write($"{i} ");

// Console.WriteLine();


// for (int i = 0; i < 10; i+=2)
//      Console.Write($"{i} ");

// Console.WriteLine();

Console.Clear();
Console.Write("Введите число :");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(n * n);

// Первая задача
        Console.Clear();
        Console.Write("Введите число 1: ");
        int n1 = int.Parse(Console.ReadLine()!);

        Console.Write("Введите число 2: ");
        int n2 = int.Parse(Console.ReadLine()!);

        if (n1 == n2 * n2)
            Console.WriteLine("Да");
        else
            Console.WriteLine("Нет");
        
    // Конец первой задачию
    // У У У У У ррр ррр р р Я Я Я Я 
    
   // Вторая задача 
    Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n == 0)
Console.WriteLine("Нет такого дня нелели");
List<string>week = new List<string>(){" ","Понедельник","Вторник","Среда","Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine(week[n]);


////////////////////////////

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
while ( n < 0 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите номер дня недели: ");
    n = int.Parse(Console.ReadLine()!);
}
if (n == 0)
    Console.WriteLine("Нет такого дня нелели");
List<string>week = new List<string>(){" ","Понедельник","Вторник","Среда","Четверг", "Пятница", "Суббота", "Воскресенье"};
    Console.WriteLine(week[n]);

    // Конец второй задачке.
    
    //////////////
    
    
    Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
    
for (int i = (-1) * n; i <= n; i++)
   Console.Write($"{i}, ");
    
    
    
    
