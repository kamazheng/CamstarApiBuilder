﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRevisionedObjectGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRevisionedObjectGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_LoadESigDetails_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Parameters parameters,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RevisionedObjectGroupMaintMethod[] methods,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RevisionedObjectGroupMaint revisionedObjectGroupMaint,
      RevisionedObjectGroupMaint_Request request,
      out RevisionedObjectGroupMaint_Result result);
  }
}
