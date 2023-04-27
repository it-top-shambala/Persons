namespace Persons;

public static class ConsoleHelper
{
    private static void PrintMessage(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    
    public static void PrintError(string message)
    {
        PrintMessage(message, ConsoleColor.Red);
    }
    public static void PrintPerson(Person person)
    {
        PrintMessage(person.GetFullName(), ConsoleColor.Blue);
    }
    public static void PrintInfo(string message)
    {
        PrintMessage(message, ConsoleColor.Gray);
    }

    public static void PrintMenu()
    {
        PrintMessage("==== M E N U ====", ConsoleColor.Yellow);
        PrintMessage("== 1. Добавить ==", ConsoleColor.Yellow);
        PrintMessage("== 2. Показать всех ==", ConsoleColor.Yellow);
        PrintMessage("== 3. Найти по имени ==", ConsoleColor.Yellow);
        PrintMessage("== 0. Выйти ==", ConsoleColor.Yellow);
        PrintMessage("==== = = = = ====", ConsoleColor.Yellow);
    }

    public static string Input(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write($"{message} : ");
        Console.ResetColor();
        return Console.ReadLine();
    }
}