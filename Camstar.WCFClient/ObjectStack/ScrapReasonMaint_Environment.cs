﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScrapReasonMaint_Environment
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
  public class ScrapReasonMaint_Environment : UserCodeMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ScrapReasonMaint_Environment_ObjectToChange")]
    [Metadata("This is not implemented in the current version of InSite.\r\n\r\nScrapReason", "ScrapReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Changes CDO for ScrapReason.", "ScrapReasonChanges", false, false, false, "ScrapReasonChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScrapReasonMaint_Environment_ObjectChanges")]
    protected ScrapReasonChanges_Environment _ObjectChanges;
    [Metadata("This is not implemented in the current version of InSite.\r\n\r\nScrapReason", "ScrapReason", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScrapReasonMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public ScrapReasonChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ScrapReasonChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
