﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ServiceDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ESigServiceDetail))]
  [KnownType(typeof (DispositionSummary))]
  [KnownType(typeof (AvailableLotDetail))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (SerializeDetails))]
  [KnownType(typeof (StartDetails))]
  [KnownType(typeof (StartContainerAttributeDetail))]
  [KnownType(typeof (SplitDetails))]
  [KnownType(typeof (TargetDeploymentDetail))]
  [KnownType(typeof (TargetSystemDetail))]
  [KnownType(typeof (CPModelingInstanceDtl))]
  [KnownType(typeof (ExecuteChecklistDetail))]
  [KnownType(typeof (ExecuteChklstResponseDtl))]
  [KnownType(typeof (AttachDocumentDetails))]
  [KnownType(typeof (IssueDetails))]
  [KnownType(typeof (ESigCaptureDetail))]
  [KnownType(typeof (LabelSummary))]
  [KnownType(typeof (ChangeAttributeDetails))]
  [KnownType(typeof (AttachedDocDetail))]
  [KnownType(typeof (ChecklistEntryDetails))]
  [KnownType(typeof (LabelDetails))]
  [KnownType(typeof (ParametricData))]
  [KnownType(typeof (ApprovalSheetDetails))]
  [KnownType(typeof (MaintReqActivationDetails))]
  [KnownType(typeof (NCRUpdateDetail))]
  [KnownType(typeof (NCRCommentsDetails))]
  [KnownType(typeof (QualityCrossRefDetail))]
  [KnownType(typeof (CAPADetail))]
  [KnownType(typeof (DispositionDetail))]
  [KnownType(typeof (FailureDetails))]
  [KnownType(typeof (FailureCauseDetails))]
  [KnownType(typeof (FailurePlanDetails))]
  [KnownType(typeof (ReorderProcessObjectDetail))]
  [KnownType(typeof (DecisionTreeDetail))]
  [KnownType(typeof (QualityCrossReferenceDetail))]
  [KnownType(typeof (ApprovalEntryDetails))]
  [KnownType(typeof (PermissionDetail))]
  [KnownType(typeof (ESigProcessTimerServiceDetail))]
  [KnownType(typeof (CompleteMaintDetails))]
  [KnownType(typeof (RecordSPCViolationDetail))]
  [KnownType(typeof (SPCViolationDetail))]
  [KnownType(typeof (ThruputDetail))]
  [KnownType(typeof (ChangeQtyDetails))]
  [KnownType(typeof (DPCollectionGroupDetail))]
  [KnownType(typeof (DPCollectionPointDetail))]
  [KnownType(typeof (DPCollectionSampleDetail))]
  [KnownType(typeof (UserQueryParameterValues))]
  [KnownType(typeof (ChgContainerAttrDetail))]
  [KnownType(typeof (CollectSamplingDataDetails))]
  [KnownType(typeof (SamplingDataPointDetails))]
  [KnownType(typeof (QualityESigDetail))]
  [KnownType(typeof (EventDetail))]
  [KnownType(typeof (RegulatoryReportDetail))]
  [KnownType(typeof (EventDataDetails))]
  [KnownType(typeof (EventLotDetail))]
  [KnownType(typeof (NCRDefectDetails))]
  [KnownType(typeof (EventComponentDetail))]
  [KnownType(typeof (EventDispositionDetail))]
  [KnownType(typeof (EventFailureDetail))]
  [KnownType(typeof (EventFailureCauseDetail))]
  [KnownType(typeof (EventFailureActionDetail))]
  [KnownType(typeof (EventLogDetail))]
  [KnownType(typeof (EventCheckBoxField))]
  [KnownType(typeof (QualityCustomDetail))]
  [KnownType(typeof (SuspectDeviceDetail))]
  [KnownType(typeof (CustomerDetail))]
  [KnownType(typeof (PrintLabelDetails))]
  [KnownType(typeof (CombineFromDetail))]
  [KnownType(typeof (ComponentDistributeDestination))]
  [KnownType(typeof (IssueActualDetail))]
  [KnownType(typeof (ComputationDetail))]
  [KnownType(typeof (ComputationParamDetail))]
  [KnownType(typeof (ChangePackageDetail))]
  [KnownType(typeof (DefectDetail))]
  [KnownType(typeof (ContainerHistoryInquiryDetail))]
  [KnownType(typeof (DictionaryServiceDetail))]
  [KnownType(typeof (CollaboratorDetails))]
  [KnownType(typeof (CollaboratorEntryDetails))]
  [KnownType(typeof (LabelCategoryDetails))]
  [KnownType(typeof (IssueActuals))]
  [KnownType(typeof (CompletedTaskDetail))]
  [KnownType(typeof (RemovalCandidate))]
  [KnownType(typeof (RemovalDetail))]
  [KnownType(typeof (ComponentReplaceDetail))]
  [KnownType(typeof (ContainerAttrDetail))]
  [Serializable]
  public class ServiceDetails : ServiceData
  {
    public override bool Equals(object obj)
    {
      return obj is ServiceDetails && base.Equals(obj);
    }
  }
}