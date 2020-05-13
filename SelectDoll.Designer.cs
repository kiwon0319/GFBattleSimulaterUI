namespace GFBattleSimulator
{
    partial class SelectDoll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDoll));
            this.title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.curruntdoll = new System.Windows.Forms.PictureBox();
            this.title.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curruntdoll)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Controls.Add(this.label1);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 20);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.title.Size = new System.Drawing.Size(800, 40);
            this.title.TabIndex = 0;
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
            this.label1.Text = "인형선택";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.curruntdoll);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 220);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(25, 8, 25, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 382);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // curruntdoll
            // 
            this.curruntdoll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("curruntdoll.BackgroundImage")));
            this.curruntdoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.curruntdoll.Image = ((System.Drawing.Image)(resources.GetObject("curruntdoll.Image")));
            this.curruntdoll.Location = new System.Drawing.Point(28, 11);
            this.curruntdoll.MaximumSize = new System.Drawing.Size(128, 206);
            this.curruntdoll.MinimumSize = new System.Drawing.Size(128, 206);
            this.curruntdoll.Name = "curruntdoll";
            this.curruntdoll.Size = new System.Drawing.Size(128, 206);
            this.curruntdoll.TabIndex = 0;
            this.curruntdoll.TabStop = false;
            this.curruntdoll.Click += new System.EventHandler(this.curruntdoll_Click);
            // 
            // SelectDoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectDoll";
            this.Padding = new System.Windows.Forms.Padding(0, 20, 0, 8);
            this.Text = "인형 선택";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectDoll_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectDoll_FormClosed);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.curruntdoll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox curruntdoll;
    }
}