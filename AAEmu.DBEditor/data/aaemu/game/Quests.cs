﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace AAEmu.DBEditor.data.aaemu.game;

/// <summary>
/// Currently open quests
/// </summary>
public partial class Quests
{
    public uint Id { get; set; }

    public uint TemplateId { get; set; }

    public byte[] Data { get; set; }

    public sbyte Status { get; set; }

    public uint Owner { get; set; }
}