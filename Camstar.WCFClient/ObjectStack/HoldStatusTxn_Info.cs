﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HoldStatusTxn_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class HoldStatusTxn_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "HoldStatusTxn_Info_HoldReason")]
    protected Info _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "HoldStatusTxn_Info_CurrentHoldCount")]
    protected Info _CurrentHoldCount;

    public Info HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HoldReason));
      }
    }

    public Info CurrentHoldCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentHoldCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentHoldCount));
      }
    }
  }
}
