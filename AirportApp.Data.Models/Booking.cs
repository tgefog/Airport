using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AirportApp.Common.EntityValidationConstants.Booking;

namespace AirportApp.Data.Models
{
    public class Booking
    {
        [Key]
        [Comment("Unique Identifier")]
        public Guid Id { get; set; }
        [Required]
        [Comment("Unique identifier of the passenger")]
        public Guid PassengerId { get; set; }
        [Required]
        [ForeignKey(nameof(PassengerId))]
        [Comment("Passenger of the booking")]
        public Passenger Passenger { get; set; } = null!;
        [Required]
        [Comment("Unique identifier of the flight")]
        public Guid FlightId { get; set; }
        [Required]
        [ForeignKey(nameof(FlightId))]
        [Comment("Flight of the booking")]
        public Flight Flight { get; set; } = null!;
        [Required]
        [Comment("Date of the booking")]
        public DateTime BookingDate { get; set; }
        [Comment("Number of seat in the booking")]
        public string SeatNumber { get; set; } = null!;
        [Required]
        [MaxLength(SeatNumberMaxLength)]
        [Comment("Class of the booking")]
        public string Class { get; set; } = null!;
    }
}
