﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace AAEmu.DBEditor.data.aaemu.game;

/// <summary>
/// Guild members
/// </summary>
public partial class ExpeditionMembers
{
    public int CharacterId { get; set; }

    public int ExpeditionId { get; set; }

    public string Name { get; set; }

    public byte Level { get; set; }

    public byte Role { get; set; }

    public DateTime LastLeaveTime { get; set; }

    public byte Ability1 { get; set; }

    public byte Ability2 { get; set; }

    public byte Ability3 { get; set; }

    public string Memo { get; set; }
}