using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblSurvey
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Responsive { get; set; }

    public string? Accuracy { get; set; }

    public string? Quality { get; set; }

    public string? OvarallExp { get; set; }

    public string? Comments { get; set; }

    public int? EnqId { get; set; }

    public string? EnqUid { get; set; }

    public string? Country { get; set; }

    public DateTime? SurveyDate { get; set; }

    public string? Submitedby { get; set; }

    public string? Qos { get; set; }

    public string? Dot { get; set; }

    public string? Otr { get; set; }

    public string? Qom { get; set; }

    public string? Pov { get; set; }

    public string? Pmp { get; set; }

    public string? Issues { get; set; }
}
