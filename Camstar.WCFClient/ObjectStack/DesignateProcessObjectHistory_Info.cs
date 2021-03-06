﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DesignateProcessObjectHistory_Info
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
  public class DesignateProcessObjectHistory_Info : ProcessObjectTxnHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Info_QualityObject")]
    protected new Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Info_FromRole")]
    protected Info _FromRole;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Info_ToRole")]
    protected Info _ToRole;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Info_ProcessObject")]
    protected new Info _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Info_AssigneeOption")]
    protected Info _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Info_Employee")]
    protected new Info _Employee;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Info_FromUser")]
    protected Info _FromUser;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Info_ToUser")]
    protected Info _ToUser;

    public new Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new ServiceHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Info FromRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromRole));
      }
    }

    public Info ToRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToRole));
      }
    }

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

    public new Info ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public Info AssigneeOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssigneeOption));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public new Info Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Employee));
      }
    }

    public Info FromUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromUser), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromUser));
      }
    }

    public Info ToUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToUser), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToUser));
      }
    }
  }
}
