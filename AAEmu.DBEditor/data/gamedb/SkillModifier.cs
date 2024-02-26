﻿using System;
using System.Collections.Generic;

namespace AAEmu.DBEditor.data.gamedb;

public partial class SkillModifier
{
    public long? Id { get; set; }

    public long? OwnerId { get; set; }

    public string OwnerType { get; set; }

    public long? TagId { get; set; }

    public long? SkillAttributeId { get; set; }

    public long? UnitModifierTypeId { get; set; }

    public long? Value { get; set; }

    public long? SkillId { get; set; }

    public byte[] Synergy { get; set; }
}
