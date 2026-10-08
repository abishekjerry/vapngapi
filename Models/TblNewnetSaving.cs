using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblNewnetSaving
{
    public int Id { get; set; }

    public decimal? NetSavingsRecuring { get; set; }

    public decimal? NetSavingsNonRecuring { get; set; }

    public int? Year { get; set; }

    public string? Country { get; set; }
}
