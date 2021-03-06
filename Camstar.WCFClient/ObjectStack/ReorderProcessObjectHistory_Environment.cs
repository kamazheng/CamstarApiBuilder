﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReorderProcessObjectHistory_Environment
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
  public class ReorderProcessObjectHistory_Environment : ProcessObjectTxnHistory_Environment
  {
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1051298, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistory_Environment_QualityObject")]
    protected new Environment _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("History details of the Reorder ProcessObject transaction", "ReorderProcessObjectHistDetail", false, false, false, "ReorderProcessObjectHistDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistory_Environment_HistoryDetails")]
    protected ReorderProcessObjectHistDetail_Environment _HistoryDetails;
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, true, "NamedSubentityRef", 1051396, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistory_Environment_ProcessObject")]
    protected new Environment _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistory_Environment_Employee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048861, false, false, false, null)]
    protected new Environment _Employee;

    public new Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public ReorderProcessObjectHistDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ReorderProcessObjectHistDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Environment ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public new Environment Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Employee));
      }
    }
  }
}
