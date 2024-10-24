using Microsoft.EntityFrameworkCore;
using P02_FootballBetting;
using System.ComponentModel.DataAnnotations;

namespace P02_FootballBetting.Data.Models;
public class User
{
    public User()
    {
        Bets = new HashSet<Bet>();
    }
    public int UserId { get; set; }

    [MaxLength(ValidationConstants.UserUsernameLength)]
    public string Username { get; set; }

    [MaxLength(ValidationConstants.UserPasswordLength)]
    public string Password { get; set; }

    [MaxLength(ValidationConstants.UserEmailLength)]
    public string Email { get; set; }

    [MaxLength(ValidationConstants.UserNameLength)]
    public string Name { get; set; }
    [Precision(18, 4)]
    public decimal Balance { get; set; }

    public virtual ICollection<Bet> Bets { get; set; }
}