﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IHoldService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IHoldService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Hold hold,
      Hold_LoadESigDetails_Parameters parameters,
      Hold_Request request,
      out Hold_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Hold hold,
      Hold_Parameters parameters,
      Hold_Request request,
      out Hold_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      HoldMethod[] methods,
      Hold_Request request,
      out Hold_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Hold hold,
      Hold_Request request,
      out Hold_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Hold hold,
      Hold_Request request,
      out Hold_Result result);
  }
}
