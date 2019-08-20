namespace FineksusInternshipCs
{
    partial class DownloadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.MSSQLDeployResult = new System.Windows.Forms.Label();
            this.WinServDeployResult = new System.Windows.Forms.Label();
            this.FileDeployResult = new System.Windows.Forms.Label();
            this.MSSQLDeployLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WinServDeployLabel = new System.Windows.Forms.Label();
            this.FileDeployLabel = new System.Windows.Forms.Label();
            this.ErrorBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.MSSQLDeployResult);
            this.panel1.Controls.Add(this.WinServDeployResult);
            this.panel1.Controls.Add(this.FileDeployResult);
            this.panel1.Controls.Add(this.MSSQLDeployLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.WinServDeployLabel);
            this.panel1.Controls.Add(this.FileDeployLabel);
            this.panel1.Controls.Add(this.ErrorBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 41);
            this.panel2.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "STATUS DISPLAY";
            // 
            // MSSQLDeployResult
            // 
            this.MSSQLDeployResult.AutoSize = true;
            this.MSSQLDeployResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSSQLDeployResult.Location = new System.Drawing.Point(407, 167);
            this.MSSQLDeployResult.Name = "MSSQLDeployResult";
            this.MSSQLDeployResult.Size = new System.Drawing.Size(175, 29);
            this.MSSQLDeployResult.TabIndex = 39;
            this.MSSQLDeployResult.Text = "Not Requested";
            // 
            // WinServDeployResult
            // 
            this.WinServDeployResult.AutoSize = true;
            this.WinServDeployResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinServDeployResult.Location = new System.Drawing.Point(407, 113);
            this.WinServDeployResult.Name = "WinServDeployResult";
            this.WinServDeployResult.Size = new System.Drawing.Size(175, 29);
            this.WinServDeployResult.TabIndex = 38;
            this.WinServDeployResult.Text = "Not Requested";
            // 
            // FileDeployResult
            // 
            this.FileDeployResult.AutoSize = true;
            this.FileDeployResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileDeployResult.Location = new System.Drawing.Point(407, 66);
            this.FileDeployResult.Name = "FileDeployResult";
            this.FileDeployResult.Size = new System.Drawing.Size(175, 29);
            this.FileDeployResult.TabIndex = 37;
            this.FileDeployResult.Text = "Not Requested";
            // 
            // MSSQLDeployLabel
            // 
            this.MSSQLDeployLabel.AutoSize = true;
            this.MSSQLDeployLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSSQLDeployLabel.Location = new System.Drawing.Point(112, 167);
            this.MSSQLDeployLabel.Name = "MSSQLDeployLabel";
            this.MSSQLDeployLabel.Size = new System.Drawing.Size(238, 29);
            this.MSSQLDeployLabel.TabIndex = 36;
            this.MSSQLDeployLabel.Text = "MSSQL Deployment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 35;
            // 
            // WinServDeployLabel
            // 
            this.WinServDeployLabel.AutoSize = true;
            this.WinServDeployLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinServDeployLabel.Location = new System.Drawing.Point(112, 113);
            this.WinServDeployLabel.Name = "WinServDeployLabel";
            this.WinServDeployLabel.Size = new System.Drawing.Size(244, 29);
            this.WinServDeployLabel.TabIndex = 34;
            this.WinServDeployLabel.Text = "WinServ Deployment:";
            // 
            // FileDeployLabel
            // 
            this.FileDeployLabel.AutoSize = true;
            this.FileDeployLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileDeployLabel.Location = new System.Drawing.Point(112, 66);
            this.FileDeployLabel.Name = "FileDeployLabel";
            this.FileDeployLabel.Size = new System.Drawing.Size(195, 29);
            this.FileDeployLabel.TabIndex = 32;
            this.FileDeployLabel.Text = "File Deployment:";
            // 
            // ErrorBox
            // 
            this.ErrorBox.BackColor = System.Drawing.SystemColors.Window;
            this.ErrorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ErrorBox.Location = new System.Drawing.Point(56, 254);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.ReadOnly = true;
            this.ErrorBox.Size = new System.Drawing.Size(643, 154);
            this.ErrorBox.TabIndex = 0;
            this.ErrorBox.Text = "";
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
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "DownloadForm";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox ErrorBox;
        private System.Windows.Forms.Label FileDeployLabel;
        private System.Windows.Forms.Label WinServDeployLabel;
        private System.Windows.Forms.Label MSSQLDeployLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MSSQLDeployResult;
        private System.Windows.Forms.Label WinServDeployResult;
        private System.Windows.Forms.Label FileDeployResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Logo;
    }
}