//Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.
int num = int.Parse(Console.ReadLine());

int TakeNum(int num)
{
    return (num / 10) % 10;
}
Console.WriteLine(TakeNum(num));
