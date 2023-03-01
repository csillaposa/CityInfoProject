using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Entities
{
    public class PointOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        // we want to signify the relation btw City and Point of Interest
        // navigation property => relationship will be created (foreign key will be the id of the city)
        [ForeignKey("CityId")]
        public City? City { get; set; }

        //it is recommended to declare the foreign key property, but not required
        public int CityId { get; set; }

        public PointOfInterest(string name)
        {
            Name = name;
        }
    }
}
