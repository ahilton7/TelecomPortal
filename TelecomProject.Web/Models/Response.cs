using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelecomProject.Web.Models
{
    public class Response
    {
        public int Status { get; set; }
        public String Message { get; set; }

        public int personId { get; set; }
    }
}
