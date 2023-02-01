using facebookClone.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace facebookClone.Models.View_Model
{
    public class userVM
    {
        public userVM(userDto row)
        {
            Id= row.Id;
            FirstName= row.FirstName;
            LastName= row.LastName;
            Email= row.Email;
            Username= row.Username;
            Password= row.Password;
        }
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
    }
}