int VvodChisla(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
bool result(int num)
{
    return num < 1000 && num > 99;
}

int number = VvodChisla("Введите трехзначное число: ");
bool Result = result(number);
string Itog = Result ? $"Второй цифрой числa {number} является {number / 10 % 10}" : "Введите еще раз трехзначное число: ";
System.Console.WriteLine(Itog);

