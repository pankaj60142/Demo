using System;
using System.ComponentModel.DataAnnotations;

namespace Demo
{
    public class Account
    {
        public int AccountID { get; set; }
        [Required]
        public string AccountName { get; set; }
        [Required]
        public string Snam { get; set; }
    }
}
