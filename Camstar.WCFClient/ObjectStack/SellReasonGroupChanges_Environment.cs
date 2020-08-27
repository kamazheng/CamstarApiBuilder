﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SellReasonGroupChanges_Environment
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
  public class SellReasonGroupChanges_Environment : UserCodeGroupChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SellReasonGroupChanges_Environment_ObjectToChange")]
    [Metadata("A User Code Object Group that represents a group of Sell Reasons.", "SellReasonGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("A User Code Object Group that represents a group of Sell Reasons.", "SellReasonGroup", false, false, false, "NamedObjectRef", 1049325, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SellReasonGroupChanges_Environment_NewGroup")]
    protected new Environment _NewGroup;
    [DataMember(EmitDefaultValue = false, Name = "SellReasonGroupChanges_Environment_Groups")]
    [Metadata("A User Code Object Group that represents a group of Sell Reasons.", "SellReasonGroup", false, false, false, "NamedObjectRef", 1048633, false, true, true, null)]
    protected new Environment _Groups;
    [DataMember(EmitDefaultValue = false, Name = "SellReasonGroupChanges_Environment_NewEntry")]
    [Metadata("The user code for sell reason", "SellReason", false, false, false, "NamedObjectRef", 1049324, false, false, true, null)]
    protected new Environment _NewEntry;
    [Metadata("The user code for sell reason", "SellReason", false, false, true, "NamedObjectRef", 1048760, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SellReasonGroupChanges_Environment_ResolvedEntries")]
    protected new Environment _ResolvedEntries;
    [Metadata("The user code for sell reason", "SellReason", false, false, false, "NamedObjectRef", 1048631, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SellReasonGroupChanges_Environment_Entries")]
    protected new Environment _Entries;
    [DataMember(EmitDefaultValue = false, Name = "SellReasonGroupChanges_Environment_EntryType")]
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1048632, false, false, true, "SellReason")]
    protected new Environment _EntryType;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050086, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SellReasonGroupChanges_Environment_Name")]
    protected new Environment _Name;

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
  }
}
