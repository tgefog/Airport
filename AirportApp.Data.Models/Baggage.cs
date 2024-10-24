using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AirportApp.Common.EntityValidationConstants.Baggage;

namespace AirportApp.Data.Models
{
    public class Baggage
    {
        [Key]
        [Comment("Unique identifier")]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(TagNumberMaxLength)]
        [Comment("Tag number of the baggage")]
        public string TagNumber { get; set; } = null!;
        [Required]
        [Comment("Unique identifier of the passenger")]
        public Guid PassengerId { get; set; }
        [Required]
        [ForeignKey(nameof(PassengerId))]
        [Comment("Passenger associated with the baggage")]
        public Passenger Passenger { get; set; } = null!;
        [Required]
        [Comment("Unique identifier of the flight")]
        public Guid FlightId { get; set; }
        [Required]
        [ForeignKey(name: nameof(FlightId))]
        [Comment("Flight associated with the baggage")]
        public Flight Flight { get; set; } = null!;
        [Required]
        [Precision(WeightMaxPrecision, WeightMinPrecision)]
        [Comment("Weight of the baggage")]
        public decimal Weight { get; set; }
    }
}
