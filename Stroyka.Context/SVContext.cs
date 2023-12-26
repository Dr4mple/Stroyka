using Svyaznoi.Context.Contracts.Models;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Svyaznoi.Context
{
    public class SVContext : IContext
    {
        private ICollection<Zakazhik> zakazhiks;
        private ICollection<Rabotnik>  rabotniks;
        private ICollection<Rabota> rabotas;
        private ICollection<Material> materials;

        public SVContext()
        {
            zakazhiks = new HashSet<Zakazhik>();
            rabotniks = new HashSet<Rabotnik>();
            rabotas = new HashSet<Rabota>();
            materials = new HashSet<Material>();
            Seed();
        }

        public ICollection<Zakazhik> Zakazhik => zakazhiks;

        public ICollection<Rabotnik> Rabotnik => rabotniks;

        public ICollection<Rabota> Rabota => rabotas;

        public ICollection<Material> Material => materials;

        void IContext.SaveChanges()
        {
            throw new NotImplementedException();
        }

        private void Seed()
        {
            Zakazhik.Add(new Zakazhik
            {
                Id = Guid.NewGuid(),
                Name = "Андрей",
                Address = "Санкт-Петербург, ул. Тореза 47",
                Telefon = 324324,
            });

            Zakazhik.Add(new Zakazhik
            {
                Id = Guid.NewGuid(),
                Name = "Рома",
                Address = "Санкт-Петербург, ул. Коменда 59",
                Telefon = 234325,
            });
            Zakazhik.Add(new Zakazhik
            {
                Id = Guid.NewGuid(),
                Name = "Максим",
                Address = "Санкт-Петербург, ул.  Тореза 47",
                Telefon = 234325,
            });
            Rabotnik.Add(new Rabotnik
            {
                Id = Guid.NewGuid(),
                Name = "Равшан",
                Adres = "Санкт-Петербург, ул. Коменда 59",
                Index = 234325,
                Number = 213432,
                Email = "anderorinchuk232@mail.ru"
            });
            Rabotnik.Add(new Rabotnik
            {
                Id = Guid.NewGuid(),
                Name = "Мухамбек",
                Adres = "Санкт-Петербург, ул.Тореза 47",
                Index = 234325,
                Number = 213432,
                Email = "anderorinchuk232@mail.ru"
            });

            Rabota.Add(new Rabota
            {
                Id = Guid.NewGuid(),
                Name = "Штукатурка стен",
                Ispolnitel = "Мухамбек",
                Price = 100000,

            });
            Rabota.Add(new Rabota
            {
                Id = Guid.NewGuid(),
                Name = "Покраска стен",
                Ispolnitel = "Равшан",
                Price = 22000,

            });
            Material.Add(new Material
            {
                Id = Guid.NewGuid(),
                Name = "Краска",
                Edizmer = 10,
                Value = 11,
                Price = 10000,
            });
            Material.Add(new Material
            {
                Id = Guid.NewGuid(),
                Name = "Шпаклевка",
                Edizmer = 20,
                Value = 19,
                Price = 20000,
            });





        }
    }
}
