using System;
using System.Collections.Generic;

namespace SportShopEmeld.Models;

public partial class OrdersGood
{
    public int Id { get; set; }

    public int IdGood { get; set; }

    public int IdOrder { get; set; }

    public int Count { get; set; }

    public virtual Good IdGoodNavigation { get; set; } = null!;

    public virtual Order IdOrderNavigation { get; set; } = null!;
}
