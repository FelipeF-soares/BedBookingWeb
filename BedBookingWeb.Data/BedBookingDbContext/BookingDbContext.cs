using BedBookingWeb.Models.Build;
using BedBookingWeb.Models.Events;
using BedBookingWeb.Models.People;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedBookingWeb.Data.BedBookingDbContext;

public class BookingDbContext : DbContext
{
    public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options)
    {
        
    }
    public DbSet<Unit> Units { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Unit>().HasData
            (
                new Unit { Id=1, Name = "Quarto 1", Typology = "Quarto1", AmountOfPeople = 2, NumberOfBedMerried = 1, NumberOfBedSingle = 2, Description = ""},
                new Unit { Id=2, Name = "Quarto 2", Typology = "Quarto2", AmountOfPeople = 2, NumberOfBedMerried = 1, NumberOfBedSingle = 2, Description = "" },
                new Unit { Id=3, Name = "Quarto 3", Typology = "Quarto3", AmountOfPeople = 2, NumberOfBedMerried = 1, NumberOfBedSingle = 2, Description = "" }
            );
    }
}
