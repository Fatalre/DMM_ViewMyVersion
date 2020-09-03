// Decompiled with JetBrains decompiler
// Type: DMM_View.Properties.Settings
// Assembly: DMM_View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8766B025-EF85-4D30-9762-85F77D291D68
// Assembly location: D:\Program\HK68C\DMM_View.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace DMM_View.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
