﻿namespace AAEmu.DBEditor.data.enums;

public enum SlotType : byte
{
    None = 0,
    Equipment = 1,
    Inventory = 2,
    Bank = 3,
    Trade = 4,
    Mail = 5,
    Auction = 6,
    EquipmentMate = 252,
    System = 0xFF
}