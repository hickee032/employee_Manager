﻿namespace emp_Manager.UI {
    partial class UCHome {
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvNotice = new MetroFramework.Controls.MetroListView();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.posterChangerTimer = new System.Windows.Forms.Timer(this.components);
            this.lvNotNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNotCont = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(29, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "공지사항";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvNotice);
            this.panel1.Location = new System.Drawing.Point(29, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 144);
            this.panel1.TabIndex = 1;
            // 
            // lvNotice
            // 
            this.lvNotice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvNotNum,
            this.lvNotCont});
            this.lvNotice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvNotice.FullRowSelect = true;
            this.lvNotice.Location = new System.Drawing.Point(3, 3);
            this.lvNotice.Name = "lvNotice";
            this.lvNotice.OwnerDraw = true;
            this.lvNotice.Size = new System.Drawing.Size(202, 139);
            this.lvNotice.TabIndex = 0;
            this.lvNotice.UseCompatibleStateImageBehavior = false;
            this.lvNotice.UseSelectable = true;
            // 
            // pbPoster
            // 
            this.pbPoster.BackgroundImage = global::emp_Manager.Properties.Resources.poster1;
            this.pbPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPoster.Location = new System.Drawing.Point(255, 73);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(253, 456);
            this.pbPoster.TabIndex = 2;
            this.pbPoster.TabStop = false;
            // 
            // posterChangerTimer
            // 
            this.posterChangerTimer.Tick += new System.EventHandler(this.posterChanger_Tick);
            // 
            // lvNotNum
            // 
            this.lvNotNum.Text = "번호";
            // 
            // lvNotCont
            // 
            this.lvNotCont.Text = "공지사항";
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbPoster);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(535, 545);
            this.Load += new System.EventHandler(this.UCHome_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroListView lvNotice;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Timer posterChangerTimer;
        private System.Windows.Forms.ColumnHeader lvNotNum;
        private System.Windows.Forms.ColumnHeader lvNotCont;
    }
}
