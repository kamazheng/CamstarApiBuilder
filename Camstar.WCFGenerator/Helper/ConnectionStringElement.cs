﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.ConnectionStringElement
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System.Configuration;

namespace Camstar.WCF.Generator.Helper
{
  public class ConnectionStringElement : ConfigurationElement
  {
    private const string ConnectionStringNameProperty = "Name";
    private const string ConnectionStringValueProperty = "Value";

    [ConfigurationProperty("Name")]
    public string Name
    {
      get
      {
        return (string) this[nameof (Name)];
      }
      set
      {
        this[nameof (Name)] = (object) value;
      }
    }

    [ConfigurationProperty("Value")]
    public string Value
    {
      get
      {
        return (string) this[nameof (Value)];
      }
      set
      {
        this[nameof (Value)] = (object) value;
      }
    }
  }
}
