﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseTemplateMaint_Info
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
  public class PhaseTemplateMaint_Info : ProcessObjectTemplateMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_Info_ObjectChanges")]
    protected PhaseTemplateChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_Info_ApprovalSheetTemplate")]
    protected Info _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_Info_ProcessObjectTemplateDetails")]
    protected PhaseTemplate_Info _ProcessObjectTemplateDetails;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_Info_ValidChildTypes")]
    protected new Info _ValidChildTypes;

    public PhaseTemplateChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PhaseTemplateChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Info ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public new Info ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public PhaseTemplate_Info ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (PhaseTemplate_Info) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }

    public new Info ValidChildTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidChildTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ValidChildTypes));
      }
    }
  }
}
