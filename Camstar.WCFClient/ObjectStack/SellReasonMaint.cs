﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SellReasonMaint
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
  public class SellReasonMaint : UserCodeMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "SellReasonMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "SellReasonMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SellReasonMaint_ObjectChanges")]
    protected SellReasonChanges _ObjectChanges;

    public override bool Equals(object obj)
    {
      return obj is SellReasonMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((SellReasonMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._ObjectToChange, (object) ((SellReasonMaint) obj)._ObjectToChange) && object.Equals((object) this._ObjectChanges, (object) ((SellReasonMaint) obj)._ObjectChanges)) && base.Equals(obj);
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public SellReasonChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SellReasonChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
