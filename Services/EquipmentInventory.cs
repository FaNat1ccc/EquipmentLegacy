// TODO 5: Реализовать безопасное изменение остатка при параллельных операциях.
using System.Collections.Generic;

namespace Variant04.Core.Services;

public class EquipmentInventory
{
    private readonly Dictionary<string, int> _stock = new();
    private readonly object _lock = new();

    public void Add(string inventoryNumber, int quantity)
    {
        lock (_lock)
        {
            if (_stock.ContainsKey(inventoryNumber))
                _stock[inventoryNumber] += quantity;
            else
                _stock[inventoryNumber] = quantity;
        }
    }

    public int GetQuantity(string inventoryNumber)
    {
        lock (_lock)
        {
            return _stock.TryGetValue(inventoryNumber, out int qty) ? qty : 0;
        }
    }
}