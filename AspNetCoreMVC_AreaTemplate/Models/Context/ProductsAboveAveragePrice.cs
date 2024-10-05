using System;
using System.Collections.Generic;

namespace AspNetCoreMVC_AreaTemplate.Models.Context;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
