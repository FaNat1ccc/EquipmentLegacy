// TODO 1: Проанализировать стартовый legacy-код и найти три дефекта.
using System;

namespace Variant04.Core.Services;

public static class LegacyDefectAnalyzer
{
    public static void PrintDefects()
    {
        Console.WriteLine("Найденные дефекты в legacy-коде:");
        Console.WriteLine("1. Пустые блоки catch, проглатывающие исключения.");
        Console.WriteLine("2. Использование .Result или .Wait(), блокирующее UI-поток.");
        Console.WriteLine("3. Небезопасное изменение общего состояния (например, count++) без lock или Interlocked.");
    }
}