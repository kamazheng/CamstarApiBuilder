﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemoteStart_Environment
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
  public class RemoteStart_Environment : ContainerTxn_Environment
  {
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049887, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "RemoteStart_Environment_IsRemoteService")]
    protected new Environment _IsRemoteService;

    public new Environment IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRemoteService));
      }
    }
  }
}
