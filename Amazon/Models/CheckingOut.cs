﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models
{
    public class CheckingOut
    {
        [Key]
        [BindNever]
        public int BookId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }


        [Required(ErrorMessage = "Please enter the city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the state name")]
        public string State { get; set; }
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter the country name")]
        public string Country { get; set; }

        public bool Anonymous { get; set; }

        [BindNever]
        public bool CheckOutReceived { get; set; }
    }
}
