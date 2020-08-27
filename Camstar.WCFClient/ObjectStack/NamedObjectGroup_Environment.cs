﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedObjectGroup_Environment
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
  public class NamedObjectGroup_Environment : ObjectGroup_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_Groups")]
    [Metadata("NamedObjectGroup is used to provide a list of named object.", "NamedObjectGroup", false, false, true, "NamedObjectRef", 1048633, false, true, false, null)]
    protected new Environment _Groups;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_WhereUsed")]
    [Metadata("A list of this type is returned by the Where-used functionality of a maintenance service.  An instance of this CDO will specify one of the objects using the object to change.  The fields in this CDO are used to populate a tree view displayed while maintaining a modeling object.", "WhereUsed", false, false, true, "SubentityRef", 1049803, false, true, false, null)]
    protected new Environment _WhereUsed;
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_ModelingInstanceLocks")]
    [Metadata("A listing of a change package where modeling instance is assigned.", "ModelingInstanceLock", false, false, true, "SubentityRef", 16777683, false, true, false, null)]
    protected new Environment _ModelingInstanceLocks;
    [Metadata("FilterTags", "", false, false, true, "String", 16778956, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_FilterTags")]
    protected new Environment _FilterTags;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1048760, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_ResolvedEntries")]
    protected new Environment _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_AssociatedPackages")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777948, false, false, false, null)]
    protected new Environment _AssociatedPackages;
    [Metadata("Factory modeling objects that can be uniquely identified by name.", "NamedDataObject", false, false, true, "NamedObjectRef", 1048631, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_Entries")]
    protected new Environment _Entries;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_InstanceLocked")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777984, false, false, false, "0")]
    protected new Environment _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_DefaultForObjectTypes")]
    [Metadata("CDO Definition Id", "", false, false, true, "Integer", 1048971, false, true, false, null)]
    protected new Environment _DefaultForObjectTypes;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050073, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_Description")]
    protected new Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_EntryType")]
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1048632, false, false, false, "NamedDataObject")]
    protected new Environment _EntryType;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    protected new Environment _Notes;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_IconId")]
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, true, "Integer", 1048679, false, false, false, null)]
    protected new Environment _IconId;
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, true, "ChangeHistory", 1048765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_ChangeHistory")]
    protected new ChangeHistory_Environment _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;

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

    public new Environment WhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WhereUsed));
      }
    }

    public new Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
      }
    }

    public new Environment ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelingInstanceLocks));
      }
    }

    public new Environment FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterTags));
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

    public new Environment AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssociatedPackages));
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

    public new Environment InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Environment DefaultForObjectTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultForObjectTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultForObjectTypes));
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

    public new Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
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

    public new Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
      }
    }

    public new Environment IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IconId));
      }
    }

    public new ChangeHistory_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Environment) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Environment IsFrozen
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
