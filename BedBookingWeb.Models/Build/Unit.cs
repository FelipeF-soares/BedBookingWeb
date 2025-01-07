using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedBookingWeb.Models.Build;

public class Unit
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Nome do Quarto")]
    public string Name { get; set; }
    [Required]
    [DisplayName("Tipologia")]
    public string Typology { get; set; }
    [DisplayName("Descrição")]
    public string Description { get; set; }
    [Required]
    [DisplayName("Quantidade de Pessoas")]
    public int AmountOfPeople { get; set; }
    [Required]
    [DisplayName("Quantidade de Cama de Solteiro")]
    public int NumberOfBedSingle { get; set; }
    [Required]
    [DisplayName("Quantidade de Cama de Casal")]
    public int NumberOfBedMerried { get; set; }
}
