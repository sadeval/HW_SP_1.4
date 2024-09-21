using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Выберите приложение для запуска:");
            Console.WriteLine("1. Блокнот");
            Console.WriteLine("2. Калькулятор");
            Console.WriteLine("3. Paint");
            Console.WriteLine("4. Запустить собственное приложение");
            Console.WriteLine("5. Выход");
            Console.Write("Ваш выбор: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StartApplication("notepad.exe");
                    break;
                case "2":
                    StartApplication("calc.exe");
                    break;
                case "3":
                    StartApplication("mspaint.exe");
                    break;
                case "4":
                    Console.Write("Введите путь к вашему приложению: ");
                    string? appPath = Console.ReadLine();
                    StartApplication(appPath);
                    break;
                case "5":
                    return; 
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }

    static void StartApplication(string appPath)
    {
        try
        {
            Process process = new Process();
            process.StartInfo.FileName = appPath;
            process.Start();
            Console.WriteLine($"Запущено приложение: {appPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при запуске приложения: {ex.Message}");
        }
    }
}
