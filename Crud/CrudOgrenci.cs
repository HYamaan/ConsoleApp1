using ConsoleApp1.Entity;
using ConsoleApp1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Crud
{
    public class CrudOgrenci : ICrud<Ogrenci>
    {
        private List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public void Ekle(Ogrenci entity, Role role)
        {
            if (RoleManager.YetkiKontrolu(role, "OgrenciEkleme"))
            {
                ogrenciler.Add(entity);
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }

        public void Sil(Ogrenci entity, Role role)
        {
            if (RoleManager.YetkiKontrolu(role, "OgrenciSilme"))
            {
                ogrenciler.Remove(entity);
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }

        public Ogrenci Goruntule(int id, Role role)
        {
            if (RoleManager.YetkiKontrolu(role, "OgrenciGorme"))
            {
                return ogrenciler.FirstOrDefault(o => o.OgrenciId == id);
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }

        public IEnumerable<Ogrenci> Listele(Role role)
        {
            if (RoleManager.YetkiKontrolu(role, "OgrenciListeleme"))
            {
                return ogrenciler;
            }
            else
            {
                throw new UnauthorizedAccessException("Bu işlem için yetkiniz yok.");
            }
        }
    }
}