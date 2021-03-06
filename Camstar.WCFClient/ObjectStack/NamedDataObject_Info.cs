﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedDataObject_Info
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
  public class NamedDataObject_Info : BaseObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Info_ESigHistoryDetails")]
    protected ModelingESigHistoryDetail_Info _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Info_WhereUsed")]
    protected Info _WhereUsed;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Info_DisplayName")]
    protected Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Info_ModelingInstanceLocks")]
    protected Info _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Info_FilterTags")]
    protected Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Info_AssociatedPackages")]
    protected Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Info_InstanceLocked")]
    protected Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Info_ChangeHistory")]
    protected ChangeHistory_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Info_IconId")]
    protected Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Info_Notes")]
    protected Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Info_Name")]
    protected Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Info_IsFrozen")]
    protected Info _IsFrozen;

    public ModelingESigHistoryDetail_Info ESigHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigHistoryDetails), (object) value);
      }
      get
      {
        return (ModelingESigHistoryDetail_Info) this.PropertyGet(nameof (ESigHistoryDetails));
      }
    }

    public Info WhereUsed
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

    public Info DisplayName
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

    public Info ModelingInstanceLocks
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

    public Info FilterTags
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

    public Info AssociatedPackages
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

    public Info InstanceLocked
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

    public Info Description
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

    public ChangeHistory_Info ChangeHistory
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

    public Info IconId
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

    public Info Notes
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

    public Info Name
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

    public Info IsFrozen
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
  }
}
