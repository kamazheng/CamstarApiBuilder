﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MaintenanceReqMaintMethods
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
  public enum MaintenanceReqMaintMethods
  {
    [Enumeration(null), EnumMember] Delete,
    [Enumeration(null), EnumMember] DeleteAllRevisions,
    [Enumeration(null), EnumMember] Freeze,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [EnumMember, Enumeration(null)] New,
    [EnumMember, Enumeration(null)] NewCopy,
    [Enumeration(null), EnumMember] NewRev,
    [EnumMember, Enumeration(null)] NewRevCopy,
    [Enumeration(null), EnumMember] SaveAs,
    [Enumeration(null), EnumMember] SaveAsRev,
    [Enumeration(null), EnumMember] UnFreeze,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [Enumeration(null), EnumMember] AddDataTransaction,
  }
}
