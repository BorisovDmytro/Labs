namespace lab3
{
  partial class ProductDialog
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
      this.boxPrice = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnOk = new System.Windows.Forms.Button();
      this.btnCansel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name";
      // 
      // boxName
      // 
      this.boxName.Location = new System.Drawing.Point(13, 30);
      this.boxName.Name = "boxName";
      this.boxName.Size = new System.Drawing.Size(202, 20);
      this.boxName.TabIndex = 1;
      // 
      // boxPrice
      // 
      this.boxPrice.Location = new System.Drawing.Point(13, 70);
      this.boxPrice.Name = "boxPrice";
      this.boxPrice.Size = new System.Drawing.Size(202, 20);
      this.boxPrice.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 53);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(31, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Price";
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(59, 106);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(75, 23);
      this.btnOk.TabIndex = 4;
      this.btnOk.Text = "Ok";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // btnCansel
      // 
      this.btnCansel.Location = new System.Drawing.Point(140, 106);
      this.btnCansel.Name = "btnCansel";
      this.btnCansel.Size = new System.Drawing.Size(75, 23);
      this.btnCansel.TabIndex = 5;
      this.btnCansel.Text = "Cansel";
      this.btnCansel.UseVisualStyleBackColor = true;
      this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
      // 
      // ProductDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(227, 137);
      this.Controls.Add(this.btnCansel);
      this.Controls.Add(this.btnOk);
      this.Controls.Add(this.boxPrice);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.boxName);
      this.Controls.Add(this.label1);
      this.Name = "ProductDialog";
      this.Text = "ProductDialog";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox boxName;
    private System.Windows.Forms.TextBox boxPrice;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnCansel;
  }
}