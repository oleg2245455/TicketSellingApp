using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketSellingApp.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Producer { get; set; }
        public int Price { get; set; }
    }
}