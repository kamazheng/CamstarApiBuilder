﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DocumentMaintMethods
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
  public enum DocumentMaintMethods
  {
    [EnumMember, Enumeration(null)] Delete,
    [EnumMember, Enumeration(null)] DeleteAllRevisions,
    [Enumeration(null), EnumMember] DocumentMaint_Validations,
    [EnumMember, Enumeration(null)] DownloadFile,
    [Enumeration(null), EnumMember] Freeze,
    [EnumMember, Enumeration(null)] GetWIPMsgs,
    [EnumMember, Enumeration(null)] Load,
    [EnumMember, Enumeration(null)] LoadESigDetails,
    [Enumeration(null), EnumMember] New,
    [EnumMember, Enumeration(null)] NewCopy,
    [Enumeration(null), EnumMember] NewRev,
    [EnumMember, Enumeration(null)] NewRevCopy,
    [Enumeration(null), EnumMember] SaveAs,
    [EnumMember, Enumeration(null)] SaveAsRev,
    [Enumeration(null), EnumMember] UnFreeze,
    [EnumMember, Enumeration(null)] UploadFile,
    [EnumMember, Enumeration(null)] ExecuteTransaction,
    [EnumMember, Enumeration(null)] AddDataTransaction,
  }
}
