﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgLabelKeyChanges_Info
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
  public class WIPMsgLabelKeyChanges_Info : WIPMsgKeyChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKeyChanges_Info_Label")]
    protected Info _Label;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKeyChanges_Info_WIPMsgDetails")]
    protected new WIPMsgDetailChanges_Info _WIPMsgDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKeyChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;

    public Info Label
    {
      [param: In] set
      {
        this.PropertySet(nameof (Label), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Label));
      }
    }

    public new WIPMsgDetailChanges_Info WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (WIPMsgDetailChanges_Info) this.PropertyGet(nameof (WIPMsgDetails));
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
  }
}
