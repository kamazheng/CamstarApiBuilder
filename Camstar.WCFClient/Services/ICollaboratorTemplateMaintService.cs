﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICollaboratorTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICollaboratorTemplateMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_LoadESigDetails_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Parameters parameters,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CollaboratorTemplateMaintMethod[] methods,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CollaboratorTemplateMaint collaboratorTemplateMaint,
      CollaboratorTemplateMaint_Request request,
      out CollaboratorTemplateMaint_Result result);
  }
}
