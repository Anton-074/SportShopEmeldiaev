using System;
using System.Collections.Generic;

namespace SportShopEmeld.Models;

public partial class Good
{
    public int Id { get; set; }

    public int IdCategory { get; set; }

    public int IdManufacture { get; set; }

    public int IdSupplier { get; set; }

    public string Name { get; set; } = null!;

    public string Article { get; set; } = null!;

    public decimal Price { get; set; }

    public int IdUnit { get; set; }

    public int Sale { get; set; }

    public int CountInStock { get; set; }

    public string? Description { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Manufacture Manufacture { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;

    public virtual ICollection<OrdersGood> OrdersGoods { get; set; } = new List<OrdersGood>();
}
