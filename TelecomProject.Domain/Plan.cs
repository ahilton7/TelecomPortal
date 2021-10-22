using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelecomProject.Domain
{
    public class Plan
    {
        public int Id { get; set; }
        public int Device_limit { get; set; }
        public double Cost { get; set; }
        public string Name { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
        public List<Device> Devices { get; set; } = new List<Device>();

    }
}
