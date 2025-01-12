﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace AAEmu.DBEditor.data.aaemu.game;

/// <summary>
/// Account specific values not related to login
/// </summary>
public partial class Accounts
{
    public int AccountId { get; set; }

    public int AccessLevel { get; set; }

    public int Labor { get; set; }

    public int Credits { get; set; }

    public int Loyalty { get; set; }

    public DateTime LastUpdated { get; set; }

    public DateTime LastLogin { get; set; }

    public DateTime LastLaborTick { get; set; }

    public DateTime LastCreditsTick { get; set; }

    public DateTime LastLoyaltyTick { get; set; }

    /// <summary>
    /// Time that has been passed already
    /// </summary>
    public uint DivineClockTime { get; set; }

    /// <summary>
    /// Number of clicks taken today
    /// </summary>
    public uint DivineClockTaken { get; set; }
}