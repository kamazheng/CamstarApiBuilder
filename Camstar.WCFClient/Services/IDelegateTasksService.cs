﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDelegateTasksService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDelegateTasksService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DelegateTasks delegateTasks,
      DelegateTasks_LoadESigDetails_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      DelegateTasks delegateTasks,
      DelegateTasks_Parameters parameters,
      DelegateTasks_Request request,
      out DelegateTasks_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DelegateTasksMethod[] methods,
      DelegateTasks_Request request,
      out DelegateTasks_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DelegateTasks delegateTasks,
      DelegateTasks_Request request,
      out DelegateTasks_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DelegateTasks delegateTasks,
      DelegateTasks_Request request,
      out DelegateTasks_Result result);
  }
}
