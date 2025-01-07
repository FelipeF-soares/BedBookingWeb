using BedBookingWeb.Models.Build;
using BedBookingWeb.Models.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedBookingWeb.Models.Events;

public class Booking
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Data de chegada")]
    public DateTime ArrivalDate { get; set; }
    [Required]
    [DisplayName("Data de saída")]
    public DateTime DepartureDate  { get; set; }
    [DisplayName("Estado da Reserva")]
    public string ReserveStatus { get; set; }
    public virtual Customer Customer { get; set; }
    public int CustomerId { get; set; }
    public virtual Unit Unit { get; set; }
    public int UnitId { get; set; }
}
