﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceThruputHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ResourceThruputHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Environment_HistoryDetails")]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049574, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Environment_Qty2")]
    protected Environment _Qty2;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Environment_UOM")]
    protected Environment _UOM;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Environment_UOM2")]
    protected Environment _UOM2;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1048840, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Environment_Resource")]
    protected Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Environment_Run")]
    [Metadata("Current Setup number. This value is used to identify all of the work that is performed using a specific Setup. The value is set (incremented) as part of the Resource Setup transaction. All Throughput and Movement transactions record this value in their history transactions.", "", false, false, true, "String", 1048668, false, false, false, null)]
    protected Environment _Run;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1048625, false, false, false, null)]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Environment_Qty")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048836, false, false, false, null)]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Environment_MfgOrder")]
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, true, "NamedObjectRef", 1048810, false, false, false, null)]
    protected Environment _MfgOrder;
    [Metadata("A Setup is a configuration of a resource needed to process a certain type of material (typcially a particular product, or a container referencing a particular spec)..  Normally the definition of a setup includes only items as hardware configurations, that take significant time to change, while a reciipe would include many other items such as process settings that may be changed instantly.\r\n\r\nStandard Camstar-provided attributes of a setup  include items such as the applicable set of documents describing the setup configuration, an estimate of time need to configure the setup, etc.  Setups are often defined in InSite to help provide scheduling/dispatching information on which containers/orders may be processed without significant changeover time between the items.\r\n\r\n", "Setup", false, false, true, "RevisionedObjectRef", 1049008, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruputHistory_Environment_Setup")]
    protected Environment _Setup;

    public new ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2));
      }
    }

    public Environment UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM));
      }
    }

    public Environment UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM2));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Resource));
      }
    }

    public Environment Run
    {
      [param: In] set
      {
        this.PropertySet(nameof (Run), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Run));
      }
    }

    public Environment Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Product));
      }
    }

    public Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }

    public Environment MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public Environment Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Setup));
      }
    }
  }
}
