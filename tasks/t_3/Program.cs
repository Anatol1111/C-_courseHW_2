//Задача 3: Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет.


void functionNum()
{
Console.Write("Введите число ");
int Number = int.Parse(Console.ReadLine());
if (Number >= 100)
{
    Console.WriteLine(Number % 10);
}
else
{
    Console.WriteLine($"{Number} --> Третьей цифры нет");
}
}

functionNum();