﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IExportService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IExportService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Export export,
      Export_Parameters parameters,
      Export_Request request,
      out Export_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Export export,
      Export_Parameters parameters,
      Export_Request request,
      out Export_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ExportMethod[] methods,
      Export_Request request,
      out Export_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Export export,
      Export_Request request,
      out Export_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Export export,
      Export_Request request,
      out Export_Result result);
  }
}
