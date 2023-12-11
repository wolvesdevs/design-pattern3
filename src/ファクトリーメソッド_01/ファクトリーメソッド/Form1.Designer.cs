namespace ファクトリーメソッド
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.GetButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // GetButton
      // 
      this.GetButton.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.GetButton.Location = new System.Drawing.Point(173, 120);
      this.GetButton.Name = "GetButton";
      this.GetButton.Size = new System.Drawing.Size(125, 42);
      this.GetButton.TabIndex = 0;
      this.GetButton.Text = "Get";
      this.GetButton.UseVisualStyleBackColor = true;
      this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.Purple;
      this.label1.Location = new System.Drawing.Point(29, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(105, 45);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(321, 174);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.GetButton);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button GetButton;
    private Label label1;
  }
}