using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblSavingsDetail
{
    public int Id { get; set; }

    public int EnquiryId { get; set; }

    public int EnquiryDetailsId { get; set; }

    public string? ReasonForSaving { get; set; }

    public int? ItemNumber { get; set; }

    public string? PreviousSupplier { get; set; }

    public string? PreviousPrice { get; set; }

    public string? Note { get; set; }

    public decimal? ItemSellPrice { get; set; }

    public decimal? ManagementFee { get; set; }

    public DateTime? ServerTime { get; set; }

    public string? PreviousPriceReports { get; set; }

    public string? NetSavingBaseline { get; set; }

    public string? InitialAmount { get; set; }
}
