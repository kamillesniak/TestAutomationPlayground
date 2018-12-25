using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using TestAutomationPlayground.Models;
using TestAutomationPlayground.Models.Clients;

namespace TestAutomationPlayground.Controllers.Clients
{
    public class ClientsController : Controller
    {
        private List<Client> clients;
        private ApplicationDbContext dbContext;
        public ClientsController()
        {
            dbContext = new ApplicationDbContext();
            clients = dbContext.Clients.Include(x => x.ClientType).ToList();
        }
        // GET: Clients
        public ActionResult Index()
        {
            return View(clients);
        }

        public ActionResult Save()
        {
            throw new NotImplementedException();
        }
    }
}