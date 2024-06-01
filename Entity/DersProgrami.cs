using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Entity;

public class DersProgrami
{
    [Key]
    public int? DersProgramiId { get; set; }
    public int DersId { get; set; }
    public virtual Ders Ders { get; set; }
    public string Gun { get; set; }
    public string Saat { get; set; }
    public string Sinif { get; set; }
    public virtual ICollection<OgrenciDersProgrami> OgrenciDersProgramlari { get; set; }
    public virtual ICollection<Ogretmen> Ogretmenler { get; set; }
}