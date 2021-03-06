﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeHistory_Info
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
  public class ChangeHistory_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Info_LastChangeDate")]
    protected Info _LastChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Info_LastChangeDateGMT")]
    protected Info _LastChangeDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Info_User")]
    protected Info _User;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Info_Notes")]
    protected Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Info_Control")]
    protected Info _Control;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Info_CurrentStatus")]
    protected Info _CurrentStatus;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info LastChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastChangeDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastChangeDate));
      }
    }

    public Info LastChangeDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastChangeDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastChangeDateGMT));
      }
    }

    public Info User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (User));
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

    public Info Control
    {
      [param: In] set
      {
        this.PropertySet(nameof (Control), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Control));
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

    public Info CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentStatus));
      }
    }
  }
}
