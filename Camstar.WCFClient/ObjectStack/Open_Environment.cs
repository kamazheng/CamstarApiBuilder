﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Open_Environment
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
  public class Open_Environment : ContainerStatusChange_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Open_Environment_IncludeChildren")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049124, false, false, false, "0")]
    protected new Environment _IncludeChildren;

    public new Environment IncludeChildren
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeChildren), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeChildren));
      }
    }
  }
}
