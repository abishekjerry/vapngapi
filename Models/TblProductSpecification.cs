using System;
using System.Collections.Generic;

namespace VAapiPng.Models;

public partial class TblProductSpecification
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int FieldId { get; set; }

    public int CatalogueId { get; set; }

    public string? Value { get; set; }
}
