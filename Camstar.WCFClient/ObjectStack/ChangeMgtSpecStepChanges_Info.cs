﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtSpecStepChanges_Info
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
  public class ChangeMgtSpecStepChanges_Info : BusinessProcessSpecStepChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecStepChanges_Info_Spec")]
    protected new Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecStepChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;

    public new Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
