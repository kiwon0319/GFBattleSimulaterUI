namespace GFBattleSimulator.Usercontrols
{
    partial class fairy_tile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fairy_tile));
            this.flv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flv
            // 
            this.flv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.flv.Font = new System.Drawing.Font("Mohave", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.flv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.flv.Location = new System.Drawing.Point(96, 114);
            this.flv.Name = "flv";
            this.flv.Size = new System.Drawing.Size(50, 21);
            this.flv.TabIndex = 0;
            this.flv.Text = "100";
            this.flv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fairy_tile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.flv);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(128, 204);
            this.MinimumSize = new System.Drawing.Size(128, 204);
            this.Name = "fairy_tile";
            this.Size = new System.Drawing.Size(128, 204);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label flv;
    }
}
