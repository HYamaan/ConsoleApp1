using ConsoleApp1.Entity;
using ConsoleApp1.Enum;

namespace ConsoleApp1.Crud.Mudur;

public class CrudMudurOperation:ICrudMudurOperation
{
    private CrudMudur crudMudur = new CrudMudur();
    private Role currentUserRole = Role.Mudur;
    public void EkleMudur(Entity.Mudur mudur)
    {
        crudMudur.Ekle(mudur, currentUserRole);
        Console.WriteLine("Müdür başarıyla eklendi.");
    }

    public void SilMudur(int mudurId)
    {
        var mudur = crudMudur.Goruntule(mudurId, currentUserRole);
        if (mudur != null)
        {
            crudMudur.Sil(mudur, currentUserRole);
            Console.WriteLine("Müdür başarıyla silindi.");
        }
    }

    public void GoruntuleMudur(int mudurId)
    {
        var mudur = crudMudur.Goruntule(mudurId, currentUserRole);
        if (mudur != null)
            Console.WriteLine($"Müdür: {mudur.Ad} {mudur.Soyad}");
        else
            Console.WriteLine("Müdür bulunamadı.");
    }

    public void ListeleMudurler()
    {
        var mudurler = crudMudur.Listele(currentUserRole);
        foreach (var mudur in mudurler)
            Console.WriteLine($"Müdür: {mudur.MudurId} {mudur.Ad} {mudur.Soyad}");
    }

    public void EkleDers(Ders ders)
    {
        crudMudur.DersEkle(ders, currentUserRole);
        Console.WriteLine("Ders başarıyla eklendi.");
    }

    public void SilDers(int dersId)
    {
        var ders = crudMudur.DersGoruntule(dersId, currentUserRole);
        if (ders != null)
        {
            crudMudur.DersSil(ders, currentUserRole);
            Console.WriteLine("Ders başarıyla silindi.");
        }
    }

    public void GoruntuleDers(int dersId)
    {
        var ders = crudMudur.DersGoruntule(dersId, currentUserRole);
        if (ders != null)
            Console.WriteLine($"Ders: {ders.DersAdi}");
        else
            Console.WriteLine("Ders bulunamadı.");
    }

    public void ListeleDersler()
    {
        var dersler = crudMudur.DersleriListele(currentUserRole);
        foreach (var ders in dersler)
            Console.WriteLine($"Ders:{ders.DersId} {ders.DersAdi}");
    }

    public void EkleDersProgrami(DersProgrami dersProgrami)
    {
        crudMudur.DersProgramiEkle(dersProgrami, currentUserRole);
        Console.WriteLine("Ders Programı başarıyla eklendi.");
    }

    public void SilDersProgrami(int dersProgramiId)
    {
        var dersProgrami = crudMudur.DersProgramiGoruntule(dersProgramiId, currentUserRole);
        if (dersProgrami != null)
        {
            crudMudur.DersProgramiSil(dersProgrami, currentUserRole);
            Console.WriteLine("Ders Programı başarıyla silindi.");
        }
    }

    public void GoruntuleDersProgrami(int dersProgramiId)
    {
        var dersProgrami = crudMudur.DersProgramiGoruntule(dersProgramiId, currentUserRole);
        if (dersProgrami != null)
            Console.WriteLine($"Ders Programı: {dersProgrami.Gun} {dersProgrami.Saat} Sınıf {dersProgrami.Sinif}");
        else
            Console.WriteLine("Ders Programı bulunamadı.");
    }

    public void ListeleDersProgramlari()
    {
        var dersProgramlari = crudMudur.DersProgramlariListele(currentUserRole);
        foreach (var dp in dersProgramlari)
            Console.WriteLine($"Ders Programı:{dp.DersProgramiId} {dp.Gun} {dp.Saat} Sınıf {dp.Sinif}");
    }
}