using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Entity;

public class Ogretmen:CommonProp
{
    [Key]
    public int? OgretmenId { get; set; }
    public virtual ICollection<DersProgrami> DersProgramlari { get; set; }
}