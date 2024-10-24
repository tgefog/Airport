using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AirportApp.Common.EntityValidationConstants.Gate;

namespace AirportApp.Data.Models
{
    public class Gate
    {
        [Key]
        [Comment("Unique identifier")]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(GateNumberMaxLength)]
        [Comment("Number of the gate")]
        public string GateNumber { get; set; } = null!;
        [Required]
        [Comment("Unique identifier of the gate's terminal")]
        public Guid TerminalId { get; set; }
        [Required]
        [ForeignKey(nameof(TerminalId))]
        [Comment("Terminal of the gate")]
        public Terminal Terminal { get; set; } = null!;

        [Comment("Flights assigned to this gate over time")]
        public ICollection<Flight> Flights { get; set; } = new List<Flight>();
    }
}
