﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IEndCollaborationService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IEndCollaborationService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      EndCollaboration endCollaboration,
      EndCollaboration_Parameters parameters,
      EndCollaboration_Request request,
      out EndCollaboration_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      EndCollaborationMethod[] methods,
      EndCollaboration_Request request,
      out EndCollaboration_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      EndCollaboration endCollaboration,
      EndCollaboration_Request request,
      out EndCollaboration_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      EndCollaboration endCollaboration,
      EndCollaboration_Request request,
      out EndCollaboration_Result result);
  }
}
