﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CompoundTxnMethods
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
  public enum CompoundTxnMethods
  {
    [EnumMember, Enumeration(null)] CreateParametricData,
    [Enumeration(null), EnumMember] ExecuteService,
    [Enumeration(null), EnumMember] ExecuteSubServices,
    [Enumeration(null), EnumMember] GetActions,
    [EnumMember, Enumeration(null)] GetDataPoints,
    [Enumeration(null), EnumMember] GetWIPMsgs,
    [Enumeration(null), EnumMember] InitSubServiceHistories,
    [Enumeration(null), EnumMember] Load,
    [Enumeration(null), EnumMember] LoadESigDetails,
    [Enumeration(null), EnumMember] ProcessComputation,
    [Enumeration(null), EnumMember] ResolveParametricData,
    [Enumeration(null), EnumMember] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
