using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svyaznoi.Context.Contracts.Models
{
    public class Rabota : BaseEntyty
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// ИНН
        /// </summary>
        public string Ispolnitel { get; set; }

        /// <summary>
        /// Индекс
        /// </summary>
        public int Price { get; set; }
    }
}
