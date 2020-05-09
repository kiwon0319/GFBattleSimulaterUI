namespace GFBattleSimulator.Usercontrols
{
    partial class Toggle
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.clickarea = new System.Windows.Forms.Panel();
            this.state = new System.Windows.Forms.Label();
            this.togglebtn = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.clickarea.SuspendLayout();
            this.SuspendLayout();
            // 
            // clickarea
            // 
            this.clickarea.AutoSize = true;
            this.clickarea.Controls.Add(this.state);
            this.clickarea.Controls.Add(this.togglebtn);
            this.clickarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.clickarea.Location = new System.Drawing.Point(0, 21);
            this.clickarea.Name = "clickarea";
            this.clickarea.Size = new System.Drawing.Size(125, 31);
            this.clickarea.TabIndex = 8;
            this.clickarea.Click += new System.EventHandler(this.clickarea_Click);
            // 
            // state
            // 
            this.state.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.ForeColor = System.Drawing.Color.White;
            this.state.Location = new System.Drawing.Point(59, 3);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(42, 25);
            this.state.TabIndex = 6;
            this.state.Text = "꺼짐";
            this.state.Click += new System.EventHandler(this.clickarea_Click);
            // 
            // togglebtn
            // 
            this.togglebtn.BackgroundImage = global::GFBattleSimulator.Properties.Resources._Elements___Toggle___Off;
            this.togglebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.togglebtn.Location = new System.Drawing.Point(1, 3);
            this.togglebtn.Name = "togglebtn";
            this.togglebtn.Size = new System.Drawing.Size(52, 25);
            this.togglebtn.TabIndex = 5;
            this.togglebtn.Click += new System.EventHandler(this.clickarea_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(42, 21);
            this.title.TabIndex = 7;
            this.title.Text = "토글";
            // 
            // Toggle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.clickarea);
            this.Controls.Add(this.title);
            this.Name = "Toggle";
            this.Size = new System.Drawing.Size(125, 62);
            this.clickarea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel clickarea;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Panel togglebtn;
        private System.Windows.Forms.Label title;
    }
}
