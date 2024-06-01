using ConsoleApp1.Enum;

namespace ConsoleApp1.Crud
{
    internal interface ICrud<T>
    {
        void Ekle(T entity, Role role);
        void Sil(T entity, Role role);
        T Goruntule(int id, Role role);
        IEnumerable<T> Listele(Role role);
    }
}