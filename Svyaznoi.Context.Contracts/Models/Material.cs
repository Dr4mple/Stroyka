using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Svyaznoi.Context.Contracts.Models
{
    public class Material : BaseEntyty
    {
        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Единица измерения
        /// </summary>
        public int Edizmer { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Value { get; set; }
        

        public int Price { get; set; }
    }
}
