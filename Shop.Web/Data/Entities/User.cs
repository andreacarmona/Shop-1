﻿namespace Shop.Web.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [MaxLength(100, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string Address { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }
    }
}