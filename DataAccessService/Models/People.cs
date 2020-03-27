﻿using System.ComponentModel.DataAnnotations;

namespace DataAccessService.Models
{
    public class People
    {
        [Key]
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email_address { get; set; }
    }
}
