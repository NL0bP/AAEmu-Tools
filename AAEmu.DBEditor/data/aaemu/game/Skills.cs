﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace AAEmu.DBEditor.data.aaemu.game;

/// <summary>
/// Learned character skills
/// </summary>
public partial class Skills
{
    public uint Id { get; set; }

    public sbyte Level { get; set; }

    public string Type { get; set; }

    public uint Owner { get; set; }
}