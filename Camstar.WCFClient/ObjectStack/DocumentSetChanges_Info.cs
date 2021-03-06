﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentSetChanges_Info
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
  public class DocumentSetChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentSetChanges_Info_DocumentEntryItem")]
    protected DocumentEntryChanges_Info _DocumentEntryItem;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSetChanges_Info_DocumentEntries")]
    protected DocumentEntryChanges_Info _DocumentEntries;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSetChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSetChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;

    public DocumentEntryChanges_Info DocumentEntryItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntryItem), (object) value);
      }
      get
      {
        return (DocumentEntryChanges_Info) this.PropertyGet(nameof (DocumentEntryItem));
      }
    }

    public DocumentEntryChanges_Info DocumentEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntries), (object) value);
      }
      get
      {
        return (DocumentEntryChanges_Info) this.PropertyGet(nameof (DocumentEntries));
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

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
