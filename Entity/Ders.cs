using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entity;

public class Ders
{
    [Key]
    public int? DersId { get; set; }
    public string DersAdi { get; set; }
    public virtual ICollection<DersProgrami> DersProgramlari { get; set; }
    public virtual ICollection<Not> Notlar { get; set; }
}
