﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PlanMaintMethods
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
  public enum PlanMaintMethods
  {
    [EnumMember, Enumeration(null)] Delete,
    [EnumMember, Enumeration(null)] Freeze,
    [EnumMember, Enumeration(null)] GetApprovalSheetTemplate,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [EnumMember, Enumeration(null)] LoadBusinessRules,
    [EnumMember, Enumeration(null)] LoadChecklistTemplate,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] LoadTemplate,
    [EnumMember, Enumeration(null)] New,
    [Enumeration(null), EnumMember] NewCopy,
    [EnumMember, Enumeration(null)] PreviewChecklist,
    [Enumeration(null), EnumMember] SaveAs,
    [EnumMember, Enumeration(null)] UnFreeze,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
