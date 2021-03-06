﻿// Decompiled with JetBrains decompiler
// Type: Camstar.Utility.ServerConnectionSettings
// Assembly: Camstar.Utility, Version=7.8.7004.31020, Culture=neutral, PublicKeyToken=null
// MVID: AF6B540D-12F7-4E34-9655-933F6DAB67E3
// Assembly location: E:\WCFServicesGenerator\Camstar.Utility.dll

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Caching;
using System.Threading;
using System.Xml;

namespace Camstar.Utility
{
  public class ServerConnectionSettings
  {
    private string _Host = "localhost";
    private int _Port = 2881;
    private string _appServerUriStem = "/camstarappserver/api/";
    private int _SendTimeout = 90000;
    private int _ReceiveTimeout = 90000;
    private string _XMLLogPath = "C:\\Temp";
    private int _changeNumber = ServerConnectionSettings.s_ChangeNumber;
    private static EventLog s_EventLog = (EventLog) null;
    private static ServerConnectionSettings s_DefaultSettings = new ServerConnectionSettings();
    private static string s_DefaultConfigurationFile = (string) null;
    private static HostFileChangeMonitor s_Monitor = (HostFileChangeMonitor) null;
    private static int s_ChangeNumber = 0;
    private ApplicationProtocol _applicationProtocol;
    private bool _LogXml;
    private bool _fIgnoreInvalidCert;

    static ServerConnectionSettings()
    {
      try
      {
        if (!EventLog.SourceExists("InSite Server Connection Library"))
          EventLog.CreateEventSource("InSite Server Connection Library", "Camstar");
        ServerConnectionSettings.s_EventLog = new EventLog("Camstar");
        ServerConnectionSettings.s_EventLog.Source = "InSite Server Connection Library";
      }
      catch (Exception ex)
      {
        Trace.TraceError(string.Format("Error creating/modifying the event log.\r\n{0}", (object) ex.ToString()));
        EventLog eventLog = ServerConnectionSettings.s_EventLog;
      }
      try
      {
        RegistryKey localMachine = Registry.LocalMachine;
        RegistryKey registryKey1 = localMachine.OpenSubKey("SOFTWARE\\Camstar\\Camstar InSite Server Connection", false);
        if (registryKey1 != null)
          ServerConnectionSettings.s_DefaultConfigurationFile = (string) registryKey1.GetValue("ConfigPath");
        if (string.IsNullOrEmpty(ServerConnectionSettings.s_DefaultConfigurationFile))
        {
          RegistryKey registryKey2 = localMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Camstar\\Camstar InSite Server Connection", false);
          if (registryKey2 != null)
            ServerConnectionSettings.s_DefaultConfigurationFile = (string) registryKey2.GetValue("ConfigPath");
        }
      }
      catch (Exception ex1)
      {
        try
        {
          string message = string.Format("Getting config file name from the registry\r\n{0}", (object) ex1.ToString());
          Trace.TraceWarning(message);
          if (ServerConnectionSettings.s_EventLog != null)
            ServerConnectionSettings.s_EventLog.WriteEntry(message, EventLogEntryType.Warning);
        }
        catch (Exception ex2)
        {
          Trace.TraceError(string.Format("Error writing to the event log. \r\n{0}", (object) ex2.ToString()));
        }
      }
      ServerConnectionSettings.LoadConfigSettings(ServerConnectionSettings.s_DefaultConfigurationFile);
      try
      {
        ServerConnectionSettings.s_Monitor = new HostFileChangeMonitor((IList<string>) new List<string>()
        {
          ServerConnectionSettings.s_DefaultConfigurationFile
        });
        ServerConnectionSettings.s_Monitor.NotifyOnChanged(new OnChangedCallback(ServerConnectionSettings.OnConfigFileChanged));
      }
      catch (Exception ex)
      {
        string message = string.Format("Error establishing change notifications\r\n{0}", (object) ex.ToString());
        Trace.TraceWarning(message);
        if (ServerConnectionSettings.s_EventLog == null)
          return;
        ServerConnectionSettings.s_EventLog.WriteEntry(message, EventLogEntryType.Warning);
      }
    }

    public ServerConnectionSettings Clone()
    {
      return (ServerConnectionSettings) this.MemberwiseClone();
    }

    public static EventLog EventLog
    {
      get
      {
        return ServerConnectionSettings.s_EventLog;
      }
    }

    public string Host
    {
      get
      {
        return this._Host;
      }
      set
      {
        if (string.IsNullOrEmpty(value))
          return;
        this._Host = value;
      }
    }

    public int Port
    {
      get
      {
        return this._Port;
      }
      set
      {
        if (0 > value || value > (int) ushort.MaxValue)
          return;
        this._Port = value;
      }
    }

    public ApplicationProtocol Protocol
    {
      get
      {
        return this._applicationProtocol;
      }
      set
      {
        this._applicationProtocol = value;
      }
    }

