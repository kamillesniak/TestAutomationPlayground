using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestAutomationPlayground.Models.Clients
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage ="Provide valid number = 3 Letters then 7 number like AJJ1234567")]
        [RegularExpression("[a-zA-Z]{3}[0-9]{7}")]
        public string InsuranceNumber { get; set; }

        [Display(Name = "Client Type")]
        [Required]
        public int ClientTypeId { get; set; }
        public ClientType ClientType { get; set; }

        [Display(Name ="Subscribe newsletter")]
        public bool IsSubsribedToNewsLetter { get; set; }

        [Display(Name = "Client Status")]
        [Required]
        public int ClientStatusId { get; set; }
        public ClientStatus ClientStatus { get; set; }
    }
}