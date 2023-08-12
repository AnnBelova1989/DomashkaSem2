int VvodChisla(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

bool Correct(int day)
{
    if (day > 0 && day < 8)
    {
        return true;
    }
    System.Console.WriteLine("no correct");
    return false;
}

bool Vyhodnoy(int day)
{
    return (day > 5);
}

int day = VvodChisla("vvedi: ");

if (Correct(day))
{
    if (Vyhodnoy(day))
    {
        System.Console.WriteLine("yes");
    }
    else
    {
        System.Console.WriteLine("no");
    }
}


/*
int day= VvodChisla("Введите день недели: ");
if(day==6 || day==7)
{
    System.Console.WriteLine("yes");
}
else if(day>0 && day<6)
{
    System.Console.WriteLine("no");
}
else
{
System.Console.WriteLine("Такого дня не существует ");
}
*/