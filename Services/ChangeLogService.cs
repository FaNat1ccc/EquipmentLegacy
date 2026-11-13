// TODO 8: Добавить журнал изменений.
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Variant04.Core.Services;

public class ChangeLogService
{
    private readonly ConcurrentQueue<string> _log = new();

    public void Log(string action)
    {
        _log.Enqueue($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {action}");
    }

    public IEnumerable<string> GetLog()
    {
        return _log.ToArray();
    }
}