    public string AppServerUriStem
    {
      get
      {
        return this._appServerUriStem;
      }
      set
      {
        this._appServerUriStem = value;
      }
    }

    public int SendTimeout
    {
      get
      {
        return this._SendTimeout;
      }
      set
      {
        this._SendTimeout = value;
      }
    }

    public int ReceiveTimeout
    {
      get
      {
        return this._ReceiveTimeout;
      }
      set
      {
        this._ReceiveTimeout = value;
      }
    }

    public string XMLLogPath
    {
      get
      {
        return this._XMLLogPath;
      }
      set
      {
        if (string.IsNullOrEmpty(value))
          return;
        try
        {
          if (!Directory.Exists(value))
            Directory.CreateDirectory(value);
          this._XMLLogPath = value;
        }
        catch (Exception ex)
        {
          string message = string.Format("Error checking log directory\r\n{0}", (object) ex.ToString());
          Trace.TraceWarning(message);
          if (ServerConnectionSettings.s_EventLog == null)
            return;
          ServerConnectionSettings.s_EventLog.WriteEntry(message, EventLogEntryType.Warning);
        }
      }
    }

    public bool LogXml
    {
      get
      {
        return this._LogXml;
      }
      set
      {
        this._LogXml = value;
      }
    }

    public bool IgnoreInvalidCert
    {
      get
      {
        return this._fIgnoreInvalidCert;
      }
      set
      {
        this._fIgnoreInvalidCert = value;
      }
    }

    public int ChangeNumber
    {
      get
      {
        return this._changeNumber;
      }
      protected set
      {
        this._changeNumber = value;
      }
    }

    private static bool LoadConfigSettings(string settingsFile)
    {
      if (string.IsNullOrWhiteSpace(settingsFile) || !File.Exists(settingsFile))
        return false;
      XmlDocument xmlDocument = (XmlDocument) null;
      FileStream fileStream = (FileStream) null;
      bool flag1;
      try
      {
        bool flag2 = false;
        int num = 0;
        string message1 = string.Empty;
        do
        {
          try
          {
            xmlDocument = new XmlDocument();
            fileStream = new FileStream(settingsFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
            xmlDocument.Load((Stream) fileStream);
          }
          catch (IOException ex)
          {
            xmlDocument = (XmlDocument) null;
            message1 = string.Format("Error reading cconfiguration file\r\n{0}\r\n{1}", (object) ex.HResult, (object) ex.ToString());
            Trace.TraceWarning(message1);
            if (-2147024864 == ex.HResult)
              flag2 = true;
          }
          catch (Exception ex)
          {
            xmlDocument = (XmlDocument) null;
            message1 = string.Format("Error reading cconfiguration file\r\n{0}", (object) ex.ToString());
            Trace.TraceWarning(message1);
          }
          finally
          {
            if (fileStream != null)
            {
              fileStream.Dispose();
              fileStream = (FileStream) null;
            }
          }
        }
        while (flag2 && 10 > num++);
        if (xmlDocument == null)
        {
          if (ServerConnectionSettings.s_EventLog != null)
            ServerConnectionSettings.s_EventLog.WriteEntry(string.IsNullOrEmpty(message1) ? "Unknown error reading config file" : message1, EventLogEntryType.Warning);
          return false;
        }
        ServerConnectionSettings defaultSettings = ServerConnectionSettings.DefaultSettings;
        XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("ServerConnection");
        if (elementsByTagName != null && elementsByTagName.Count > 0)
        {
          foreach (XmlNode xmlNode in elementsByTagName[0])
          {
            if (!string.IsNullOrWhiteSpace(xmlNode.InnerText))
            {
              string str = xmlNode.InnerText.Trim();
              string name = xmlNode.Name;
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(name))
              {
                case 102951349:
                  if (name == "ApplicationProtocol")
                  {
                    int result = 0;
                    if (int.TryParse(str, out result))
                    {
                      defaultSettings._applicationProtocol = (ApplicationProtocol) result;
                      continue;
                    }
                    continue;
                  }
                  continue;
                case 269898621:
                  if (name == "IgnoreInvalidCerts")
                  {
                    bool result = false;
                    if (bool.TryParse(str, out result))
                    {
                      defaultSettings._fIgnoreInvalidCert = result;
                      continue;
                    }
                    continue;
                  }
                  continue;
                case 808120719:
                  if (name == "Host")
                  {
                    defaultSettings._Host = str;
                    continue;
                  }
                  continue;
                case 1331647074:
                  if (name == "SendTimeout")
                  {
                    int result = 0;
                    if (int.TryParse(str, out result))
                    {
                      defaultSettings._SendTimeout = result;
                      continue;
                    }
                    continue;
                  }
                  continue;
                case 1606619994:
                  if (name == "LogXML")
                  {
                    bool result = false;
                    if (bool.TryParse(str, out result))
                    {
                      defaultSettings._LogXml = result;
                      continue;
                    }
                    continue;
                  }
                  continue;
                case 2378346075:
                  if (name == "XMLLogPath")
                  {
                    try
                    {
                      if (!Directory.Exists(str))
                        Directory.CreateDirectory(str);
                      defaultSettings._XMLLogPath = str;
                      continue;
                    }
                    catch (Exception ex)
                    {
                      string message2 = string.Format("Unable to validate log path\r\n{0}", (object) ex.ToString());
                      Trace.TraceWarning(message2);
                      if (ServerConnectionSettings.s_EventLog != null)
                      {
                        ServerConnectionSettings.s_EventLog.WriteEntry(message2, EventLogEntryType.Warning);
                        continue;
                      }
                      continue;
                    }
                  }
                  else
                    continue;
                case 2778009854:
                  if (name == "AppServerUriStem")
                  {
                    defaultSettings._appServerUriStem = string.IsNullOrWhiteSpace(str) ? string.Empty : str.Trim();
                    continue;
                  }
                  continue;
                case 3725526197:
                  if (name == "ReceiveTimeout")
                  {
                    int result = 0;
                    if (int.TryParse(str, out result))
                    {
                      defaultSettings._ReceiveTimeout = result;
                      continue;
                    }
                    continue;
                  }
                  continue;
                case 3804576966:
                  if (name == "Port")
                  {
                    int result = 0;
                    if (int.TryParse(str, out result) && 0 <= result && result <= (int) ushort.MaxValue)
                    {
                      defaultSettings._Port = result;
                      continue;
                    }
                    continue;
                  }
                  continue;
                default:
                  continue;
              }
            }
          }
        }
        defaultSettings._changeNumber = Interlocked.Increment(ref ServerConnectionSettings.s_ChangeNumber);
        Interlocked.Exchange<ServerConnectionSettings>(ref ServerConnectionSettings.s_DefaultSettings, defaultSettings);
        flag1 = true;
      }
      catch (Exception ex)
      {
        flag1 = false;
        string message = string.Format("Error reading cconfiguration file\r\n{0}", (object) ex.ToString());
        Trace.TraceWarning(message);
        if (ServerConnectionSettings.s_EventLog != null)
          ServerConnectionSettings.s_EventLog.WriteEntry(message, EventLogEntryType.Warning);
      }
      return flag1;
    }

