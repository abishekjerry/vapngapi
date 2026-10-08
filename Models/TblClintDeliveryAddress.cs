using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblClintDeliveryAddress
{
    public int Id { get; set; }

    public int? Enqid { get; set; }

    public string? CompanyName { get; set; }

    public string? AdressLine1 { get; set; }

    public string? AdressLine2 { get; set; }

    public string? AdressLine3 { get; set; }

    public string? NameorDept { get; set; }

    public string? ContactNo { get; set; }

    public string? Remarks { get; set; }

    public int? Qty { get; set; }

    public decimal? Unitcharges { get; set; }

    public decimal? Frightcharges { get; set; }

    public string? Currency { get; set; }

    public string? Itemname { get; set; }

    public int? Itemnumber { get; set; }

    public decimal? Frighttaxpercentage { get; set; }

    public decimal? Frighttaxamount { get; set; }

    public bool? Customized { get; set; }

    public int? EchoLocid { get; set; }
}
