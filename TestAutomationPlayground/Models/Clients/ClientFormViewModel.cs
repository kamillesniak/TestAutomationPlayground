using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAutomationPlayground.Models.Clients
{
    public class ClientFormViewModel
    {
        public Client Client { get; set; }
        public IEnumerable<ClientType> ClientType { get; set; }
        public IEnumerable<ClientStatus> ClientStatus { get; set; }
    }
}