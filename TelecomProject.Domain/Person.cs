using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelecomProject.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Plan> Plans { get; set; } = new List<Plan>();
        public List<Device> Devices { get; set; } = new List<Device>();
    }
}
