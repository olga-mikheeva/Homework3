// напишите программу которая принимает на вход число (N) и выдает таблицу кубов числе от 1 до N
// 3 -> 1, 8, 27
// 5 -> 1, 8. 27, 64, 125

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string SquaresFrom1ToNum(int num)
{
    int count = 1;
    string res = "";
    while (count <= num)
    {
        res += $"{Math.Pow(count, 3)}";
        if (count < num) 
            res += ", ";
        else 
            res += ".";
        count++;
    }
    return res;
}

int number = InputNum("Введите число: ");
System.Console.WriteLine(SquaresFrom1ToNum(number));

