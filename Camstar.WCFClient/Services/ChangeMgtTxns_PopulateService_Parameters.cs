﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeMgtTxns_PopulateService_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ChangeMgtTxns_PopulateService_Parameters : ChangeMgtTxns_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject")]
    protected string _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "Service")]
    protected string _Service;

    public string TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public string Service
    {
      [param: In] set
      {
        this.PropertySet(nameof (Service), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Service));
      }
    }
  }
}
