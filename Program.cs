/*Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
string str = num.ToString();
if (str[0] == str[4] & str[1] == str[3])
{
    Console.WriteLine("Да");
} 
else Console.WriteLine("нет");
