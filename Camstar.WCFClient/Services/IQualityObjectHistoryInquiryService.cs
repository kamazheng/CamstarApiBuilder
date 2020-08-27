﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IQualityObjectHistoryInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IQualityObjectHistoryInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      QualityObjectHistoryInquiry qualityObjectHistoryInquiry,
      QualityObjectHistoryInquiry_Parameters parameters,
      QualityObjectHistoryInquiry_Request request,
      out QualityObjectHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      QualityObjectHistoryInquiryMethod[] methods,
      QualityObjectHistoryInquiry_Request request,
      out QualityObjectHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      QualityObjectHistoryInquiry qualityObjectHistoryInquiry,
      QualityObjectHistoryInquiry_Request request,
      out QualityObjectHistoryInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      QualityObjectHistoryInquiry qualityObjectHistoryInquiry,
      QualityObjectHistoryInquiry_Request request,
      out QualityObjectHistoryInquiry_Result result);
  }
}
