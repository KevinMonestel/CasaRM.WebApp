using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRM.WebApp.Shared.Models.Host
{
    public class SearchHostResultsDto
    {
        public string Code { get; set; }

        public string MinorPersonName { get; set; }

        public string MinorPersonFileNumber { get; set; }
    }
}
