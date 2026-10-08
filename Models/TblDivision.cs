using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblDivision
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public string ClientName { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string EntityName { get; set; } = null!;

    public string BussinessUnit { get; set; } = null!;

    public string DepartmentOrProduct { get; set; } = null!;

    public bool Status { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? City { get; set; }

    public string? GlobalBumapping { get; set; }

    public string? Clientcode { get; set; }

    public string? PaymentTerm { get; set; }

    public string? PaymentTermcode { get; set; }
}
