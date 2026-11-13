using System.Collections.Generic;
using Variant04.Core.Models;

namespace Variant04.Core.Services;

public interface IEquipmentSearchService
{
    IEnumerable<EquipmentCard> Search(IEnumerable<EquipmentCard> equipment, string query);
}