﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgBooleanListDetails_Environment
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
  public class ChgBooleanListDetails_Environment : ChangeAttributeDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgBooleanListDetails_Environment_NewValues")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049125, false, true, false, "0")]
    protected Environment _NewValues;

    public Environment NewValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewValues), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewValues));
      }
    }
  }
}
