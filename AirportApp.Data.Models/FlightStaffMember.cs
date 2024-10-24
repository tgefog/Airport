using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirportApp.Data.Models
{
    [PrimaryKey(nameof(FlightId), nameof(StaffMemberId))]
    public class FlightStaffMember
    {
        [Comment("Identifier of the flight")]
        public Guid FlightId { get; set; }

        [ForeignKey(nameof(FlightId))]
        public Flight Flight { get; set; } = null!;

        [Comment("Identifier of the staff member")]
        public Guid StaffMemberId { get; set; }

        [ForeignKey(nameof(StaffMemberId))]
        public StaffMember StaffMember { get; set; } = null!;
    }
}
