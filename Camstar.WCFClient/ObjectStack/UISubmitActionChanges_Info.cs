﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UISubmitActionChanges_Info
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
  public class UISubmitActionChanges_Info : UIActionChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UISubmitActionChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UISubmitActionChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UISubmitActionChanges_Info_ClearValues")]
    protected Info _ClearValues;
    [DataMember(EmitDefaultValue = false, Name = "UISubmitActionChanges_Info_IsReturn")]
    protected Info _IsReturn;
    [DataMember(EmitDefaultValue = false, Name = "UISubmitActionChanges_Info_Name")]
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

    public Info ClearValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearValues), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ClearValues));
      }
    }

    public Info IsReturn
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsReturn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsReturn));
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
