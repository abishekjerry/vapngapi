using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblNewmfee
{
    public int Id { get; set; }

    public decimal? Mfee { get; set; }

    public decimal? ShortfallMfee { get; set; }

    public int? Year { get; set; }

    public string? Country { get; set; }
}
