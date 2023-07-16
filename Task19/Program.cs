// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("Введите пятизначное число и я прверю, является ли оно полиндромом");
int number = Convert.ToInt32(Console.ReadLine());

bool num = TestPalindrome(number);
Console.WriteLine(num ? "Да" : "Нет");


bool TestPalindrome (int num) 
{
    int firstDigit = num / 10000;
    int secondDigit = num / 1000 % 10;
    int thirdDigit = num / 100 % 10;
    int fourthDigit = num /10 % 10;
    int fifthDigit = num % 10; 

    if ((firstDigit) == (fifthDigit) && (secondDigit) == (fourthDigit)) return true;
    return false;
}
