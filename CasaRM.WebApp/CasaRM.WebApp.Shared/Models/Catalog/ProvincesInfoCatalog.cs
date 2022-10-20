using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRM.WebApp.Shared.Models.Catalog
{
    public class ProvincesInfoCatalog
    {
        public string Title { get; set; }

        public IEnumerable<Canton> Cantons { get; set; }
    }

    public partial class Canton
    {
        public string Title { get; set; }
        public IEnumerable<District> Districts { get; set; }
    }

    public partial class District
    {
        public string Title { get; set; }
    }
}
