﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtWorkflowMaint_Info
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
  public class ChangeMgtWorkflowMaint_Info : BusinessProcessWorkflowMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowMaint_Info_ObjectChanges")]
    protected ChangeMgtWorkflowChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowMaint_Info_BaseToChange")]
    protected new Info _BaseToChange;

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

    public new Info ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public ChangeMgtWorkflowChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ChangeMgtWorkflowChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Info BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BaseToChange));
      }
    }
  }
}
