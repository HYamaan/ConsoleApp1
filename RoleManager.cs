using ConsoleApp1.Enum;

namespace ConsoleApp1;

public class RoleManager
{
    internal static bool YetkiKontrolu(Role role, string islem)
    {
        var yetkiler = new Dictionary<Role, List<string>>
        {
            { Role.Ogrenci, new List<string> { "NotlariniGorme", "DersPrograminiGorme" } },
            { Role.Ogretmen, new List<string> { "NotEkleme", "NotSilme", "NotlariniGorme", "DersPrograminiGorme", "OgrenciEkleme", "OgrenciSilme" } },
            { Role.Mudur, new List<string> { "NotlariniGorme", "DersPrograminiGorme", "OgretmenEkleme", "OgretmenSilme", "OgrenciEkleme", "OgrenciSilme", "DersEkleme", "DersSilme" } }
        };

        return yetkiler.ContainsKey(role) && yetkiler[role].Contains(islem);
    }

}