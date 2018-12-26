using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using TestAutomationPlayground.Models.Clients;
using TestAutomationPlayground.Models;

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

        public ActionResult New()
        {
            var viewModel = new ClientFormViewModel
            {
                Client = new Client(),
                ClientStatus = dbContext.ClientStatuses.ToList(),
                ClientType = dbContext.ClientTypes.ToList()
            };
            return View("ClientForm", viewModel);
        }

    }
}