﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BPMoveTxnMethods
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
  public enum BPMoveTxnMethods
  {
    [EnumMember, Enumeration(null)] AdditionalValidations,
    [Enumeration(null), EnumMember] CreateParametricData,
    [EnumMember, Enumeration(null)] GetActions,
    [Enumeration(null), EnumMember] GetDataPoints,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [EnumMember, Enumeration(null)] ProcessComputation,
    [Enumeration(null), EnumMember] ResolveParametricData,
    [Enumeration(null), EnumMember] ValidatePath,
    [EnumMember, Enumeration(null)] ValidatePathToStepExists,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