    private static void OnConfigFileChanged(object obj)
    {
      if (ServerConnectionSettings.s_Monitor != null && ServerConnectionSettings.s_Monitor.HasChanged)
      {
        if (ServerConnectionSettings.LoadConfigSettings(ServerConnectionSettings.s_DefaultConfigurationFile))
        {
          try
          {
            EventHandler configFileChanged = ServerConnectionSettings.ConfigFileChanged;
            if (configFileChanged != null)
              configFileChanged((object) null, EventArgs.Empty);
          }
          catch (Exception ex)
          {
            string message = string.Format("Error notifying for file changes\r\n{0}", (object) ex.ToString());
            Trace.TraceWarning(message);
            if (ServerConnectionSettings.s_EventLog != null)
              ServerConnectionSettings.s_EventLog.WriteEntry(message, EventLogEntryType.Warning);
          }
        }
      }
      ServerConnectionSettings.s_Monitor = (HostFileChangeMonitor) null;
      try
      {
        ServerConnectionSettings.s_Monitor = new HostFileChangeMonitor((IList<string>) new List<string>()
        {
          ServerConnectionSettings.s_DefaultConfigurationFile
        });
        ServerConnectionSettings.s_Monitor.NotifyOnChanged(new OnChangedCallback(ServerConnectionSettings.OnConfigFileChanged));
      }
      catch (Exception ex)
      {
        string message = string.Format("Error establishing change notifications\r\n{0}", (object) ex.ToString());
        Trace.TraceWarning(message);
        if (ServerConnectionSettings.s_EventLog == null)
          return;
        ServerConnectionSettings.s_EventLog.WriteEntry(message, EventLogEntryType.Warning);
      }
    }

    public static string DefaultConfigurationFile
    {
      get
      {
        return ServerConnectionSettings.s_DefaultConfigurationFile;
      }
      set
      {
        if (string.IsNullOrWhiteSpace(value) || !File.Exists(value))
          return;
        Interlocked.Exchange<string>(ref ServerConnectionSettings.s_DefaultConfigurationFile, value);
        ServerConnectionSettings.s_Monitor.Dispose();
      }
    }

    public static int CurrentChangeNumber
    {
      get
      {
        return ServerConnectionSettings.s_ChangeNumber;
      }
    }

    public static ServerConnectionSettings DefaultSettings
    {
      get
      {
        return ServerConnectionSettings.s_DefaultSettings.Clone();
      }
      set
      {
        if (value == null)
          return;
        Interlocked.Exchange<ServerConnectionSettings>(ref ServerConnectionSettings.s_DefaultSettings, value);
      }
    }

    public static event EventHandler ConfigFileChanged;
  }
}
