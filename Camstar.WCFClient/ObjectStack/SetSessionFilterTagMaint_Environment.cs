﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SetSessionFilterTagMaint_Environment
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
  public class SetSessionFilterTagMaint_Environment : EmployeeMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagMaint_Environment_ObjectChanges")]
    [Metadata("Update SessionFilter Tag Changes", "SetSessionFilterTagChanges", false, false, false, "SetSessionFilterTagChanges", 1048873, true, false, false, null)]
    protected SetSessionFilterTagChanges_Environment _ObjectChanges;
    [Metadata("Generic String", "", false, false, false, "String", 1050975, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagMaint_Environment_SyncName")]
    protected new Environment _SyncName;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public SetSessionFilterTagChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SetSessionFilterTagChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment SyncName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SyncName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SyncName));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
