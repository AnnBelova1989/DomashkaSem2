int VvodChisla(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
bool Multi(int num)
{
    return num > 99 && num < 1000;
}

int Number = VvodChisla("Введите трехзначное число: ");

while (Number > 999)
{
    Number = Number / 10;
}

bool Result = Multi(Number);
string Itog = Result ? $"Третья цифра заданного числа {Number % 10}" : "Третьей цифры не существует";
System.Console.WriteLine(Itog);


/*
if (Number < 100)
{
    System.Console.WriteLine("третьей цифры не существует ");
}
else if (Number > 99 && Number < 1000)
{
    System.Console.WriteLine($"Третья цифра заданного числа {Number % 10}");
}
else if (Number > 999)
{
    while (Number >= 999)
    {
        Number = Number / 10;
    }
    System.Console.WriteLine($"Третья цифра заданного числа {Number % 10}");
}
*/