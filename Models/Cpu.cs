using System;
using System.Collections.Generic;

namespace comp_company.Models;

public partial class Cpu
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public string ProducingCountry { get; set; } = null!;
}
