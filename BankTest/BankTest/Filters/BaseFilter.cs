using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankTest.Filters
{
    /// <summary>
    /// Some filters for pagination
    /// </summary>
    public class BaseFilter
    {

        /// <summary>
        /// cantidad de registro a omitir al mostrar el listado
        /// </summary>
        public int SkipCount { get; set; }
        /// <summary>
        /// cantidad maxima de registro a mostrar en el listado
        /// </summary>
        public int MaxResultCount { get; set; }
    }
}
