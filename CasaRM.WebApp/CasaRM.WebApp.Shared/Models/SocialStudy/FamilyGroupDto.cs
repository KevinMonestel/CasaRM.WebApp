namespace CasaRM.WebApp.Shared.Models.SocialStudy
{
    public class FamilyGroupDto
    {
        public int Id { get; set; }

        public int SocialStudyId { get; set; }

        public string FullName { get; set; }

        public string Relationship { get; set; }

        public int Age { get; set; }

        public string MaritalStatus { get; set; }

        public string Scholarship { get; set; }

        public string Ocupation { get; set; }

        public decimal MonthlyGrossIncome { get; set; }
    }
}
