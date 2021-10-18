using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TicketSellingApp.Models
{
    public class TicketContext : DbContext
    {
        public DbSet<Ticket> Tickets {get;set;}
        public DbSet<Purchase> Purchases { get; set; }
    }
} 