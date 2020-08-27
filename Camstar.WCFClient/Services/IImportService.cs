﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IImportService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IImportService
  {
    [OperationContract]
    ResultStatus GetImportContents(
      UserProfile userProfile,
      Import import,
      Import_Parameters parameters,
      Import_Request request,
      out Import_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Import import,
      Import_Parameters parameters,
      Import_Request request,
      out Import_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Import import,
      Import_Parameters parameters,
      Import_Request request,
      out Import_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ImportMethod[] methods,
      Import_Request request,
      out Import_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Import import,
      Import_Request request,
      out Import_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Import import,
      Import_Request request,
      out Import_Result result);
  }
}
