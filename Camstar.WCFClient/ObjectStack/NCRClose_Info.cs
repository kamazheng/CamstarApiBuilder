﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRClose_Info
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
  public class NCRClose_Info : NCRUpdate_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRClose_Info_ServiceDetail")]
    protected NCRCloseDetail_Info _ServiceDetail;

    public NCRCloseDetail_Info ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (NCRCloseDetail_Info) this.PropertyGet(nameof (ServiceDetail));
      }
    }
  }
}
