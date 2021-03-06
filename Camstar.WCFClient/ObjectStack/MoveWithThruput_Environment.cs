﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveWithThruput_Environment
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
  public class MoveWithThruput_Environment : CompoundTxn_Environment
  {
    [Metadata("This move transaction will adds the requirement that there is a path defined between the current step and the ToStep.", "MoveStd", false, false, false, "MoveStd", 1049815, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_Move")]
    protected MoveStd_Environment _Move;
    [Metadata("The thruput transaction enables the separation of reporting processing of a container from reporting movement of a container.  The thruput transaction will be most often used in implementations where a container is processed on multiple machines at once, or when the processing of the container is spread out over multiple shifts, and the tracking of how much matierial each shift/resource processed is critical.", "Thruput", false, false, false, "Thruput", 1049816, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_Thruput")]
    protected Thruput_Environment _Thruput;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_MfgProcessOverrides")]
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, false, "RevisionedObjectRef", 1050936, false, false, false, null)]
    protected new Environment _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_PrintQueue")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, true, "NamedObjectRef", 1050609, false, false, true, null)]
    protected new Environment _PrintQueue;
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, false, "NamedSubentityRef", 1049032, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_Step")]
    protected Environment _Step;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_NavigationMode")]
    [Metadata("Workflow navigation mode determines whether to use a regular Path or a ReworkPath during Move transactions.\r\nPossible navigational modes are:\r\nStandard = 1\r\nRework = 2", "WorkflowNavigationModeEnum", false, false, false, "Integer", 1050306, false, false, false, null)]
    protected Environment _NavigationMode;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_Close")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049202, false, false, false, "0")]
    protected Environment _Close;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049211, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_MoveAllQty")]
    protected Environment _MoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_OverrideCurrentStatus")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049219, false, false, false, "0")]
    protected Environment _OverrideCurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_ThruputAllQty")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049283, false, false, false, "1")]
    protected Environment _ThruputAllQty;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048852, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_UnitCount")]
    protected Environment _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_ChildCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048770, false, false, false, null)]
    protected Environment _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1049055, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_ToResource")]
    protected Environment _ToResource;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_ToWorkflow")]
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1049622, false, false, true, null)]
    protected Environment _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_Operation")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    protected Environment _Operation;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1048660, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_Location")]
    protected Environment _Location;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_Path")]
    [Metadata("A Path defines an allowable (Standard) move from one Step to another within a Workflow. Each Step contains zero or more (outbound) Paths. Only one of the Paths is the default Path, all others are alternate paths. If a Step contains any Paths, one must be the default. The default Route for a Workflow is determined by traversing through the Steps, starting at the first Step (defined in the workflow), using the default Path for each.\r\n\r\nPaths are referenced by name or by Id. Path names are unique within the context of their Step.", "MovePath", false, false, false, "NamedSubentityRef", 1049030, false, false, true, null)]
    protected Environment _Path;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_ToLocation")]
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049216, false, false, true, null)]
    protected Environment _ToLocation;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1048929, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_ToStep")]
    protected Environment _ToStep;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Environment_Resource")]
    protected Environment _Resource;

    public MoveStd_Environment Move
    {
      [param: In] set
      {
        this.PropertySet(nameof (Move), (object) value);
      }
      get
      {
        return (MoveStd_Environment) this.PropertyGet(nameof (Move));
      }
    }

    public Thruput_Environment Thruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (Thruput), (object) value);
      }
      get
      {
        return (Thruput_Environment) this.PropertyGet(nameof (Thruput));
      }
    }

    public new Environment MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public new Environment PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Environment Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Step));
      }
    }

    public Environment NavigationMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NavigationMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NavigationMode));
      }
    }

    public Environment Close
    {
      [param: In] set
      {
        this.PropertySet(nameof (Close), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Close));
      }
    }

    public Environment MoveAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (MoveAllQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MoveAllQty));
      }
    }

    public Environment OverrideCurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideCurrentStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OverrideCurrentStatus));
      }
    }

    public Environment ThruputAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAllQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputAllQty));
      }
    }

    public Environment UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Environment ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildCount));
      }
    }

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public Environment ToResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToResource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToResource));
      }
    }

    public Environment ToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToWorkflow));
      }
    }

    public Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }

    public Environment Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Location));
      }
    }

    public Environment Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Path));
      }
    }

    public Environment ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToLocation));
      }
    }

    public Environment ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStep));
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
  }
}
