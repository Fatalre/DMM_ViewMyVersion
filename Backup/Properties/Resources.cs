// Decompiled with JetBrains decompiler
// Type: DMM_View.Properties.Resources
// Assembly: DMM_View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8766B025-EF85-4D30-9762-85F77D291D68
// Assembly location: D:\Program\HK68C\DMM_View.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DMM_View.Properties
{
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) DMM_View.Properties.Resources.resourceMan, (object) null))
          DMM_View.Properties.Resources.resourceMan = new ResourceManager("DMM_View.Properties.Resources", typeof (DMM_View.Properties.Resources).Assembly);
        return DMM_View.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => DMM_View.Properties.Resources.resourceCulture;
      set => DMM_View.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap usb_connected => (Bitmap) DMM_View.Properties.Resources.ResourceManager.GetObject(nameof (usb_connected), DMM_View.Properties.Resources.resourceCulture);

    internal static Bitmap usb_connector => (Bitmap) DMM_View.Properties.Resources.ResourceManager.GetObject(nameof (usb_connector), DMM_View.Properties.Resources.resourceCulture);
  }
}
