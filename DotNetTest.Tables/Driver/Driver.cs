using DotNetTest.Common.General;
using DotNetTest.Tables.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.Tables
{
    [Table(nameof(Driver) + "s", Schema = AppConstants.Schema.Guide)]

    public class Driver:BaseEntity
    {
        [Required,MaxLength(150)]
        public string FirstName { get; set; }
        [Required, MaxLength(150)]

        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}
