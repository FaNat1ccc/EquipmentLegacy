using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading.Channels;

namespace Variant04;

internal static class Program
{
    private static async Task Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Зачётный проект 04: Модернизация учёта оборудования");
        Console.WriteLine(new string('=', 64));

        // Стартовый сценарий нужен для проверки структуры проекта.
        // Реализацию индивидуальных требований выполняйте в ProjectService.
        var service = new ProjectService();
        await service.RunAsync();

        Console.WriteLine();
        Console.WriteLine("Нажмите Enter для завершения.");
        Console.ReadLine();
    }
}

public sealed class ProjectService
{
    public async Task RunAsync()
    {
        // TODO: перенесите предметную логику в отдельные методы и классы.
        // TODO: не размещайте весь проект в Main.
        // TODO 1: Проанализировать стартовый legacy-код и найти три дефекта.
        // TODO 2: Вынести повторяющуюся логику поиска в отдельный сервис.
        // TODO 3: Создать Adapter для старого формата карточки оборудования.
        // TODO 4: Добавить фильтрацию оборудования через LINQ.
        // TODO 5: Реализовать безопасное изменение остатка при параллельных операциях.
        // TODO 6: Сохранять выбранный фильтр и тему интерфейса в HKCU.
        // TODO 7: Вынести модель и сервис в Class Library.

        // TODO 8: Добавить журнал изменений.
        // TODO 9: Добавить асинхронное сохранение отчёта.
        // TODO 10: Добавить номер версии схемы настроек.

        Console.WriteLine("Стартовый проект собран. Реализуйте задания варианта.");
        await Task.CompletedTask;
    }
}
