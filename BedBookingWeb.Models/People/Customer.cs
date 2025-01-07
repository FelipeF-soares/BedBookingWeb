using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedBookingWeb.Models.People;

public class Customer
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Nome")]
    public string Name { get; set; }
    [Required]
    [DisplayName("Telefone")]
    public string CellPhone { get; set; }
    [Required]
    [DisplayName("E-mail")]
    public string Email { get; set; }
}
