﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PrintQueueMaintMethods
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum PrintQueueMaintMethods
  {
    [EnumMember, Enumeration(null)] Delete,
    [Enumeration(null), EnumMember] Freeze,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] New,
    [EnumMember, Enumeration(null)] NewCopy,
    [EnumMember, Enumeration(null)] SaveAs,
    [Enumeration(null), EnumMember] UnFreeze,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}
