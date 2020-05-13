namespace GFBattleSimulator
{
    partial class SelectFairy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFairy));
            this.title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.curruntfiary = new System.Windows.Forms.PictureBox();
            this.title.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curruntfiary)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Controls.Add(this.label1);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.title.Size = new System.Drawing.Size(800, 40);
            this.title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "요정선택";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.curruntfiary);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 220);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(25, 8, 25, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 410);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // curruntfiary
            // 
            this.curruntfiary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("curruntfiary.BackgroundImage")));
            this.curruntfiary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.curruntfiary.Image = ((System.Drawing.Image)(resources.GetObject("curruntfiary.Image")));
            this.curruntfiary.Location = new System.Drawing.Point(28, 11);
            this.curruntfiary.MaximumSize = new System.Drawing.Size(128, 206);
            this.curruntfiary.MinimumSize = new System.Drawing.Size(128, 206);
            this.curruntfiary.Name = "curruntfiary";
            this.curruntfiary.Size = new System.Drawing.Size(128, 206);
            this.curruntfiary.TabIndex = 0;
            this.curruntfiary.TabStop = false;
            // 
            // SelectFairy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectFairy";
            this.Text = "요정 선택";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectFairy_FormClosed);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.curruntfiary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox curruntfiary;
    }
}