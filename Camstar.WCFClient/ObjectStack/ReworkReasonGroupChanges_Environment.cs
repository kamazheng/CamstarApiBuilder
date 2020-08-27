﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkReasonGroupChanges_Environment
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
  public class ReworkReasonGroupChanges_Environment : UserCodeGroupChanges_Environment
  {
    [Metadata("A User Code Object Group that represents a group of ReworkReasons.", "ReworkReasonGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReworkReasonGroupChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A User Code Object Group that represents a group of ReworkReasons.", "ReworkReasonGroup", false, false, false, "NamedObjectRef", 1049325, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReworkReasonGroupChanges_Environment_NewGroup")]
    protected new Environment _NewGroup;
    [Metadata("A User Code Object Group that represents a group of ReworkReasons.", "ReworkReasonGroup", false, false, false, "NamedObjectRef", 1048633, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReworkReasonGroupChanges_Environment_Groups")]
    protected new Environment _Groups;
    [Metadata("An instance of a Process Rework Code is used to provide a list of reasons for Process Rework. The code is associated with a Container when it enters a rework loop. It is then associated with all throughput transactions generated by the container while it is in the rework loop. This provides, for example, a means of differentiating between first pass and rework throughput in reporting.\r\n", "ReworkReason", false, false, false, "NamedObjectRef", 1049324, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReworkReasonGroupChanges_Environment_NewEntry")]
    protected new Environment _NewEntry;
    [Metadata("An instance of a Process Rework Code is used to provide a list of reasons for Process Rework. The code is associated with a Container when it enters a rework loop. It is then associated with all throughput transactions generated by the container while it is in the rework loop. This provides, for example, a means of differentiating between first pass and rework throughput in reporting.\r\n", "ReworkReason", false, false, true, "NamedObjectRef", 1048760, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReworkReasonGroupChanges_Environment_ResolvedEntries")]
    protected new Environment _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "ReworkReasonGroupChanges_Environment_EntryType")]
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1048632, false, false, true, "ReworkReason")]
    protected new Environment _EntryType;
    [DataMember(EmitDefaultValue = false, Name = "ReworkReasonGroupChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050084, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("An instance of a Process Rework Code is used to provide a list of reasons for Process Rework. The code is associated with a Container when it enters a rework loop. It is then associated with all throughput transactions generated by the container while it is in the rework loop. This provides, for example, a means of differentiating between first pass and rework throughput in reporting.\r\n", "ReworkReason", false, false, false, "NamedObjectRef", 1048631, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReworkReasonGroupChanges_Environment_Entries")]
    protected new Environment _Entries;

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

    public new Environment NewGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewGroup));
      }
    }

    public new Environment Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Groups));
      }
    }

    public new Environment NewEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewEntry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewEntry));
      }
    }

    public new Environment ResolvedEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedEntries), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolvedEntries));
      }
    }

    public new Environment EntryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EntryType));
      }
    }

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

    public new Environment Entries
    {
      [param: In] set
      {
        this.PropertySet(nameof (Entries), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Entries));
      }
    }
  }
}
