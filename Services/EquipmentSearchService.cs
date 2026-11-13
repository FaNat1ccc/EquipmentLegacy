// TODO 2: Вынести повторяющуюся логику поиска в отдельный сервис.
using System.Collections.Generic;
using System.Linq;
using Variant04.Core.Models;

namespace Variant04.Core.Services;

public class EquipmentSearchService : IEquipmentSearchService
{
    public IEnumerable<EquipmentCard> Search(IEnumerable<EquipmentCard> equipment, string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return equipment;

        return equipment.Where(e =>
            e.Name.Contains(query, System.StringComparison.OrdinalIgnoreCase) ||
            e.InventoryNumber.Contains(query, System.StringComparison.OrdinalIgnoreCase));
    }
}