﻿using System;
using System.Collections.Generic;

namespace AAEmu.DBEditor.data.gamedb;

public partial class SphereSkill
{
    public long? Id { get; set; }

    public long? SkillId { get; set; }

    public long? MaxRate { get; set; }

    public long? MinRate { get; set; }
}
