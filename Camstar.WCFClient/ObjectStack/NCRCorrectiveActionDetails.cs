﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCorrectiveActionDetails
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
  public class NCRCorrectiveActionDetails : NCRCommentsDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCorrectiveActionDetails_Comments")]
    protected new Primitive<string> _Comments;

    public override bool Equals(object obj)
    {
      return obj is NCRCorrectiveActionDetails && object.Equals((object) this._Comments, (object) ((NCRCorrectiveActionDetails) obj)._Comments) && base.Equals(obj);
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
