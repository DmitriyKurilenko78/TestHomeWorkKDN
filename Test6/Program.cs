// Задача 13: Напишите программу, которая выводит третью  цифру заданного числа или сообщает, 
//            что третьей цифры нет.  
//            645 -> 5
//            78 -> третьей цифры нет
//            32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n >= 1 && n < 100)

    Console.WriteLine("Третьей цифры нет");
   
else if (n >= 100 && n < 999)
         Console.WriteLine(n % 10); 
else if (n >= 1000 && n < 9999)
         Console.WriteLine(n / 10 % 10); 
else
    Console.WriteLine(n / 100 % 10);
    
    ///////////////////
    
    Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
string str = number.ToString();
Console.WriteLine(str[2]);


/////////////////////////


// Задача 15: Напишите программу, которая принимает на вход цифру, 
//            обозначающую день недели, и проверяет, является ли этот день выходным.
//            6 -> да
//            7 -> да
//            1 -> нет
Console.Clear();
Console.Write("Введите число соответствующее дню недели: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1 || n > 7)
{
      Console.WriteLine("Не верное число\nВведите число: ");
          n = int.Parse(Console.ReadLine()!);  
}
if (n >= 1 && n <= 5)
    Console.Write("Нет");
else 
    Console.Write("Да");    
