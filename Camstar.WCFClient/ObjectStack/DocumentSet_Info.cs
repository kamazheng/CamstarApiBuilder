﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentSet_Info
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
  public class DocumentSet_Info : NamedDataObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentSet_Info_ModelingInstanceLocks")]
    protected new Info _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSet_Info_FilterTags")]
    protected new Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSet_Info_AssociatedPackages")]
    protected new Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSet_Info_InstanceLocked")]
    protected new Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSet_Info_IconId")]
    protected new Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSet_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSet_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSet_Info_Notes")]
    protected new Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSet_Info_DocumentEntries")]
    protected DocumentEntry_Info _DocumentEntries;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSet_Info_ChangeHistory")]
    protected new ChangeHistory_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSet_Info_IsFrozen")]
    protected new Info _IsFrozen;

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

    public DocumentEntry_Info DocumentEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntries), (object) value);
      }
      get
      {
        return (DocumentEntry_Info) this.PropertyGet(nameof (DocumentEntries));
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
  }
}
