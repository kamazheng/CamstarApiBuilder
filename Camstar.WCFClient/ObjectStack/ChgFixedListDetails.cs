﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFixedListDetails
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
  public class ChgFixedListDetails : ChangeAttributeDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgFixedListDetails_NewValues")]
    protected Primitive<double>[] _NewValues;

    public override bool Equals(object obj)
    {
      return obj is ChgFixedListDetails && this.CompareArrays((Array) this._NewValues, (Array) ((ChgFixedListDetails) obj)._NewValues) && base.Equals(obj);
    }

    public Primitive<double>[] NewValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewValues), (object) value);
      }
      get
      {
        return (Primitive<double>[]) this.PropertyGet(nameof (NewValues));
      }
    }
  }
}
