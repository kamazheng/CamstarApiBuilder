﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DataCollectionDefMaintMethods
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
  public enum DataCollectionDefMaintMethods
  {
    [EnumMember, Enumeration(null)] Delete,
    [EnumMember, Enumeration(null)] DeleteAllRevisions,
    [EnumMember, Enumeration(null)] Freeze,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] New,
    [EnumMember, Enumeration(null)] NewCopy,
    [Enumeration(null), EnumMember] NewRev,
    [EnumMember, Enumeration(null)] NewRevCopy,
    [EnumMember, Enumeration(null)] SaveAs,
    [Enumeration(null), EnumMember] SaveAsRev,
    [Enumeration(null), EnumMember] UnFreeze,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}
