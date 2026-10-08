using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblDivisionBrandsorproduct
{
    public int Id { get; set; }

    public int? Divisionid { get; set; }

    public string? Country { get; set; }

    public string? Brandorproduct { get; set; }
}
