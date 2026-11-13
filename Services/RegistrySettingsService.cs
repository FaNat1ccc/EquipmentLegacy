// TODO 6: Сохранять выбранный фильтр и тему интерфейса в HKCU.
// TODO 10: Добавить номер версии схемы настроек.
using Microsoft.Win32;

namespace Variant04.Core.Services;

public class RegistrySettingsService
{
    private const string RegistryPath = @"Software\Variant04\EquipmentApp";
    private const int CurrentSchemaVersion = 1;

    public void SaveSettings(string filter, string theme)
    {
        using var key = Registry.CurrentUser.CreateSubKey(RegistryPath);
        key.SetValue("SchemaVersion", CurrentSchemaVersion);
        key.SetValue("LastFilter", filter);
        key.SetValue("Theme", theme);
    }

    public (int Version, string Filter, string Theme) LoadSettings()
    {
        using var key = Registry.CurrentUser.OpenSubKey(RegistryPath);
        if (key == null) return (0, "", "Light");

        return (
            (int)(key.GetValue("SchemaVersion", 0) ?? 0),
            key.GetValue("LastFilter", "")?.ToString() ?? "",
            key.GetValue("Theme", "Light")?.ToString() ?? "Light"
        );
    }
}