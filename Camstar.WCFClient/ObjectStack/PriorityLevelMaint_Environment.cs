﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PriorityLevelMaint_Environment
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
  public class PriorityLevelMaint_Environment : UserCodeMaint_Environment
  {
    [Metadata("Identifies a Priority for an Event.", "PriorityLevelChanges", false, false, false, "PriorityLevelChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PriorityLevelMaint_Environment_ObjectChanges")]
    protected PriorityLevelChanges_Environment _ObjectChanges;
    [Metadata("Identifies a Priority for an Event.", "PriorityLevel", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PriorityLevelMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("Identifies a Priority for an Event.", "PriorityLevel", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PriorityLevelMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public PriorityLevelChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PriorityLevelChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
