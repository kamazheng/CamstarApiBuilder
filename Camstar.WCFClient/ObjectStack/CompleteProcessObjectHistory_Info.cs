﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteProcessObjectHistory_Info
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
  public class CompleteProcessObjectHistory_Info : ProcessObjectTxnHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_Info_QualityObject")]
    protected new Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_Info_ProcessObject")]
    protected new Info _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_Info_CompletionComments")]
    protected Info _CompletionComments;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_Info_Employee")]
    protected new Info _Employee;

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

    public Info CompletionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionComments));
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
  }
}
