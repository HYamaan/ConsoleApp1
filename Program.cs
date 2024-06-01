using System;
using ConsoleApp1.Crud.Mudur;
using ConsoleApp1.Entity;
using ConsoleApp1.Helper;

class Program
{
    static void Main(string[] args)
    {
        ICrudMudurOperation crudOperations = new CrudMudurOperation();

        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Ekle Mudur");
            Console.WriteLine("2. Listele Mudurlar");
            Console.WriteLine("3. Goruntule Mudur");
            Console.WriteLine("4. Sil Mudur");
            Console.WriteLine("5. Ekle Ders");
            Console.WriteLine("6. Listele Dersler");
            Console.WriteLine("7. Goruntule Ders");
            Console.WriteLine("8. Sil Ders");
            Console.WriteLine("9. Ekle Ders Programi");
            Console.WriteLine("10. Listele Ders Programlari");
            Console.WriteLine("11. Goruntule Ders Programi");
            Console.WriteLine("12. Sil Ders Programi");
            Console.WriteLine("13. Exit");
            Console.WriteLine("----------------- \n ");

            int choice = ValidChoiceHelper.GetValidChoice();

            switch (choice)
            {
                case 1:
                    Mudur mudur = new Mudur();
                    Console.Write("Mudur Ad: ");
                    mudur.Ad = Console.ReadLine();
                    Console.Write("Mudur Soyad: ");
                    mudur.Soyad = Console.ReadLine();
                    Console.Write("Mudur Email: ");
                    mudur.Email = Console.ReadLine();
                    Console.Write("Mudur Sifre: ");
                    mudur.Sifre = Console.ReadLine();
                    crudOperations.EkleMudur(mudur);
                    break;
                case 2:
                    crudOperations.ListeleMudurler();
                    break;
                case 3:
                    Console.Write("Goruntulemek Icin Mudur Id: ");
                    int goruntuleMudurId = ValidChoiceHelper.GetValidId();
                    crudOperations.GoruntuleMudur(goruntuleMudurId);
                    break;
                case 4:
                    Console.Write("Silmek Icin Mudur Id: ");
                    int silMudurId = ValidChoiceHelper.GetValidId();
                    crudOperations.SilMudur(silMudurId);
                    break;
                case 5:
                    Ders ders = new Ders();
                    Console.Write("Ders Adi: ");
                    ders.DersAdi = Console.ReadLine();
                    crudOperations.EkleDers(ders);
                    break;
                case 6:
                    crudOperations.ListeleDersler();
                    break;
                case 7:
                    Console.Write("Goruntulemek Icin Ders Id: ");
                    int goruntuleDersId = ValidChoiceHelper.GetValidId();
                    crudOperations.GoruntuleDers(goruntuleDersId);
                    break;
                case 8:
                    Console.Write("Silmek Icin Ders Id: ");
                    int silDersId = ValidChoiceHelper.GetValidId();
                    crudOperations.SilDers(silDersId);
                    break;
                case 9:
                    DersProgrami dersProgrami = new DersProgrami();
                    Console.Write("Ders Id: ");
                    dersProgrami.DersId = ValidChoiceHelper.GetValidId();
                    Console.Write("Gun: ");
                    dersProgrami.Gun = Console.ReadLine();
                    Console.Write("Saat: ");
                    dersProgrami.Saat = Console.ReadLine();
                    Console.Write("Sinif: ");
                    dersProgrami.Sinif = Console.ReadLine();
                    crudOperations.EkleDersProgrami(dersProgrami);
                    break;
                case 10:
                    crudOperations.ListeleDersProgramlari();
                    break;
                case 11:
                    Console.Write("Goruntulemek Icin Ders Programi Id: ");
                    int goruntuleDersProgramiId = ValidChoiceHelper.GetValidId();
                    crudOperations.GoruntuleDersProgrami(goruntuleDersProgramiId);
                    break;
                case 12:
                    Console.Write("Silmek Icin Ders Programi Id: ");
                    int silDersProgramiId = ValidChoiceHelper.GetValidId();
                    crudOperations.SilDersProgrami(silDersProgramiId);
                    break;
                case 13:
                    return;
                default:
                    Console.WriteLine("Gecersiz Secim.");
                    break;
            }
        }
    }
}
