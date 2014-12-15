namespace lucidcode.LucidScribe.Plugout.LEDScreen
{
  partial class LEDForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.flashTimer = new System.Windows.Forms.Timer(this.components);
      this.showTimer = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // flashTimer
      // 
      this.flashTimer.Interval = 1000;
      this.flashTimer.Tick += new System.EventHandler(this.flashTimer_Tick);
      // 
      // showTimer
      // 
      this.showTimer.Enabled = true;
      this.showTimer.Interval = 6000;
      this.showTimer.Tick += new System.EventHandler(this.showTimer_Tick);
      // 
      // LEDForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(149, 146);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "LEDForm";
      this.Text = "LED";
      this.Load += new System.EventHandler(this.LEDForm_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LEDForm_KeyDown);
      this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LEDForm_MouseClick);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LEDForm_MouseMove);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer flashTimer;
    private System.Windows.Forms.Timer showTimer;
  }
}