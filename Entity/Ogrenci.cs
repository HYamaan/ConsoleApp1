using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ConsoleApp1.Entity;

public class Ogrenci : CommonProp
{
    [Key] public int? OgrenciId { get; set; }
    public virtual ICollection<Not> Notlar { get; set; }
    public virtual ICollection<OgrenciDersProgrami> OgrenciDersProgramlari { get; set; }
}