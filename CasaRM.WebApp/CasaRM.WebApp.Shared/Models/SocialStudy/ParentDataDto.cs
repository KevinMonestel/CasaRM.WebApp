using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRM.WebApp.Shared.Models.SocialStudy
{
    public class ParentDataDto
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Relationship { get; set; }

        public string Identification { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string MaritalStatus { get; set; }

        public string Nacionality { get; set; }

        public string Scholarship { get; set; }

        public string PhonesNumbers { get; set; }

        public string Ocupation { get; set; }

        public string WorkAddress { get; set; }

        public string Illness { get; set; }

        public string Treatment { get; set; }

        public string Observations { get; set; }
    }
}
