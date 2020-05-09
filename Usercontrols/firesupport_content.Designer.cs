namespace GFBattleSimulator.Properties
{
    partial class firesupportContents
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
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shortbtn = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidepanel.Location = new System.Drawing.Point(750, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(250, 500);
            this.sidepanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.shortbtn);
            this.panel1.Controls.Add(this.loadbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.panel1.Size = new System.Drawing.Size(750, 40);
            this.panel1.TabIndex = 1;
            // 
            // shortbtn
            // 
            this.shortbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.shortbtn.FlatAppearance.BorderSize = 0;
            this.shortbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shortbtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortbtn.ForeColor = System.Drawing.Color.White;
            this.shortbtn.Location = new System.Drawing.Point(654, 0);
            this.shortbtn.Name = "shortbtn";
            this.shortbtn.Size = new System.Drawing.Size(40, 40);
            this.shortbtn.TabIndex = 2;
            this.shortbtn.Text = "short";
            this.shortbtn.UseVisualStyleBackColor = true;
            // 
            // loadbtn
            // 
            this.loadbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.loadbtn.FlatAppearance.BorderSize = 0;
            this.loadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadbtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbtn.ForeColor = System.Drawing.Color.White;
            this.loadbtn.Location = new System.Drawing.Point(694, 0);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(40, 40);
            this.loadbtn.TabIndex = 1;
            this.loadbtn.Text = "load";
            this.loadbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "화력지원 소대";
            // 
            // firesupportContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidepanel);
            this.Name = "firesupportContents";
            this.Size = new System.Drawing.Size(1000, 500);
            this.SizeChanged += new System.EventHandler(this.firesupportContents_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button shortbtn;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Label label1;
    }
}
