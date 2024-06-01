namespace ConsoleApp1.Entity;

public class OgrenciDersProgrami
{
    public int OgrenciId { get; set; }
    public virtual Ogrenci Ogrenci { get; set; }

    public int DersProgramiId { get; set; }
    public virtual DersProgrami DersProgrami { get; set; }
}
