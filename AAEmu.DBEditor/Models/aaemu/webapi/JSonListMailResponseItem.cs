﻿using AAEmu.DBEditor.data.enums;
using System;
using System.Collections.Generic;

namespace AAEmu.DBEditor.Models.aaemu.webapi;

public class JSonListMailResponseItem
{
    public long Id { get; set; }
    public uint SenderId { get; set; }
    public string SenderName { get; set; } = string.Empty;
    public uint ReceiverId { get; set; }
    public string ReceiverName { get; set; } = string.Empty;
    public bool IsDelivered { get; set; }
    public string Title { get; set; } = string.Empty;
    public MailType MailType { get; set; } = MailType.InvalidMailType;
    public DateTime SendDate { get; set; }
    public DateTime ReceiveDate { get; set; }
    public DateTime OpenDate { get; set; }
    public int AttachmentCount { get; set; }
    public long CopperCoins { get; set; }
}

public class JsonListMailResponseItems
{
    public List<JSonListMailResponseItem> MailItems { get; set; }
}
