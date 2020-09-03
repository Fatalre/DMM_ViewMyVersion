// Decompiled with JetBrains decompiler
// Type: DMM_View.Program
// Assembly: DMM_View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8766B025-EF85-4D30-9762-85F77D291D68
// Assembly location: D:\Program\HK68C\DMM_View.exe

using System;
using System.Windows.Forms;

namespace DMM_View
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
