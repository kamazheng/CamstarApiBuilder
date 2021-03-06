﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IViewContainerService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IViewContainerService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ViewContainer viewContainer,
      ViewContainer_Parameters parameters,
      ViewContainer_Request request,
      out ViewContainer_Result result);

    [OperationContract]
    ResultStatus ValidateUserPermission(
      UserProfile userProfile,
      ViewContainer viewContainer,
      ViewContainer_Parameters parameters,
      ViewContainer_Request request,
      out ViewContainer_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ViewContainerMethod[] methods,
      ViewContainer_Request request,
      out ViewContainer_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ViewContainer viewContainer,
      ViewContainer_Request request,
      out ViewContainer_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ViewContainer viewContainer,
      ViewContainer_Request request,
      out ViewContainer_Result result);
  }
}
