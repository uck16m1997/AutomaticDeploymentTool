namespace FineksusInternshipCs
{
    partial class SelectionForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.MSSQLDeployOrder = new System.Windows.Forms.TextBox();
            this.WinServDeployOrder = new System.Windows.Forms.TextBox();
            this.FileDeployOrder = new System.Windows.Forms.TextBox();
            this.MSSQLDeployCheck = new System.Windows.Forms.CheckBox();
            this.WinServDeployCheck = new System.Windows.Forms.CheckBox();
            this.FileDeployCheck = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeployListLabel = new System.Windows.Forms.Label();
            this.MSSQLDeployLabel = new System.Windows.Forms.Label();
            this.WinServDeployLabel = new System.Windows.Forms.Label();
            this.FileDeployLabel = new System.Windows.Forms.Label();
            this.InstallButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel1.Controls.Add(this.OrderLabel);
            this.splitContainer1.Panel1.Controls.Add(this.MSSQLDeployOrder);
            this.splitContainer1.Panel1.Controls.Add(this.WinServDeployOrder);
            this.splitContainer1.Panel1.Controls.Add(this.FileDeployOrder);
            this.splitContainer1.Panel1.Controls.Add(this.MSSQLDeployCheck);
            this.splitContainer1.Panel1.Controls.Add(this.WinServDeployCheck);
            this.splitContainer1.Panel1.Controls.Add(this.FileDeployCheck);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.splitContainer1.Panel2.Controls.Add(this.CancelButton);
            this.splitContainer1.Panel2.Controls.Add(this.DeployListLabel);
            this.splitContainer1.Panel2.Controls.Add(this.MSSQLDeployLabel);
            this.splitContainer1.Panel2.Controls.Add(this.WinServDeployLabel);
            this.splitContainer1.Panel2.Controls.Add(this.FileDeployLabel);
            this.splitContainer1.Panel2.Controls.Add(this.InstallButton);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(784, 450);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 29;
            // 
            // OrderLabel
            // 
            this.OrderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.Location = new System.Drawing.Point(50, 71);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(147, 55);
            this.OrderLabel.TabIndex = 35;
            this.OrderLabel.Text = "Order";
            // 
            // MSSQLDeployOrder
            // 
            this.MSSQLDeployOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MSSQLDeployOrder.Location = new System.Drawing.Point(146, 270);
            this.MSSQLDeployOrder.Name = "MSSQLDeployOrder";
            this.MSSQLDeployOrder.Size = new System.Drawing.Size(29, 20);
            this.MSSQLDeployOrder.TabIndex = 34;
            this.MSSQLDeployOrder.Text = "3";
            this.MSSQLDeployOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MSSQLDeployOrder.TextChanged += new System.EventHandler(this.MSSQLDeployOrder_TextChanged);
            // 
            // WinServDeployOrder
            // 
            this.WinServDeployOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WinServDeployOrder.Location = new System.Drawing.Point(146, 217);
            this.WinServDeployOrder.Name = "WinServDeployOrder";
            this.WinServDeployOrder.Size = new System.Drawing.Size(29, 20);
            this.WinServDeployOrder.TabIndex = 33;
            this.WinServDeployOrder.Text = "2";
            this.WinServDeployOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WinServDeployOrder.TextChanged += new System.EventHandler(this.WinServDeployOrder_TextChanged);
            // 
            // FileDeployOrder
            // 
            this.FileDeployOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileDeployOrder.Location = new System.Drawing.Point(146, 165);
            this.FileDeployOrder.Name = "FileDeployOrder";
            this.FileDeployOrder.Size = new System.Drawing.Size(29, 20);
            this.FileDeployOrder.TabIndex = 32;
            this.FileDeployOrder.Text = "1";
            this.FileDeployOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FileDeployOrder.TextChanged += new System.EventHandler(this.FileDeployOrder_TextChanged);
            // 
            // MSSQLDeployCheck
            // 
            this.MSSQLDeployCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MSSQLDeployCheck.AutoSize = true;
            this.MSSQLDeployCheck.Checked = true;
            this.MSSQLDeployCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MSSQLDeployCheck.Location = new System.Drawing.Point(77, 276);
            this.MSSQLDeployCheck.Name = "MSSQLDeployCheck";
            this.MSSQLDeployCheck.Size = new System.Drawing.Size(15, 14);
            this.MSSQLDeployCheck.TabIndex = 31;
            this.MSSQLDeployCheck.UseVisualStyleBackColor = true;
            this.MSSQLDeployCheck.CheckedChanged += new System.EventHandler(this.MSSQLDeployCheck_CheckedChanged);
            // 
            // WinServDeployCheck
            // 
            this.WinServDeployCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WinServDeployCheck.AutoSize = true;
            this.WinServDeployCheck.Checked = true;
            this.WinServDeployCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WinServDeployCheck.Location = new System.Drawing.Point(77, 222);
            this.WinServDeployCheck.Name = "WinServDeployCheck";
            this.WinServDeployCheck.Size = new System.Drawing.Size(15, 14);
            this.WinServDeployCheck.TabIndex = 30;
            this.WinServDeployCheck.UseVisualStyleBackColor = true;
            this.WinServDeployCheck.CheckedChanged += new System.EventHandler(this.WinServDeployCheck_CheckedChanged);
            // 
            // FileDeployCheck
            // 
            this.FileDeployCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileDeployCheck.AutoSize = true;
            this.FileDeployCheck.Checked = true;
            this.FileDeployCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FileDeployCheck.Location = new System.Drawing.Point(77, 165);
            this.FileDeployCheck.Name = "FileDeployCheck";
            this.FileDeployCheck.Size = new System.Drawing.Size(15, 14);
            this.FileDeployCheck.TabIndex = 29;
            this.FileDeployCheck.UseVisualStyleBackColor = true;
            this.FileDeployCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(220, 356);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(139, 44);
            this.CancelButton.TabIndex = 27;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DeployListLabel
            // 
            this.DeployListLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeployListLabel.AutoSize = true;
            this.DeployListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeployListLabel.Location = new System.Drawing.Point(69, 71);
            this.DeployListLabel.Name = "DeployListLabel";
            this.DeployListLabel.Size = new System.Drawing.Size(261, 55);
            this.DeployListLabel.TabIndex = 26;
            this.DeployListLabel.Text = "Deploy List";
            // 
            // MSSQLDeployLabel
            // 
            this.MSSQLDeployLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MSSQLDeployLabel.AutoSize = true;
            this.MSSQLDeployLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSSQLDeployLabel.Location = new System.Drawing.Point(76, 271);
            this.MSSQLDeployLabel.Name = "MSSQLDeployLabel";
            this.MSSQLDeployLabel.Size = new System.Drawing.Size(260, 31);
            this.MSSQLDeployLabel.TabIndex = 25;
            this.MSSQLDeployLabel.Text = "MSSQL Deployment";
            // 
            // WinServDeployLabel
            // 
            this.WinServDeployLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WinServDeployLabel.AutoSize = true;
            this.WinServDeployLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinServDeployLabel.Location = new System.Drawing.Point(76, 217);
            this.WinServDeployLabel.Name = "WinServDeployLabel";
            this.WinServDeployLabel.Size = new System.Drawing.Size(374, 31);
            this.WinServDeployLabel.TabIndex = 24;
            this.WinServDeployLabel.Text = "Windows Service Deployment";
            // 
            // FileDeployLabel
            // 
            this.FileDeployLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileDeployLabel.AutoSize = true;
            this.FileDeployLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileDeployLabel.Location = new System.Drawing.Point(76, 163);
            this.FileDeployLabel.Name = "FileDeployLabel";
            this.FileDeployLabel.Size = new System.Drawing.Size(210, 31);
            this.FileDeployLabel.TabIndex = 23;
            this.FileDeployLabel.Text = "File Deployment";
            // 
            // InstallButton
            // 
            this.InstallButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InstallButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.InstallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallButton.Location = new System.Drawing.Point(46, 356);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(139, 44);
            this.InstallButton.TabIndex = 22;
            this.InstallButton.Text = "INSTALL";
            this.InstallButton.UseVisualStyleBackColor = false;
            this.InstallButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 41);
            this.panel1.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Logo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 39);
            this.panel3.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(321, 33);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "Pay Gate Deployment Tool";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "SelectionForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.TextBox MSSQLDeployOrder;
        private System.Windows.Forms.TextBox WinServDeployOrder;
        private System.Windows.Forms.TextBox FileDeployOrder;
        private System.Windows.Forms.CheckBox MSSQLDeployCheck;
        private System.Windows.Forms.CheckBox WinServDeployCheck;
        private System.Windows.Forms.CheckBox FileDeployCheck;
        private System.Windows.Forms.Label DeployListLabel;
        private System.Windows.Forms.Label MSSQLDeployLabel;
        private System.Windows.Forms.Label WinServDeployLabel;
        private System.Windows.Forms.Label FileDeployLabel;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.Panel panel1;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Logo;
    }
}

