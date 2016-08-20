namespace lab3
{
    partial class ConnectDataBaseDlg
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
      this.boxHost = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.boxPort = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.boxName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.boxUser = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.boxPass = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnConnect = new System.Windows.Forms.Button();
      this.btnCansel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // boxHost
      // 
      this.boxHost.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.boxHost.Location = new System.Drawing.Point(12, 34);
      this.boxHost.MaximumSize = new System.Drawing.Size(250, 30);
      this.boxHost.MinimumSize = new System.Drawing.Size(250, 30);
      this.boxHost.Name = "boxHost";
      this.boxHost.Size = new System.Drawing.Size(250, 30);
      this.boxHost.TabIndex = 9;
      this.boxHost.Text = "localhost";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(12, 9);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(50, 22);
      this.label5.TabIndex = 8;
      this.label5.Text = "Host";
      // 
      // boxPort
      // 
      this.boxPort.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.boxPort.Location = new System.Drawing.Point(12, 92);
      this.boxPort.MaximumSize = new System.Drawing.Size(250, 30);
      this.boxPort.MinimumSize = new System.Drawing.Size(250, 30);
      this.boxPort.Name = "boxPort";
      this.boxPort.Size = new System.Drawing.Size(250, 30);
      this.boxPort.TabIndex = 11;
      this.boxPort.Text = "5432";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 67);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 22);
      this.label1.TabIndex = 10;
      this.label1.Text = "Port";
      // 
      // boxName
      // 
      this.boxName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.boxName.Location = new System.Drawing.Point(12, 150);
      this.boxName.MaximumSize = new System.Drawing.Size(250, 30);
      this.boxName.MinimumSize = new System.Drawing.Size(250, 30);
      this.boxName.Name = "boxName";
      this.boxName.Size = new System.Drawing.Size(250, 30);
      this.boxName.TabIndex = 13;
      this.boxName.Text = "lab3";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(12, 125);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(150, 22);
      this.label2.TabIndex = 12;
      this.label2.Text = "Data base name";
      // 
      // boxUser
      // 
      this.boxUser.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.boxUser.Location = new System.Drawing.Point(12, 208);
      this.boxUser.MaximumSize = new System.Drawing.Size(250, 30);
      this.boxUser.MinimumSize = new System.Drawing.Size(250, 30);
      this.boxUser.Name = "boxUser";
      this.boxUser.Size = new System.Drawing.Size(250, 30);
      this.boxUser.TabIndex = 15;
      this.boxUser.Text = "postgres";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(12, 183);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(50, 22);
      this.label3.TabIndex = 14;
      this.label3.Text = "User";
      // 
      // boxPass
      // 
      this.boxPass.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.boxPass.Location = new System.Drawing.Point(12, 266);
      this.boxPass.MaximumSize = new System.Drawing.Size(250, 30);
      this.boxPass.MinimumSize = new System.Drawing.Size(250, 30);
      this.boxPass.Name = "boxPass";
      this.boxPass.PasswordChar = '*';
      this.boxPass.Size = new System.Drawing.Size(250, 30);
      this.boxPass.TabIndex = 17;
      this.boxPass.Text = "695497";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(12, 241);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(90, 22);
      this.label4.TabIndex = 16;
      this.label4.Text = "Password";
      // 
      // btnConnect
      // 
      this.btnConnect.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnConnect.Location = new System.Drawing.Point(12, 302);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(121, 30);
      this.btnConnect.TabIndex = 18;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
      // 
      // btnCansel
      // 
      this.btnCansel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnCansel.Location = new System.Drawing.Point(141, 302);
      this.btnCansel.Name = "btnCansel";
      this.btnCansel.Size = new System.Drawing.Size(121, 30);
      this.btnCansel.TabIndex = 19;
      this.btnCansel.Text = "Cansel";
      this.btnCansel.UseVisualStyleBackColor = true;
      this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
      // 
      // ConnectDataBaseDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(274, 341);
      this.Controls.Add(this.btnCansel);
      this.Controls.Add(this.btnConnect);
      this.Controls.Add(this.boxPass);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.boxUser);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.boxName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.boxPort);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.boxHost);
      this.Controls.Add(this.label5);
      this.MaximumSize = new System.Drawing.Size(290, 380);
      this.MinimumSize = new System.Drawing.Size(290, 380);
      this.Name = "ConnectDataBaseDlg";
      this.Text = "Connect dialog";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxHost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCansel;
    }
}