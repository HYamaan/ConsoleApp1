using ConsoleApp1.Entity;
using ConsoleApp1.Enum;

namespace ConsoleApp1.Crud
{
    public class CrudMudur : ICrud<Entity.Mudur>
    {
        private OkulContext context = new OkulContext();

        public void Ekle(Entity.Mudur entity, Role role)
        {
            if (role == Role.Mudur)
            {
                context.Mudurler.Add(entity);
                context.SaveChanges();  
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }

        public void Sil(Entity.Mudur entity, Role role)
        {
            if (role == Role.Mudur)
            {
                context.Mudurler.Remove(entity);
                context.SaveChanges();  // Veritabanında değişiklikleri kaydet
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }

        public Entity.Mudur Goruntule(int id, Role role)
        {
            if (role == Role.Mudur)
            {
                return context.Mudurler.FirstOrDefault(m => m.MudurId == id);
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }

        public IEnumerable<Entity.Mudur> Listele(Role role)
        {
            if (role == Role.Mudur)
            {
                return context.Mudurler.ToList();
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }


        public void DersProgramiEkle(DersProgrami dersProgrami, Role role)
        {
            if (role == Role.Mudur)
            {
                context.DersProgramlari.Add(dersProgrami);
                context.SaveChanges();  
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }

        public void DersProgramiSil(DersProgrami dersProgrami, Role role)
        {
            if (role == Role.Mudur)
            {
                context.DersProgramlari.Remove(dersProgrami);
                context.SaveChanges(); 
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }

        public DersProgrami DersProgramiGoruntule(int id, Role role)
        {
            if (role == Role.Mudur)
            {
                return context.DersProgramlari.FirstOrDefault(dp => dp.DersProgramiId == id);
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }

        public IEnumerable<DersProgrami> DersProgramlariListele(Role role)
        {
            if (role == Role.Mudur)
            {
                return context.DersProgramlari.ToList();
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }

        public void DersEkle(Ders ders, Role role)
        {
            if (role == Role.Mudur)
            {
                context.Dersler.Add(ders);
                context.SaveChanges();
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }

        public void DersSil(Ders ders, Role role)
        {
            if (role == Role.Mudur)
            {
                context.Dersler.Remove(ders);
                context.SaveChanges();
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }

        public Ders DersGoruntule(int id, Role role)
        {
            if (role == Role.Mudur)
            {
                return context.Dersler.FirstOrDefault(d => d.DersId == id);
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }

        public IEnumerable<Ders> DersleriListele(Role role)
        {
            if (role == Role.Mudur)
            {
                return context.Dersler.ToList();
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }


    }
}
