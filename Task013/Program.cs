// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string number_str = Convert.ToString(number);
if (number_str.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(number_str[2]);
}