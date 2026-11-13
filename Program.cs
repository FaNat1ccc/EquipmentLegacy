using System;
using System.Threading.Tasks;
using Variant04.Core.Services;

namespace Variant04;

internal static class Program
{
    private static async Task Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Зачётный проект 04: Модернизация учёта оборудования");
        Console.WriteLine(new string('=', 64));

        LegacyDefectAnalyzer.PrintDefects();
        Console.WriteLine(new string('-', 64));

        var service = new ProjectService();
        await service.RunAsync();

        Console.WriteLine();
        Console.WriteLine("Нажмите Enter для завершения.");
        Console.ReadLine();
    }
}