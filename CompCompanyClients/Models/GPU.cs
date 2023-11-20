﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompCompanyClients.Models
{
    public partial class Gpu
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Price { get; set; }

        public string ProducingCountry { get; set; } = null!;
    }

}
