﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExecuteChecklistMethods
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
  public enum ExecuteChecklistMethods
  {
    [Enumeration(null), EnumMember] CreateParametricData,
    [EnumMember, Enumeration(null)] GetActions,
    [EnumMember, Enumeration(null)] GetChecklistEntries,
    [EnumMember, Enumeration(null)] GetDataPoints,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [EnumMember, Enumeration(null)] PreviewChecklist,
    [Enumeration(null), EnumMember] ProcessComputation,
    [EnumMember, Enumeration(null)] ResolveParametricData,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
