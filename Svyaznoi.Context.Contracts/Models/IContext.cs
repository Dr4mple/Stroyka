using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svyaznoi.Context.Contracts.Models
{
    public interface IContext
    {

        ICollection<Zakazhik> Zakazhik { get; }

        ICollection<Rabotnik> Rabotnik { get; }

        ICollection<Rabota> Rabota { get; }

        ICollection<Material> Material { get; }

        void SaveChanges();
    }
}
