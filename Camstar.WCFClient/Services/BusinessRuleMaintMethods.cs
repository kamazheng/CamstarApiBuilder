﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BusinessRuleMaintMethods
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
  public enum BusinessRuleMaintMethods
  {
    [EnumMember, Enumeration(null)] Delete,
    [EnumMember, Enumeration(null)] Freeze,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [EnumMember, Enumeration(null)] New,
    [EnumMember, Enumeration(null)] NewCopy,
    [Enumeration(null), EnumMember] SaveAs,
    [EnumMember, Enumeration(null)] UnFreeze,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}
