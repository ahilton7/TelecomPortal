﻿using System;
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
        public int? Phone_number { get; set; }
        public int PersonId { get; set; }
        public int? PlanId { get; set; }
    }
}
