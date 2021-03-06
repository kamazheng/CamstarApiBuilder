﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionMaint_Environment
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
  public class DispositionMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Identifies the actions that can be taken on a Lot assigned to an Event.  Examples are Scrap, Rework, Return to Vendor.", "Disposition", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DispositionMaint_Environment_ObjectListInquiry")]
    [Metadata("Identifies the actions that can be taken on a Lot assigned to an Event.  Examples are Scrap, Rework, Return to Vendor.", "Disposition", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("Identifies the actions that can be taken on a Lot assigned to an Event.  Examples are Scrap, Rework, Return to Vendor.", "DispositionChanges", false, false, false, "DispositionChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionMaint_Environment_ObjectChanges")]
    protected DispositionChanges_Environment _ObjectChanges;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public DispositionChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DispositionChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
