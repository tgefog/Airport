using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static AirportApp.Common.EntityValidationConstants.Airline;

namespace AirportApp.Data.Models
{
    public class Airline
    {
        [Key]
        [Comment("Unique Identifier")]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of the airline")]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(CodeMaxLength)]
        [Comment("Code of the airline")]
        public string Code { get; set; } = null!;
        [Required]
        [MaxLength(CountryMaxLength)]
        [Comment("Country of the airline")]
        public string Country { get; set; } = null!;
        public ICollection<Aircraft> Aircrafts { get; set; } = new List<Aircraft>();
    }
}
