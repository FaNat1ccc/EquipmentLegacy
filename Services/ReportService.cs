// TODO 9: Добавить асинхронное сохранение отчёта.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Variant04.Core.Services;

public class ReportService
{
    public async Task SaveReportAsync(string filePath, IEnumerable<string> reportData)
    {
        var content = new StringBuilder();
        foreach (var line in reportData)
        {
            content.AppendLine(line);
        }

        await File.WriteAllTextAsync(filePath, content.ToString(), Encoding.UTF8);
    }
}