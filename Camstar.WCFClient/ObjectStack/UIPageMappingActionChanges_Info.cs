﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageMappingActionChanges_Info
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
  public class UIPageMappingActionChanges_Info : UIRedirectActionChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingActionChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingActionChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingActionChanges_Info_MapItem")]
    protected Info _MapItem;
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingActionChanges_Info_Name")]
    protected new Info _Name;

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

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info MapItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (MapItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MapItem));
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
