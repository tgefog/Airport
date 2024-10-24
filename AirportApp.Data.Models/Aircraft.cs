using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AirportApp.Common.EntityValidationConstants.Aircraft;

namespace AirportApp.Data.Models
{
    public class Aircraft
    {
        [Key]
        [Comment("Unique identifier")]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(ModelMaxLength)]
        [Comment("Model of the aircraft")]
        public string Model { get; set; } = null!;
        [Required]
        [MaxLength(ManufacturerMaxLength)]
        [Comment("Manufacturer of the aircraft")]
        public string Manufacturer { get; set; } = null!;
        [Required]
        [MaxLength(RegistrationNumberMaxLength)]
        [Comment("Registration number of the aircraft")]
        public string RegistrationNumber { get; set; } = null!;
        [Required]
        [Comment("Unique identifier of the airline")]
        public Guid AirlineId { get; set; }
        [Required]
        [ForeignKey(nameof(AirlineId))]
        [Comment("Airline of the aircraft")]
        public Airline Airline { get; set; } = null!;
        [Required]
        [Comment("Number of seats in the aircraft")]
        public int SeatingCapacity { get; set; }
        public ICollection<Flight> Flights { get; set; } = new List<Flight>();
    }
}
