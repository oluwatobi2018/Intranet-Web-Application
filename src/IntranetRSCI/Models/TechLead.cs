using System;
using System.ComponentModel.DataAnnotations;

namespace IntranetRSCI.Models
{
    public class TechLead
    {
        public int ID { get; set; }

        [Display(Name = "Tech First Name")]
        public String TechFirstName { get; set; }

        [Display(Name = "Tech Last Name")]
        public String TechLastName { get; set; }

        public String Customer { get; set; }

        [Display(Name = "Contact Name")]
        public String ContactName { get; set; }

        [Display(Name = "Contact Phone")]
        public String ContactPhone { get; set; }

        [Display(Name = "Contact Email")]
        public String ContactEmail { get; set; }

        [Display(Name = "Contact Address")]
        public String ContactAddress { get; set; }

        public String Notes { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
