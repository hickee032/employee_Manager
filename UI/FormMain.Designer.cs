namespace emp_Manager {
    partial class FormMain {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.centerLayout = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnShowEmp = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(13, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(167, 29);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMail);
            this.panel2.Controls.Add(this.btnAdmin);
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnShowEmp);
            this.panel2.Controls.Add(this.btnGrade);
            this.panel2.Controls.Add(this.btnAddUser);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(223, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 75);
            this.panel2.TabIndex = 2;
            // 
            // centerLayout
            // 
            this.centerLayout.Location = new System.Drawing.Point(223, 141);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(807, 542);
            this.centerLayout.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroButton4);
            this.panel3.Controls.Add(this.metroButton5);
            this.panel3.Controls.Add(this.metroButton3);
            this.panel3.Controls.Add(this.metroButton2);
            this.panel3.Controls.Add(this.metroLabel3);
            this.panel3.Controls.Add(this.metroLabel2);
            this.panel3.Controls.Add(this.metroLabel1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(23, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 626);
            this.panel3.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(13, 356);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "이름";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(13, 385);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "부서";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(13, 328);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(23, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "ID";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::emp_Manager.Properties.Resources.MailNo;
            this.metroButton2.Location = new System.Drawing.Point(27, 440);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(64, 64);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::emp_Manager.Properties.Resources.LogoCompany;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 212);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.Transparent;
            this.btnMail.BackgroundImage = global::emp_Manager.Properties.Resources.icon_mail;
            this.btnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMail.Location = new System.Drawing.Point(406, 0);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(89, 75);
            this.btnMail.TabIndex = 7;
            this.btnMail.UseVisualStyleBackColor = false;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BackgroundImage = global::emp_Manager.Properties.Resources.icon_admin;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdmin.Location = new System.Drawing.Point(598, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(89, 75);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImage = global::emp_Manager.Properties.Resources.icon_help;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHelp.Location = new System.Drawing.Point(694, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(89, 75);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImage = global::emp_Manager.Properties.Resources.icon_setting;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSetting.Location = new System.Drawing.Point(502, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(89, 75);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnShowEmp
            // 
            this.btnShowEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnShowEmp.BackgroundImage = global::emp_Manager.Properties.Resources.icon_search;
            this.btnShowEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShowEmp.Location = new System.Drawing.Point(310, 0);
            this.btnShowEmp.Name = "btnShowEmp";
            this.btnShowEmp.Size = new System.Drawing.Size(89, 75);
            this.btnShowEmp.TabIndex = 3;
            this.btnShowEmp.UseVisualStyleBackColor = false;
            this.btnShowEmp.Click += new System.EventHandler(this.btnShowEmp_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.BackColor = System.Drawing.Color.Transparent;
            this.btnGrade.BackgroundImage = global::emp_Manager.Properties.Resources.icon_grade;
            this.btnGrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGrade.Location = new System.Drawing.Point(214, 0);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(89, 75);
            this.btnGrade.TabIndex = 2;
            this.btnGrade.UseVisualStyleBackColor = false;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BackgroundImage = global::emp_Manager.Properties.Resources.icon_user;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUser.Location = new System.Drawing.Point(118, 0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(89, 75);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::emp_Manager.Properties.Resources.icon_Home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Location = new System.Drawing.Point(22, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(89, 75);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackgroundImage = global::emp_Manager.Properties.Resources.MailNo;
            this.metroButton3.Location = new System.Drawing.Point(97, 440);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(64, 64);
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "metroButton3";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.BackgroundImage = global::emp_Manager.Properties.Resources.MailNo;
            this.metroButton4.Location = new System.Drawing.Point(97, 510);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(64, 64);
            this.metroButton4.TabIndex = 8;
            this.metroButton4.Text = "metroButton4";
            this.metroButton4.UseSelectable = true;
            // 
            // metroButton5
            // 
            this.metroButton5.BackgroundImage = global::emp_Manager.Properties.Resources.MailNo;
            this.metroButton5.Location = new System.Drawing.Point(27, 510);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(64, 64);
            this.metroButton5.TabIndex = 7;
            this.metroButton5.Text = "metroButton5";
            this.metroButton5.UseSelectable = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 706);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.centerLayout);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Text = "사원 관리 프로그램";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel centerLayout;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnShowEmp;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}

