using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Entity;

public class Not
{
    [Key]
    public int? NotId { get; set; }
    public int Vize { get; set; }
    public int Final { get; set; }
    public int But => Final < 30 ? 1 : 0; // Bütünleme sınavı yapılması gerekiyor.
    public int Ortalama => (int)(Vize * 0.4 + Final * 0.6);
    public int OgrenciId { get; set; }
    public int DersId { get; set; }
    public virtual Ogrenci Ogrenci { get; set; }
    public virtual Ders Ders { get; set; }
}