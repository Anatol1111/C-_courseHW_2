//Задача 3: Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет.


void functionNum()
{
Console.Write("Введите число ");
string Number = (Console.ReadLine()).ToString();

    char[] c = Number.ToCharArray();
if (c.Length > 2)
{
   
   Console.WriteLine(c[2]); 
}
else
{
    Console.WriteLine($"{Number} --> Третьей цифры нет");
}
}

functionNum();