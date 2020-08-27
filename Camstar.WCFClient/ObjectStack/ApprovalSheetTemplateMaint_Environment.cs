﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetTemplateMaint_Environment
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
  public class ApprovalSheetTemplateMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplateChanges", false, false, false, "ApprovalSheetTemplateChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateMaint_Environment_ObjectChanges")]
    protected ApprovalSheetTemplateChanges_Environment _ObjectChanges;
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateMaint_Environment_ObjectListInquiry")]
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;

    public ApprovalSheetTemplateChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ApprovalSheetTemplateChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

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
  }
}
