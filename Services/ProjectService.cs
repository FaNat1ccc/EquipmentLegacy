// TODO 7: Вынести модель и сервис в Class Library.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Variant04.Core.Models;

namespace Variant04.Core.Services;

public sealed class ProjectService
{
    public async Task RunAsync()
    {
        var adapter = new LegacyEquipmentAdapter();
        var searchService = new EquipmentSearchService();
        var inventory = new EquipmentInventory();
        var settingsService = new RegistrySettingsService();
        var changeLog = new ChangeLogService();
        var reportService = new ReportService();

        var legacyData = new List<LegacyEquipmentCard>
        {
            new() { ItemName = "Ноутбук", Qty = 5, InvNumber = "INV-001" },
            new() { ItemName = "Монитор", Qty = 10, InvNumber = "INV-002" }
        };

        var equipment = legacyData.Select(adapter.Adapt).ToList();

        inventory.Add("INV-001", 5);
        changeLog.Log("Добавлено 5 ед. INV-001");

        inventory.Add("INV-001", 3);
        changeLog.Log("Добавлено 3 ед. INV-001");

        Console.WriteLine($"Остаток INV-001: {inventory.GetQuantity("INV-001")}");

        var filtered = searchService.Search(equipment, "Ноутбук").ToList();
        Console.WriteLine($"Найдено через LINQ: {filtered.Count}");

        settingsService.SaveSettings("Ноутбук", "Dark");
        var loaded = settingsService.LoadSettings();
        Console.WriteLine($"Загружены настройки: Версия={loaded.Version}, Фильтр={loaded.Filter}, Тема={loaded.Theme}");

        await reportService.SaveReportAsync("report.txt", changeLog.GetLog());
        Console.WriteLine("Отчёт асинхронно сохранён в report.txt");
    }
}