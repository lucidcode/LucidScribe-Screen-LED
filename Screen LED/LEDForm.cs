using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lucidcode.LucidScribe.Plugout.LEDScreen
{
  public partial class LEDForm : Form
  {

    public Color FlashColor = Color.White;
    public Color BackgroundColor = Color.Black;

    public LEDForm()
    {
      InitializeComponent();
    }

    private void LEDForm_Load(object sender, EventArgs e)
    {
      Left = 0;
      Top = 0;
      Width = Screen.PrimaryScreen.Bounds.Width;
      Height = Screen.PrimaryScreen.Bounds.Height;
    }

    private void LEDForm_MouseMove(object sender, MouseEventArgs e)
    {
      //Visible = false;
    }

    public void Flash()
    {
      Visible = true;
      flashTimer.Enabled = true;
    }

    public void Stop()
    {
      flashTimer.Enabled = false;
      BackColor = BackgroundColor;
    }

    private void flashTimer_Tick(object sender, EventArgs e)
    {
      if (BackColor == FlashColor)
      {
        BackColor = BackgroundColor;
      }
      else
      {
        BackColor = FlashColor;
      }
    }

    private void LEDForm_MouseClick(object sender, MouseEventArgs e)
    {
      showTimer.Enabled = false;
      Visible = false;
    }

    private void showTimer_Tick(object sender, EventArgs e)
    {
      showTimer.Enabled = false;
      Show();
    }

    private void LEDForm_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        showTimer.Enabled = false;
        Visible = false;
      }
    }

  }
}
