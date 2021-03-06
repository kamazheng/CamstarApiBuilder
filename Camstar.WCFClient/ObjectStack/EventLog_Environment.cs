﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventLog_Environment
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
  public class EventLog_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EventLog_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventLog_Environment_CommentType")]
    [Metadata("Comment Type for Production Event Log", "CommentType", false, false, true, "NamedObjectRef", 1052953, false, false, false, null)]
    protected Environment _CommentType;
    [DataMember(EmitDefaultValue = false, Name = "EventLog_Environment_CreationDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049059, false, false, false, null)]
    protected Environment _CreationDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052951, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLog_Environment_CreationDateGMT")]
    protected Environment _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventLog_Environment_Comments")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1049480, false, false, false, null)]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventLog_Environment_Employee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048861, false, false, false, null)]
    protected Environment _Employee;

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

    public Environment CommentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommentType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CommentType));
      }
    }

    public Environment CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Environment CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Environment Employee
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
