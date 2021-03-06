﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDisassociateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDisassociateService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Disassociate disassociate,
      Disassociate_LoadESigDetails_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DisassociateMethod[] methods,
      Disassociate_Request request,
      out Disassociate_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Disassociate disassociate,
      Disassociate_Request request,
      out Disassociate_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Disassociate disassociate,
      Disassociate_Request request,
      out Disassociate_Result result);
  }
}
