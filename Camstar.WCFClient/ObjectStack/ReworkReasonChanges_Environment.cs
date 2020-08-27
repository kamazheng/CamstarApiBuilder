﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkReasonChanges_Environment
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
  public class ReworkReasonChanges_Environment : UserCodeWithWMChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ReworkReasonChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050123, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("An instance of a Process Rework Code is used to provide a list of reasons for Process Rework. The code is associated with a Container when it enters a rework loop. It is then associated with all throughput transactions generated by the container while it is in the rework loop. This provides, for example, a means of differentiating between first pass and rework throughput in reporting.\r\n", "ReworkReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReworkReasonChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
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
