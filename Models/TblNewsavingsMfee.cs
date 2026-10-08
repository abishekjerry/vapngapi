using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblNewsavingsMfee
{
    public string EntityName { get; set; } = null!;

    public string Country { get; set; } = null!;

    public decimal? Mfee { get; set; }

    public decimal? ShortfallMfee { get; set; }

    public decimal? NetSavingsRecuring { get; set; }

    public decimal? NetSavingsNonRecuring { get; set; }

    public string? Year { get; set; }

    public int Id { get; set; }

    public decimal? BrandedDictatedMf { get; set; }

    public bool? DefaultYearselected { get; set; }
}
