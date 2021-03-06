﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventLogHistoryDetail
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
  public class EventLogHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "EventLogHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventLogHistoryDetail_CommentType")]
    protected NamedObjectRef _CommentType;
    [DataMember(EmitDefaultValue = false, Name = "EventLogHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventLogHistoryDetail_CreationDate")]
    protected Primitive<DateTime> _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "EventLogHistoryDetail_CreationDateGMT")]
    protected Primitive<DateTime> _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventLogHistoryDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventLogHistoryDetail_Employee")]
    protected NamedObjectRef _Employee;

    public override bool Equals(object obj)
    {
      return obj is EventLogHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((EventLogHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._CommentType, (object) ((EventLogHistoryDetail) obj)._CommentType) && object.Equals((object) this._HistoryId, (object) ((EventLogHistoryDetail) obj)._HistoryId)) && (object.Equals((object) this._CreationDate, (object) ((EventLogHistoryDetail) obj)._CreationDate) && object.Equals((object) this._CreationDateGMT, (object) ((EventLogHistoryDetail) obj)._CreationDateGMT) && (object.Equals((object) this._Comments, (object) ((EventLogHistoryDetail) obj)._Comments) && object.Equals((object) this._Employee, (object) ((EventLogHistoryDetail) obj)._Employee))) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public NamedObjectRef CommentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommentType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CommentType));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<DateTime> CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Primitive<DateTime> CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public NamedObjectRef Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Employee));
      }
    }
  }
}
