using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelecomProject.Domain
{
    public class Device
    {
        public int Id { get; set; }
        public string Phone_type { get; set; }
        public Plan Plan_name { get; set; }
        public int Phone_number { get; set; }
        public Person Person { get; set; }
    }
}
