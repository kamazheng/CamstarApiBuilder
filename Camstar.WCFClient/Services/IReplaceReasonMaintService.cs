﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReplaceReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReplaceReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_LoadESigDetails_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Parameters parameters,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReplaceReasonMaintMethod[] methods,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ReplaceReasonMaint replaceReasonMaint,
      ReplaceReasonMaint_Request request,
      out ReplaceReasonMaint_Result result);
  }
}
