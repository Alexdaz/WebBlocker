namespace WEB_BLOCKER
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tbHosts = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(-4, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(638, 57);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            // 
            // tbPage
            // 
            this.tbPage.Location = new System.Drawing.Point(12, 416);
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(608, 20);
            this.tbPage.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(12, 442);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(11, 397);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(117, 13);
            this.lblAdd.TabIndex = 3;
            this.lblAdd.Text = "Página Web a agregar:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 32);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Web Blocker";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(183, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(264, 358);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(95, 23);
            this.btnBackup.TabIndex = 6;
            this.btnBackup.Text = "Crear Respaldo";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(365, 358);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Ayuda";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tbHosts
            // 
            this.tbHosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHosts.Location = new System.Drawing.Point(12, 63);
            this.tbHosts.Name = "tbHosts";
            this.tbHosts.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbHosts.Size = new System.Drawing.Size(608, 289);
            this.tbHosts.TabIndex = 8;
            this.tbHosts.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(589, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 471);
            this.Controls.Add(this.tbHosts);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPage);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WEB BLOCKER";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.RichTextBox tbHosts;
        private System.Windows.Forms.Button btnClose;
    }
}

