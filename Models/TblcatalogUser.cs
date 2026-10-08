using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblcatalogUser
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Country { get; set; }

    public string? Currency { get; set; }

    public string? Entity { get; set; }
}
