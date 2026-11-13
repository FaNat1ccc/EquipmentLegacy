using Variant04.Core.Models;

namespace Variant04.Core.Services;

public interface IEquipmentAdapter
{
    EquipmentCard Adapt(LegacyEquipmentCard legacyCard);
}