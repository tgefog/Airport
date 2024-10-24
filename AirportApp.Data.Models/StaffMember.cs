using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static AirportApp.Common.EntityValidationConstants.StaffMember;

namespace AirportApp.Data.Models
{
    public class StaffMember
    {
        [Key]
        [Comment("Unique identifier")]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(FirstNameMaxLength)]
        [Comment("First name of the staff member")]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(LastNameMaxLength)]
        [Comment("Last name of the staff member")]
        public string LastName { get; set; } = null!;
        [Required]
        [MaxLength(PositionMaxLength)]
        [Comment("Position of the staff member")]
        public string Position { get; set; } = null!;
        [Required]
        [Comment("Hire date of the staff member")]
        public DateTime HireDate { get; set; }
        [Required]
        [Precision(SalaryMaxPrecision, SalaryMinPrecision)]
        [Comment("Salary of the staff member")]
        public decimal Salary { get; set; }
        [Comment("Flights this staff member is assigned to")]
        public ICollection<FlightStaffMember> FlightAssignments { get; set; } = new List<FlightStaffMember>();
    }
}
