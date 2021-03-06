﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShipHistory_Environment
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
  public class ShipHistory_Environment : MoveHistory_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_Environment_ContainerStatus")]
    [Metadata("Current status of the Container. This value is used to distinguish between Containers that are active, closed and those that have been deleted. \r\nValid values and their meanings are:\r\n0 = Deleted\r\n1 = Active\r\n2 = Closed\r\n3 = In Transit (shipped)\r\n4 = Issued (component)\r\nA deleted Container is one where all of the transactions, including the Create (or Split-to) transaction have been reversed.", "ContainerStatusEnum", false, false, false, "Integer", 1049675, false, false, false, null)]
    protected Environment _ContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_Environment_RemoteContainerStatus")]
    [Metadata("Current status of the Container. This value is used to distinguish between Containers that are active, closed and those that have been deleted. \r\nValid values and their meanings are:\r\n0 = Deleted\r\n1 = Active\r\n2 = Closed\r\n3 = In Transit (shipped)\r\n4 = Issued (component)\r\nA deleted Container is one where all of the transactions, including the Create (or Split-to) transaction have been reversed.", "ContainerStatusEnum", false, false, false, "Integer", 1049676, false, false, false, null)]
    protected Environment _RemoteContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_Environment_ShipmentDestination")]
    [Metadata("A ShipmentDestination is the factory or customer to which the container is shipped. ShipmentDestinaiton also contains routing information used by the RemoteProcessingInfo object when the Ship transaction is sending remote transactions to a destination site.", "ShipmentDestination", false, false, false, "NamedObjectRef", 1049682, false, false, false, null)]
    protected Environment _ShipmentDestination;
    [Metadata("A Customer refers to a company that receives goods and services. A Customer definition typically refers to a company other than your own, but it can also be used for a factory or department that requires goods and services from another factory or department within the enterprise.", "Customer", false, false, false, "NamedObjectRef", 1049681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_Environment_ToCustomer")]
    protected Environment _ToCustomer;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1049677, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_Environment_ToFactory")]
    protected Environment _ToFactory;

    public Environment ContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerStatus));
      }
    }

    public Environment RemoteContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoteContainerStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemoteContainerStatus));
      }
    }

    public Environment ShipmentDestination
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShipmentDestination), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShipmentDestination));
      }
    }

    public Environment ToCustomer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToCustomer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToCustomer));
      }
    }

    public Environment ToFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToFactory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToFactory));
      }
    }
  }
}
