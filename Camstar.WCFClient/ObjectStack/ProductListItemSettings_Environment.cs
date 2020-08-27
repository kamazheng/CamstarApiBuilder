﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductListItemSettings_Environment
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
  public class ProductListItemSettings_Environment : MaterialListItemSettings_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductListItemSettings_Environment_TypeName")]
    [Metadata("Generic String", "", false, false, true, "String", 16779177, false, false, false, "ProductMaterialListItem")]
    protected new Environment _TypeName;
    [DataMember(EmitDefaultValue = false, Name = "ProductListItemSettings_Environment_ParentName")]
    [Metadata("Generic String", "", false, false, true, "String", 16779249, false, false, false, "BOM")]
    protected new Environment _ParentName;
    [Metadata("Generic String", "", false, false, true, "String", 16779176, false, false, false, "GetProductMaterialListItems")]
    [DataMember(EmitDefaultValue = false, Name = "ProductListItemSettings_Environment_PhantomQueryName")]
    protected new Environment _PhantomQueryName;
    [Metadata("Generic String", "", false, false, true, "String", 1050871, false, false, false, "GetProductMaterialListItems")]
    [DataMember(EmitDefaultValue = false, Name = "ProductListItemSettings_Environment_QueryName")]
    protected new Environment _QueryName;

    public new Environment TypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TypeName));
      }
    }

    public new Environment ParentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentName));
      }
    }

    public new Environment PhantomQueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomQueryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PhantomQueryName));
      }
    }

    public new Environment QueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QueryName));
      }
    }
  }
}
