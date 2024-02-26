﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace AAEmu.DBEditor.data.aaemu.game;

/// <summary>
/// Possible Item listings that are for sale
/// </summary>
public partial class IcsShopItems
{
    /// <summary>
    /// SKU item id
    /// </summary>
    public uint ShopId { get; set; }

    /// <summary>
    /// Item who&apos;s icon to use for displaying in the shop, leave 0 for first item in the group
    /// </summary>
    public uint DisplayItemId { get; set; }

    /// <summary>
    /// Can be used to override the name in the shop
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Enables limited stock mode if non-zero, Account(1), Chracter(2)
    /// </summary>
    public byte LimitedType { get; set; }

    /// <summary>
    /// Number of items left in stock for this SKU if limited stock is enabled
    /// </summary>
    public uint LimitedStockMax { get; set; }

    /// <summary>
    /// Minimum level to buy the item (does not show on UI)
    /// </summary>
    public byte LevelMin { get; set; }

    /// <summary>
    /// Maximum level to buy the item (does not show on UI)
    /// </summary>
    public byte LevelMax { get; set; }

    /// <summary>
    /// Buy restriction rule, none (0), level (1) or quest(2)
    /// </summary>
    public byte BuyRestrictType { get; set; }

    /// <summary>
    /// Level or QuestId for restrict rule
    /// </summary>
    public uint BuyRestrictId { get; set; }

    public byte IsSale { get; set; }

    public byte IsHidden { get; set; }

    /// <summary>
    /// Limited sale start time
    /// </summary>
    public DateTime? SaleStart { get; set; }

    /// <summary>
    /// Limited sale end time
    /// </summary>
    public DateTime? SaleEnd { get; set; }

    /// <summary>
    /// All (0), NoCart (1), NoGift (2), OnlyBuy (3)
    /// </summary>
    public byte ShopButtons { get; set; }

    /// <summary>
    /// Number of items remaining, only for tab 1-1 (limited)
    /// </summary>
    public int Remaining { get; set; }
}