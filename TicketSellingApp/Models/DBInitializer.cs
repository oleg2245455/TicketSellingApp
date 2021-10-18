using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TicketSellingApp.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<TicketContext>
    {
        protected override void Seed(TicketContext context)
        {
            context.Tickets.Add(new Ticket() { Name = "Kyiv-Amsterdam", Price = 9000, Producer = "Yanair" });
            context.Tickets.Add(new Ticket() { Name = "Kyiv-Antalia", Price = 6000, Producer = "Khors Air" });
            context.Tickets.Add(new Ticket() { Name = "Kyiv-Dubai", Price = 19000, Producer = "Fly Emirates" });
            context.Tickets.Add(new Ticket() { Name = "Kyiv-Warsaw", Price = 6000, Producer = "WindRose" });
            context.Tickets.Add(new Ticket() { Name = "Kyiv-Moscow", Price = 10000, Producer = "Bravo Airways" });
            context.Tickets.Add(new Ticket() { Name = "Kyiv-Stambul", Price = 8000, Producer = "Khors Air" });
            context.Tickets.Add(new Ticket() { Name = "Amsterdam-Kyiv", Price = 10000, Producer = "Yanair" });
            context.Tickets.Add(new Ticket() { Name = "Antalia-Kyiv", Price = 7000, Producer = "Khors Air" });
            context.Tickets.Add(new Ticket() { Name = "Dubai-Kyiv", Price = 20000, Producer = "Fly Emirates" });
            context.Tickets.Add(new Ticket() { Name = "Warsaw-Kyiv", Price = 7000, Producer = "WindRose" });
            context.Tickets.Add(new Ticket() { Name = "Moscow-Kyiv", Price = 11000, Producer = "Bravo Airways" });
            context.Tickets.Add(new Ticket() { Name = "Stambul-Kyiv", Price = 9000, Producer = "Khors Air" });

            base.Seed(context);
        }
    }
}