﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectGroup_Info
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
  public class ObjectGroup_Info : NamedDataObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_WhereUsed")]
    protected new Info _WhereUsed;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_ModelingInstanceLocks")]
    protected new Info _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_FilterTags")]
    protected new Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_Entries")]
    protected Info _Entries;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_InstanceLocked")]
    protected new Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_AssociatedPackages")]
    protected new Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_DefaultForObjectTypes")]
    protected Info _DefaultForObjectTypes;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_ResolvedEntries")]
    protected Info _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_ChangeHistory")]
    protected new ChangeHistory_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_EntryType")]
    protected Info _EntryType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_Notes")]
    protected new Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_IconId")]
    protected new Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_Groups")]
    protected Info _Groups;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Info_Name")]
    protected new Info _Name;

    public new Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
      }
    }

    public new Info WhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WhereUsed));
      }
    }

    public new Info ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelingInstanceLocks));
      }
    }

    public new Info FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterTags));
      }
    }

    public Info Entries
    {
      [param: In] set
      {
        this.PropertySet(nameof (Entries), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Entries));
      }
    }

    public new Info InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Info AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public Info DefaultForObjectTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultForObjectTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultForObjectTypes));
      }
    }

    public Info ResolvedEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedEntries), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResolvedEntries));
      }
    }

    public new ChangeHistory_Info ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Info) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info EntryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EntryType));
      }
    }

    public new Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public new Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }

    public new Info IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IconId));
      }
    }

    public Info Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Groups));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
