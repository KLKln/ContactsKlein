using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace ContactsKlein.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options): base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    LastName = "Klein",
                    FirstName = "Kelly",
                    PhoneNumber = "555-555-5555",
                    Address = "111 lame st, Sylvester, IA",
                    Note = "fake info"

                },
                new Contact
                {
                    ContactId = 2,
                    LastName = "Morita",
                    FirstName = "Pat",
                    PhoneNumber = "456-123-8974",
                    Address = "42 bonzi lane, Okinawa, Japan",
                    Note = "more fake info"

                }

                );
        }
    }
}
