namespace BookManagerSystem
{
    partial class Popup_Login
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
            this.Panel_Login = new DevExpress.XtraEditors.PanelControl();
            this.chkPassShow = new DevExpress.XtraEditors.CheckEdit();
            this.btnJoin_Manager = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Login)).BeginInit();
            this.Panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPassShow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Login
            // 
            this.Panel_Login.Controls.Add(this.chkPassShow);
            this.Panel_Login.Controls.Add(this.btnJoin_Manager);
            this.Panel_Login.Controls.Add(this.btnLogin);
            this.Panel_Login.Controls.Add(this.txtPassword);
            this.Panel_Login.Controls.Add(this.txtID);
            this.Panel_Login.Controls.Add(this.labelControl4);
            this.Panel_Login.Controls.Add(this.labelControl2);
            this.Panel_Login.Controls.Add(this.labelControl1);
            this.Panel_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Login.Location = new System.Drawing.Point(0, 0);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Size = new System.Drawing.Size(459, 262);
            this.Panel_Login.TabIndex = 0;
            // 
            // chkPassShow
            // 
            this.chkPassShow.Location = new System.Drawing.Point(296, 168);
            this.chkPassShow.Name = "chkPassShow";
            this.chkPassShow.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPassShow.Properties.Appearance.Options.UseFont = true;
            this.chkPassShow.Properties.Caption = "비밀번호 보이기";
            this.chkPassShow.Size = new System.Drawing.Size(117, 19);
            this.chkPassShow.TabIndex = 15;
            this.chkPassShow.CheckedChanged += new System.EventHandler(this.chkPassShow_CheckedChanged);
            // 
            // btnJoin_Manager
            // 
            this.btnJoin_Manager.Appearance.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin_Manager.Appearance.Options.UseFont = true;
            this.btnJoin_Manager.Location = new System.Drawing.Point(156, 207);
            this.btnJoin_Manager.Name = "btnJoin_Manager";
            this.btnJoin_Manager.Size = new System.Drawing.Size(134, 35);
            this.btnJoin_Manager.TabIndex = 14;
            this.btnJoin_Manager.Text = "회원가입";
            this.btnJoin_Manager.Click += new System.EventHandler(this.cbButton_ClickEvent);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogin.Location = new System.Drawing.Point(156, 166);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 35);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "로그인";
            this.btnLogin.Click += new System.EventHandler(this.cbButton_ClickEvent);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(156, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(233, 33);
            this.txtPassword.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(156, 77);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(233, 33);
            this.txtID.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(156, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(118, 41);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "LOG IN";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(137, 24);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "PASSWORD :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(117, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 24);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "ID :";
            // 
            // Popup_Login
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 262);
            this.Controls.Add(this.Panel_Login);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Popup_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Manager System";
            this.Load += new System.EventHandler(this.Popup_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Login)).EndInit();
            this.Panel_Login.ResumeLayout(false);
            this.Panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPassShow.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl Panel_Login;
        private DevExpress.XtraEditors.CheckEdit chkPassShow;
        private DevExpress.XtraEditors.SimpleButton btnJoin_Manager;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}