//Задача 3: Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет.


void functionNum()
{
    Console.Write("Введите число ");
    string Number = (Console.ReadLine()).ToString();
    char[] Array = Number.ToCharArray();
    if (Array.Length > 2)
    {
    Console.WriteLine(Array[2]); 
    }
    else
    {
    Console.WriteLine($"{Number} --> Третьей цифры нет");
 }

functionNum();