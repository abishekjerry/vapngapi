using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblMfee
{
    public int Id { get; set; }

    public decimal? Mfee { get; set; }

    public decimal? ShortfallMfee { get; set; }
}
