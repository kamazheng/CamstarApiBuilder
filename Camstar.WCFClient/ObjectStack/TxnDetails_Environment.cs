﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TxnDetails_Environment
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
  public class TxnDetails_Environment : Subentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_Environment_ReworkReason")]
    [Metadata("An instance of a Process Rework Code is used to provide a list of reasons for Process Rework. The code is associated with a Container when it enters a rework loop. It is then associated with all throughput transactions generated by the container while it is in the rework loop. This provides, for example, a means of differentiating between first pass and rework throughput in reporting.\r\n", "ReworkReason", false, false, true, "NamedObjectRef", 1048740, false, false, false, null)]
    protected Environment _ReworkReason;
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, false, true, "NamedObjectRef", 1048738, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_Environment_NewOwner")]
    protected Environment _NewOwner;
    [Metadata("Numeric Option", "", false, false, true, "Integer", 1048743, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_Environment_ToContainerOption")]
    protected Environment _ToContainerOption;
    [Metadata("Numeric Option", "", false, false, true, "Integer", 1048909, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_Environment_TxnType")]
    protected Environment _TxnType;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReworkReason));
      }
    }

    public Environment NewOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewOwner));
      }
    }

    public Environment ToContainerOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToContainerOption));
      }
    }

    public Environment TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnType));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
