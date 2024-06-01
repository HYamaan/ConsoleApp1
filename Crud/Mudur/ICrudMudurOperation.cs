using ConsoleApp1.Entity;

namespace ConsoleApp1.Crud.Mudur;

public interface ICrudMudurOperation
{
    void EkleMudur(Entity.Mudur mudur);
    void SilMudur(int mudurId);
    void GoruntuleMudur(int mudurId);
    void ListeleMudurler();

    void EkleDers(Ders ders);
    void SilDers(int dersId);
    void GoruntuleDers(int dersId);
    void ListeleDersler();

    void EkleDersProgrami(DersProgrami dersProgrami);
    void SilDersProgrami(int dersProgramiId);
    void GoruntuleDersProgrami(int dersProgramiId);
    void ListeleDersProgramlari();
}