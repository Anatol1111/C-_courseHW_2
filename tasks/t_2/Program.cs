// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.

void ThreeNum()
{
    int randomnumber = new Random().Next(100, 1000);
    int firstNum = randomnumber / 100;
    int thirdNum = randomnumber % 10;  
    Console.WriteLine($"{randomnumber}-->{firstNum}{thirdNum}");
}

ThreeNum();