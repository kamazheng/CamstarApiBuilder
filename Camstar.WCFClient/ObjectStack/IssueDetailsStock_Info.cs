﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueDetailsStock_Info
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
  public class IssueDetailsStock_Info : IssueDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueDetailsStock_Info_Actuals")]
    protected ActualsStock_Info _Actuals;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetailsStock_Info_IssueControl")]
    protected new Info _IssueControl;

    public ActualsStock_Info Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (ActualsStock_Info) this.PropertyGet(nameof (Actuals));
      }
    }

    public new Info IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControl));
      }
    }
  }
}
