﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IVoidCPStatusesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IVoidCPStatusesService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_LoadESigDetails_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Parameters parameters,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      VoidCPStatusesMethod[] methods,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      VoidCPStatuses voidCPStatuses,
      VoidCPStatuses_Request request,
      out VoidCPStatuses_Result result);
  }
}
