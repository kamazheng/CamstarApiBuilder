﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_AuditTrailSecPermission_Info
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
  public class V4_AuditTrailSecPermission_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_AuditTrailSecPermission_Info_NewValue")]
    protected Info _NewValue;
    [DataMember(EmitDefaultValue = false, Name = "V4_AuditTrailSecPermission_Info_OldValue")]
    protected Info _OldValue;
    [DataMember(EmitDefaultValue = false, Name = "V4_AuditTrailSecPermission_Info_Name")]
    protected Info _Name;

    public Info NewValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewValue));
      }
    }

    public Info OldValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldValue));
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
  }
}
