using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.Common.General
{
    public static class AppDateTime
    {
        /// <summary>
        /// Egypt Time 
        /// </summary>
        public static DateTime Now => DateTime.UtcNow.AddHours(2);
    }
}
