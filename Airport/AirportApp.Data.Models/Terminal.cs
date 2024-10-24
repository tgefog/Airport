using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static AirportApp.Common.EntityValidationConstants.Terminal;

namespace AirportApp.Data.Models
{
    public class Terminal
    {
        [Key]
        [Comment("Unique identifier")]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of the terminal")]
        public string Name { get; set; } = null!;
        [Required]
        [Comment("Capacity of the terminal")]
        public int Capacity { get; set; }
        public ICollection<Gate> Gates { get; set; } = new List<Gate>();
    }
}
