using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketSellingApp.Models;
using System.Data.Entity;

namespace TicketSellingApp.Controllers
{
    public class HomeController : Controller
    {

        TicketContext ticketContext = new TicketContext();
        public ActionResult Index()
        {
            //Извелкаем данные с даблицы Tickets
            IEnumerable<Ticket> tickets = ticketContext.Tickets;
            //Записываем tickets в динамическое свойство ViewBag
            ViewBag.Tickets = tickets;

            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;

            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.DateTime = DateTime.Now;

            ticketContext.Purchases.Add(purchase);

            ticketContext.SaveChanges();

            return $"Dear customer, {purchase.FL}, You will be contacted soon!";
        }
    }
}