﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RolePermissionsMaint_AddPermissions_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class RolePermissionsMaint_AddPermissions_Parameters : RolePermissionsMaint_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "Permission")]
    protected string _Permission;

    public string Permission
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permission), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Permission));
      }
    }
  }
}
