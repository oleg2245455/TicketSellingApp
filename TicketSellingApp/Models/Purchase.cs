using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TicketSellingApp.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int TicketId { get; set; }
        public DateTime DateTime { get; set; }
        public string Email { get; set; }
        public string FL { get; set; }

    }
}