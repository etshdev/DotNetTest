using DotNetTest.Common.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.Tables.Base
{
    public class BaseEntity
    {
        public BaseEntity() => ID = Guid.NewGuid();

        /// <summary>
        /// ID Is The Id Of Table 
        /// uniqueidentifier
        /// </summary>
        [Key]
        public Guid ID { get; set; }

        /// <summary>
        /// Creation Date Of The Item
        /// </summary>
        public DateTime CreatedDate { get; set; } = AppDateTime.Now;


        public bool IsDeleted { get; set; } = false;

        public bool IsActive { get; set; } = true;





    }

}
