namespace lab4mongo
{
  partial class Form1
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.connectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.viewSeller = new System.Windows.Forms.DataGridView();
      this.viewProduct = new System.Windows.Forms.DataGridView();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.viewSeller)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewProduct)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.contextMenuStrip2.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(884, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // connectToolStripMenuItem
      // 
      this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem1});
      this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
      this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
      this.connectToolStripMenuItem.Text = "Connect";
      // 
      // connectToolStripMenuItem1
      // 
      this.connectToolStripMenuItem1.Name = "connectToolStripMenuItem1";
      this.connectToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
      this.connectToolStripMenuItem1.Text = "Connect";
      this.connectToolStripMenuItem1.Click += new System.EventHandler(this.OnConnect);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 24);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.viewSeller);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.viewProduct);
      this.splitContainer1.Size = new System.Drawing.Size(884, 471);
      this.splitContainer1.SplitterDistance = 429;
      this.splitContainer1.TabIndex = 1;
      // 
      // viewSeller
      // 
      this.viewSeller.AllowUserToAddRows = false;
      this.viewSeller.AllowUserToDeleteRows = false;
      this.viewSeller.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.viewSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.viewSeller.ContextMenuStrip = this.contextMenuStrip1;
      this.viewSeller.Location = new System.Drawing.Point(3, 3);
      this.viewSeller.Name = "viewSeller";
      this.viewSeller.ReadOnly = true;
      this.viewSeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.viewSeller.Size = new System.Drawing.Size(423, 468);
      this.viewSeller.TabIndex = 0;
      this.viewSeller.Click += new System.EventHandler(this.OnViewSellerClick);
      // 
      // viewProduct
      // 
      this.viewProduct.AllowUserToAddRows = false;
      this.viewProduct.AllowUserToDeleteRows = false;
      this.viewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.viewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.viewProduct.ContextMenuStrip = this.contextMenuStrip2;
      this.viewProduct.Location = new System.Drawing.Point(-1, 3);
      this.viewProduct.Name = "viewProduct";
      this.viewProduct.ReadOnly = true;
      this.viewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.viewProduct.Size = new System.Drawing.Size(452, 468);
      this.viewProduct.TabIndex = 0;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.addProductToolStripMenuItem,
            this.updateToolStripMenuItem1,
            this.removeToolStripMenuItem1});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(142, 92);
      // 
      // addToolStripMenuItem1
      // 
      this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
      this.addToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
      this.addToolStripMenuItem1.Text = "Add";
      this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
      // 
      // updateToolStripMenuItem1
      // 
      this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
      this.updateToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
      this.updateToolStripMenuItem1.Text = "Update";
      this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
      // 
      // removeToolStripMenuItem1
      // 
      this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
      this.removeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
      this.removeToolStripMenuItem1.Text = "Remove";
      this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
      // 
      // contextMenuStrip2
      // 
      this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.updateToolStripMenuItem});
      this.contextMenuStrip2.Name = "contextMenuStrip2";
      this.contextMenuStrip2.Size = new System.Drawing.Size(118, 48);
      // 
      // removeToolStripMenuItem
      // 
      this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
      this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.removeToolStripMenuItem.Text = "Remove";
      this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
      // 
      // updateToolStripMenuItem
      // 
      this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
      this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.updateToolStripMenuItem.Text = "Update";
      this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
      // 
      // addProductToolStripMenuItem
      // 
      this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
      this.addProductToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.addProductToolStripMenuItem.Text = "Add product";
      this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(884, 495);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.viewSeller)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewProduct)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.contextMenuStrip2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.DataGridView viewSeller;
    private System.Windows.Forms.DataGridView viewProduct;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
  }
}

