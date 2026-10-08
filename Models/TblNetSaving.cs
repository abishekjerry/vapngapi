using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblNetSaving
{
    public int Id { get; set; }

    public decimal? NetSavingsRecuring { get; set; }

    public decimal? NetSavingsNonRecuring { get; set; }
}
