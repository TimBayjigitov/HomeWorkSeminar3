// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool FindPolindrom(int n)
{
    if(n/10000 == n%10 && (n/1000)%10 == (n%100)/10)
    return true;
    else
    return false;
}
Console.WriteLine("Input five-digit number: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"is it polindrome? = {FindPolindrom(N)}");
