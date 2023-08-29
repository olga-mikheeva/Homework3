// напишите программу которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool ValidNumber(int number)
{
    if (number < 10000 || number >= 100000)
    {
        Console.WriteLine("Вы ввели не пятизначное число, попробуйте еще раз");
        return false;
    }
    else
    {
        return true;
    }
}


string CompareDigit(int number)
{
    int firstDigit = number / 10000;
    int secondDigit = (number / 1000) % 10;
    int fourDigit = (number / 10) % 10;
    int fiveDigit = number % 10;

    if (firstDigit == fiveDigit && secondDigit == fourDigit)
    {
        return "да";
    }
    else
    {
        return "нет";
    }
}


int number = InputNum("Введите пятизначное число: ");
if (ValidNumber(number))
{
    Console.WriteLine(CompareDigit(number));
}
