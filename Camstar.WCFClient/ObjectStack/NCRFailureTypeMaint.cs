﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRFailureTypeMaint
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
  public class NCRFailureTypeMaint : UserCodeMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRFailureTypeMaint_ObjectChanges")]
    protected NCRFailureTypeChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "NCRFailureTypeMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "NCRFailureTypeMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is NCRFailureTypeMaint && object.Equals((object) this._ObjectChanges, (object) ((NCRFailureTypeMaint) obj)._ObjectChanges) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((NCRFailureTypeMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ObjectToChange, (object) ((NCRFailureTypeMaint) obj)._ObjectToChange)) && base.Equals(obj);
    }

    public NCRFailureTypeChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (NCRFailureTypeChanges) this.PropertyGet(nameof (ObjectChanges));
      }
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
  }
}
