using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblBrief
{
    public int Id { get; set; }

    public string? Enquiryid { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Status { get; set; }

    public string? ProjectName { get; set; }

    public int? ClientId { get; set; }

    public string? BriefId { get; set; }

    public int? EnqId { get; set; }
}
