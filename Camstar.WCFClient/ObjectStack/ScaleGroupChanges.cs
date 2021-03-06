﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScaleGroupChanges
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
  public class ScaleGroupChanges : ResourceGroupChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ScaleGroupChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ScaleGroupChanges_Entries")]
    protected new NamedObjectRef[] _Entries;
    [DataMember(EmitDefaultValue = false, Name = "ScaleGroupChanges_Groups")]
    protected new NamedObjectRef[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "ScaleGroupChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ScaleGroupChanges_EntryType")]
    protected new Primitive<string> _EntryType;

    public override bool Equals(object obj)
    {
      return obj is ScaleGroupChanges && object.Equals((object) this._ObjectToChange, (object) ((ScaleGroupChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._Entries, (Array) ((ScaleGroupChanges) obj)._Entries) && this.CompareArrays((Array) this._Groups, (Array) ((ScaleGroupChanges) obj)._Groups)) && (object.Equals((object) this._Name, (object) ((ScaleGroupChanges) obj)._Name) && object.Equals((object) this._EntryType, (object) ((ScaleGroupChanges) obj)._EntryType)) && base.Equals(obj);
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

    public new NamedObjectRef[] Entries
    {
      [param: In] set
      {
        this.PropertySet(nameof (Entries), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (Entries));
      }
    }

    public new NamedObjectRef[] Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (Groups));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public new Primitive<string> EntryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EntryType));
      }
    }
  }
}
