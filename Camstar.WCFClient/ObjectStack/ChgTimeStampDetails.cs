﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgTimeStampDetails
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
  public class ChgTimeStampDetails : ChangeAttributeDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampDetails_NewValue")]
    protected Primitive<DateTime> _NewValue;

    public override bool Equals(object obj)
    {
      return obj is ChgTimeStampDetails && object.Equals((object) this._NewValue, (object) ((ChgTimeStampDetails) obj)._NewValue) && base.Equals(obj);
    }

    public Primitive<DateTime> NewValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewValue), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (NewValue));
      }
    }
  }
}
