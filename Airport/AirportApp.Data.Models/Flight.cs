using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AirportApp.Common.EntityValidationConstants.Flight;

namespace AirportApp.Data.Models
{
    public class Flight
    {
        [Key]
        [Comment("Unique Identifier")]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(NumberMaxLength)]
        [Comment("Number of the flight")]
        public string FlightNumber { get; set; } = null!;
        [Required]
        [MaxLength(OriginMaxLength)]
        [Comment("Flight origin")]
        public string Origin { get; set; } = null!;
        [Required]
        [MaxLength(DestinationMaxLength)]
        [Comment("Flight destination")]
        public string Destination { get; set; } = null!;
        [Required]
        [Comment("Departure time of the flight")]
        public DateTime DepartureTime { get; set; }
        [Required]
        [Comment("Arrival time of the flight")]
        public DateTime ArrivalTime { get; set; }
        [Comment("Status of the flight : Scheduled/Departed/Arrived/Cancelled")]
        public string Status { get; set; } = null!;
        [Required]
        [Comment("Unique Identifier of the flight's airline")]
        public Guid AirlineId { get; set; }
        [Required]
        [ForeignKey(nameof(AirlineId))]
        [Comment("Airline of the flight")]
        public Airline Airline { get; set; } = null!;

        [Comment("Gate unique identifier assigned to the flight")]
        public Guid? GateId { get; set; }

        [ForeignKey(nameof(GateId))]
        [Comment("Gate assigned to the flight")]
        public Gate? Gate { get; set; }
        [Comment("Bookings for this flight")]
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        [Comment("Staff members assigned to this flight")]
        public ICollection<FlightStaffMember> FlightStaffMembers { get; set; } = new List<FlightStaffMember>();

    }
}
