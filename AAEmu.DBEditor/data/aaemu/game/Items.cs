﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace AAEmu.DBEditor.data.aaemu.game;

/// <summary>
/// All items
/// </summary>
public partial class Items
{
    public ulong Id { get; set; }

    public string Type { get; set; }

    public uint TemplateId { get; set; }

    public uint ContainerId { get; set; }

    public string SlotType { get; set; }

    public int Slot { get; set; }

    public int Count { get; set; }

    public byte[] Details { get; set; }

    public int LifespanMins { get; set; }

    public uint MadeUnitId { get; set; }

    public DateTime UnsecureTime { get; set; }

    public DateTime UnpackTime { get; set; }

    public uint Owner { get; set; }

    public bool? Grade { get; set; }

    public byte Flags { get; set; }

    public DateTime CreatedAt { get; set; }

    public uint Ucc { get; set; }

    /// <summary>
    /// Fixed time expire
    /// </summary>
    public DateTime? ExpireTime { get; set; }

    /// <summary>
    /// Time left when player online
    /// </summary>
    public double ExpireOnlineMinutes { get; set; }

    /// <summary>
    /// Time charged items got activated
    /// </summary>
    public DateTime? ChargeTime { get; set; }

    /// <summary>
    /// Number of charges left
    /// </summary>
    public int ChargeCount { get; set; }
}