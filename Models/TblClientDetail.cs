using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblClientDetail
{
    public int Id { get; set; }

    public string ClientName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AddressLine4 { get; set; }

    public string? City { get; set; }

    public string Country { get; set; } = null!;

    public string? Language { get; set; }

    public string? Currency { get; set; }

    public string? PaymentTerm { get; set; }

    public string? SalesPercentage { get; set; }

    public string? DefaultSalesPercentage { get; set; }

    public bool? Status { get; set; }

    public string? Sst { get; set; }

    public string? Clientcode { get; set; }

    public string? PaymentTermcode { get; set; }
}
