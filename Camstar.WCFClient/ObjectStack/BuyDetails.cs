﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BuyDetails
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
  public class BuyDetails : ChangeQtyDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "BuyDetails_Qty2")]
    protected new Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "BuyDetails_ReasonCode")]
    protected new NamedObjectRef _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "BuyDetails_ChangeQtyType")]
    protected new Primitive<int> _ChangeQtyType;
    [DataMember(EmitDefaultValue = false, Name = "BuyDetails_AdjustThruput")]
    protected new Primitive<bool> _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "BuyDetails_TypeSortOrder")]
    protected new Primitive<int> _TypeSortOrder;
    [DataMember(EmitDefaultValue = false, Name = "BuyDetails_Qty")]
    protected new Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "BuyDetails_ChargeToStep")]
    protected new NamedSubentityRef _ChargeToStep;

    public override bool Equals(object obj)
    {
      return obj is BuyDetails && object.Equals((object) this._Qty2, (object) ((BuyDetails) obj)._Qty2) && (object.Equals((object) this._ReasonCode, (object) ((BuyDetails) obj)._ReasonCode) && object.Equals((object) this._ChangeQtyType, (object) ((BuyDetails) obj)._ChangeQtyType)) && (object.Equals((object) this._AdjustThruput, (object) ((BuyDetails) obj)._AdjustThruput) && object.Equals((object) this._TypeSortOrder, (object) ((BuyDetails) obj)._TypeSortOrder) && (object.Equals((object) this._Qty, (object) ((BuyDetails) obj)._Qty) && object.Equals((object) this._ChargeToStep, (object) ((BuyDetails) obj)._ChargeToStep))) && base.Equals(obj);
    }

    public new Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
      }
    }

    public new NamedObjectRef ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReasonCode));
      }
    }

    public new Primitive<int> ChangeQtyType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeQtyType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChangeQtyType));
      }
    }

    public new Primitive<bool> AdjustThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdjustThruput), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AdjustThruput));
      }
    }

    public new Primitive<int> TypeSortOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeSortOrder), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TypeSortOrder));
      }
    }

    public new Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }

    public new NamedSubentityRef ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ChargeToStep));
      }
    }
  }
}
