using System;
using System.ComponentModel.DataAnnotations;

namespace IntranetRSCI.Models
{
    public class User
    {
        public int ID { get; set; }

        [Display(Name = "User First Name")]
        public String FirstName { get; set; }

        [Display(Name = "User Last Name")]
        public String LastName { get; set; }
    }
}
