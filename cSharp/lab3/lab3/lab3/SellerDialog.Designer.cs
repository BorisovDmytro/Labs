namespace lab3
{
  partial class SellerDialog
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
      this.label1 = new System.Windows.Forms.Label();
      this.boxName = new System.Windows.Forms.TextBox();
      this.boxSecond = new System.Windows.Forms.TextBox();
      this.boxSecondName = new System.Windows.Forms.Label();
      this.btnOk = new System.Windows.Forms.Button();
      this.btnCansel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name";
      // 
      // boxName
      // 
      this.boxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.boxName.Location = new System.Drawing.Point(12, 20);
      this.boxName.Name = "boxName";
      this.boxName.Size = new System.Drawing.Size(246, 20);
      this.boxName.TabIndex = 1;
      // 
      // boxSecond
      // 
      this.boxSecond.Location = new System.Drawing.Point(11, 59);
      this.boxSecond.Name = "boxSecond";
      this.boxSecond.Size = new System.Drawing.Size(246, 20);
      this.boxSecond.TabIndex = 3;
      // 
      // boxSecondName
      // 
      this.boxSecondName.AutoSize = true;
      this.boxSecondName.Location = new System.Drawing.Point(12, 43);
      this.boxSecondName.Name = "boxSecondName";
      this.boxSecondName.Size = new System.Drawing.Size(73, 13);
      this.boxSecondName.TabIndex = 2;
      this.boxSecondName.Text = "Second name";
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(101, 86);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(75, 23);
      this.btnOk.TabIndex = 4;
      this.btnOk.Text = "Ok";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // btnCansel
      // 
      this.btnCansel.Location = new System.Drawing.Point(183, 86);
      this.btnCansel.Name = "btnCansel";
      this.btnCansel.Size = new System.Drawing.Size(75, 23);
      this.btnCansel.TabIndex = 5;
      this.btnCansel.Text = "Cansel";
      this.btnCansel.UseVisualStyleBackColor = true;
      this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
      // 
      // SellerDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(274, 121);
      this.Controls.Add(this.btnCansel);
      this.Controls.Add(this.btnOk);
      this.Controls.Add(this.boxSecond);
      this.Controls.Add(this.boxSecondName);
      this.Controls.Add(this.boxName);
      this.Controls.Add(this.label1);
      this.MaximumSize = new System.Drawing.Size(290, 160);
      this.MinimumSize = new System.Drawing.Size(290, 160);
      this.Name = "SellerDialog";
      this.Text = "SellerDialog";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox boxName;
    private System.Windows.Forms.TextBox boxSecond;
    private System.Windows.Forms.Label boxSecondName;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnCansel;
  }
}