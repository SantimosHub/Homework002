// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.int.Parse(Console.ReadLine())


int num = 0;

while (num < 1 || num > 7)
{
    Console.WriteLine("Введите цифру дня недели от 1 до 7:");
    num = Convert.ToInt32(Console.ReadLine());
}
if ((num > 5))
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будний день");
}