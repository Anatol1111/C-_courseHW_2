//Задача 4: Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

void Aweek()
{
    Console.Write("Введите день недели ");
    int Number = int.Parse(Console.ReadLine());
    int Saturday = 6;
    int Sunday = 7;
    if (Number == Saturday)
    {
       Console.WriteLine("Выходной");
    }
   else if (Number == Sunday)
    {
       Console.WriteLine("Выходной");
    }
    else 
    {
       Console.WriteLine("Этот день не выходной"); 
    }
}
Aweek();

