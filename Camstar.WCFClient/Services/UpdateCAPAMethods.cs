﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateCAPAMethods
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
  public enum UpdateCAPAMethods
  {
    [EnumMember, Enumeration(null)] CreateParametricData,
    [Enumeration(null), EnumMember] GetActions,
    [EnumMember, Enumeration(null)] GetApprovalSheetDetails,
    [Enumeration(null), EnumMember] GetCAPADetails,
    [Enumeration(null), EnumMember] GetCrossRefDetails,
    [EnumMember, Enumeration(null)] GetDataPoints,
    [EnumMember, Enumeration(null)] GetDetails,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [Enumeration(null), EnumMember] Load,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [EnumMember, Enumeration(null)] ProcessComputation,
    [Enumeration(null), EnumMember] ResolveParametricData,
    [EnumMember, Enumeration(null)] SaveApprovalSheet,
    [EnumMember, Enumeration(null)] SubmitCAPA,
    [Enumeration(null), EnumMember] ValidateOwner,
    [EnumMember, Enumeration(null)] ValidateServiceDetail,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
