using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.DTO
{
    public class DriverDTO
    {
        public Guid? Id { get; set; }

        [Required, MaxLength(150)]
        public string FirstName { get; set; }


        [Required, MaxLength(150)]
        public string LastName { get; set; }


        [Required, EmailAddress]
        public string Email { get; set; }


        [Required]
        public string PhoneNumber { get; set; }
    }
}
