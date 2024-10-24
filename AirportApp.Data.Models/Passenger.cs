using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static AirportApp.Common.EntityValidationConstants.Passenger;

namespace AirportApp.Data.Models
{
    public class Passenger
    {
        [Key]
        [Comment("Unique identifier")]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(FirstNameMaxLength)]
        [Comment("First name of the passenger")]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(LastNameMaxLength)]
        [Comment("Last name of the passenger")]
        public string LastName { get; set; } = null!;
        [Required]
        [MaxLength(PassportNumberMaxLength)]
        [Comment("Number of passenger's passport")]
        public string PassportNumber { get; set; } = null!;
        [Required]
        [Comment("Birth date of the passenger")]
        public DateTime DateofBirth { get; set; } 
    }
}
