// TODO 3: Создать Adapter для старого формата карточки оборудования.
using Variant04.Core.Models;

namespace Variant04.Core.Services;

public class LegacyEquipmentAdapter : IEquipmentAdapter
{
    public EquipmentCard Adapt(LegacyEquipmentCard legacyCard)
    {
        return new EquipmentCard
        {
            Name = legacyCard.ItemName,
            Quantity = legacyCard.Qty,
            InventoryNumber = legacyCard.InvNumber
        };
    }
}