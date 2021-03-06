﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IEmployeeRoleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IEmployeeRoleMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_LoadESigDetails_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      EmployeeRoleMaintMethod[] methods,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result);
  }
}
