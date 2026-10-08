using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblNewshortfall
{
    public int Id { get; set; }

    public decimal? Shortfall { get; set; }

    public int? Year { get; set; }

    public string? Country { get; set; }
}
