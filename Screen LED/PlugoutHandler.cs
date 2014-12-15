using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Xml;
using System.Net;

namespace lucidcode.LucidScribe.Plugout.LEDScreen
{
  public class PlugoutHandler : lucidcode.LucidScribe.Interface.LucidPlugoutBase
  {

    private Boolean Failed = false;
    private Boolean On = false;

    private Thread SwitchOffThread;

    private LEDForm ledForm = new LEDForm();

    public override string Name
    {
      get { return "Screen LED"; }
    }

    public override bool Initialize()
    {
      return true;
    }

    public override void Dispose()
    {
      return;
    }

    public override void Trigger()
    {
      try
      {
        if (Failed) return;

        if (On) return;

        ledForm.Flash();
        On = true;

        SwitchOffThread = new Thread(SwitchOff);
        SwitchOffThread.Start();
      }
      catch (Exception ex)
      {
        Failed = true;
        MessageBox.Show(ex.Message, "Screen LED Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public void SwitchOff()
    {
      Thread.Sleep(1000 * 60);
      On = false;
      ledForm.Stop();
    }

  }

}
