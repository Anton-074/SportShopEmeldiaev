using System;
using System.Collections.Generic;

namespace SportShopEmeld.Models;

public partial class Order
{
    public int Id { get; set; }

    public int IdStatus { get; set; }

    public int IdUser { get; set; }

    public int IdAddress { get; set; }

    public DateOnly DateOfStart { get; set; }

    public DateOnly DateOfEnd { get; set; }

    public int Code { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual ICollection<OrdersGood> OrdersGoods { get; set; } = new List<OrdersGood>();
}
