﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MenuCommandChanges_Info
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
  public class MenuCommandChanges_Info : MenuItemChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MenuCommandChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuCommandChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuCommandChanges_Info_Sequence")]
    protected new Info _Sequence;

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

    public new Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }
  }
}
