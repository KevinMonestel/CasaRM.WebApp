using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasaRM.WebApp.Persistence.Models
{
    [Table("SituacionHabitacional")]
    public class HousingSituation
    {
        [Key]
        public int Id { get; set; }

        [Column("CondicionTenenciaVivienda")]
        [StringLength(100)]
        public string HousingTenureCondition { get; set; }

        [Column("MaterialConstruccionParedes")]
        [StringLength(100)]
        public string HousingConstructionMaterialsWall { get; set; }

        [Column("MaterialConstruccionPiso")]
        [StringLength(100)]
        public string HousingConstructionMaterialsFloor { get; set; }

        [Column("CantidadAposentos")]
        public int RoomsQuantity { get; set; }

        [Column("CantidadDormitorios")]
        public int BedroomsQuantity { get; set; }

        [Column("CantidadBannos")]
        public int BathroomsQuantity { get; set; }

        [Column("EstadoConservacionVivienda")]
        [StringLength(100)]
        public string HousingConservationStatus { get; set; }

        [Column("ServiciosBasicos")]
        [StringLength(100)]
        [JsonIgnore]
        public string BasicServices { get; set; }
    }
}
