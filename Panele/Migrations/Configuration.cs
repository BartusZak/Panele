namespace Panele.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Panele.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<Panele.DAL.ShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Panele.DAL.ShopContext context)
        {

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.RateValues.AddOrUpdate(x => x.Id, new RateValue(1,0,0,0,0,0,50));
            context.Products.AddOrUpdate(x => x.Id,
             new Product(1, "Fote", "Kinewood", 365.99, DateTime.Now, "Posiadany","Salon",3.4,23,32,34,32,34,"Niebieski","sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad","Polietylen"),
             new Product(2, "Sofa", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(3, "Krzes³o", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(4, "Stó³", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(5, "Pufa", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(6, "Kanapa", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(7, "£ó¿ko", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(8, "Kanapa du¿a", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(9, "Biórko", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(10, "Obraz œcienny", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(11, "Wira¿", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(12, "Stó³ wielki", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(13, "Biurko ma³e", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(14, "Biurko œrednie", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(15, "Fotel du¿y", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(16, "Kanapa wielka", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(17, "Stó³ ogromny", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(18, "Obraz œcienny", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(19, "Sztuæce", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(20, "Jajko", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(21, "Proszek", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(22, "Wal", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(23, "ZUZEL", "Kinewood", 365.99, DateTime.Now, "Posiadany", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen"),
             new Product(24, "ELO", "Kinewood", 365.99, DateTime.Now, "Brak", "Salon", 3.4, 23, 32, 34, 32, 34, "Niebieski", "sadsadasd" +
             "asdsadsadadd" +
             "asadadsadadsadsadsadsadadsadaddadadadsadsadsadasdsadad", "Polietylen")
         );
        }
    }
}
