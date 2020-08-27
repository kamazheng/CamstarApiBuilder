﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteMaintenanceHistory_Info
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
  public class CompleteMaintenanceHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_Info_HistoryDetails")]
    protected CompleteMaintHistoryDetails_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_Info_ResetAll")]
    protected Info _ResetAll;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_Info_ForceMaintenance")]
    protected Info _ForceMaintenance;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_Info_HistoryId")]
    protected new Info _HistoryId;

    public CompleteMaintHistoryDetails_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (CompleteMaintHistoryDetails_Info) this.PropertyGet(nameof (HistoryDetails));
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

    public Info ResetAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResetAll), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResetAll));
      }
    }

    public Info ForceMaintenance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForceMaintenance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ForceMaintenance));
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
  }
}
