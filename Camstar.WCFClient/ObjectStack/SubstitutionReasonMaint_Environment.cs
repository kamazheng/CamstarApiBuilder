﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubstitutionReasonMaint_Environment
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
  public class SubstitutionReasonMaint_Environment : UserCodeMaint_Environment
  {
    [Metadata("Records the reason that the product actually used differed from the product specified for use.\r\n", "SubstitutionReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubstitutionReasonMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SubstitutionReasonMaint_Environment_ObjectListInquiry")]
    [Metadata("Records the reason that the product actually used differed from the product specified for use.\r\n", "SubstitutionReason", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("Records the reason that the product actually used differed from the product specified for use.\r\n", "SubstitutionReasonChanges", false, false, false, "SubstitutionReasonChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubstitutionReasonMaint_Environment_ObjectChanges")]
    protected SubstitutionReasonChanges_Environment _ObjectChanges;

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

    public SubstitutionReasonChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SubstitutionReasonChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
