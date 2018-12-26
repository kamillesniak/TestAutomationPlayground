﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAutomationPlayground.Models.Clients;

namespace TestAutomationPlayground.Dto
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public string InsuranceNumber { get; set; }
        public int ClientTypeId { get; set; }
        public ClientType ClientType { get; set; }
    }
}