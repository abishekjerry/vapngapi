using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblTemp
{
    public int? Id { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public int? Status { get; set; }
}
