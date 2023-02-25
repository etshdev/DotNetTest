using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.DTO
{
    public class ResultDTO
    {
        public string Message { get; set; } 
        public object data { get; set; }
        public bool Status { get; set; }
    }

}
