namespace GFBattleSimulator
{
    partial class Main
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.Panel();
            this.chip_info = new System.Windows.Forms.Button();
            this.firesupport_info = new System.Windows.Forms.Button();
            this.fairy_info = new System.Windows.Forms.Button();
            this.equip_info = new System.Windows.Forms.Button();
            this.squad_info = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.settingpanel = new System.Windows.Forms.Panel();
            this.settingIndicator = new System.Windows.Forms.Panel();
            this.settingbtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.header = new System.Windows.Forms.Panel();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.normalbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.settingpanel.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panelMenu.Controls.Add(this.indicator);
            this.panelMenu.Controls.Add(this.chip_info);
            this.panelMenu.Controls.Add(this.firesupport_info);
            this.panelMenu.Controls.Add(this.fairy_info);
            this.panelMenu.Controls.Add(this.equip_info);
            this.panelMenu.Controls.Add(this.squad_info);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.settingpanel);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            resources.ApplyResources(this.indicator, "indicator");
            this.indicator.Name = "indicator";
            // 
            // chip_info
            // 
            this.chip_info.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.chip_info, "chip_info");
            this.chip_info.FlatAppearance.BorderSize = 0;
            this.chip_info.ForeColor = System.Drawing.Color.White;
            this.chip_info.Name = "chip_info";
            this.chip_info.UseVisualStyleBackColor = false;
            this.chip_info.Click += new System.EventHandler(this.chip_info_Click);
            // 
            // firesupport_info
            // 
            this.firesupport_info.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.firesupport_info, "firesupport_info");
            this.firesupport_info.FlatAppearance.BorderSize = 0;
            this.firesupport_info.ForeColor = System.Drawing.Color.White;
            this.firesupport_info.Name = "firesupport_info";
            this.firesupport_info.UseVisualStyleBackColor = false;
            this.firesupport_info.Click += new System.EventHandler(this.firesupport_info_Click);
            // 
            // fairy_info
            // 
            this.fairy_info.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.fairy_info, "fairy_info");
            this.fairy_info.FlatAppearance.BorderSize = 0;
            this.fairy_info.ForeColor = System.Drawing.Color.White;
            this.fairy_info.Name = "fairy_info";
            this.fairy_info.UseVisualStyleBackColor = false;
            this.fairy_info.Click += new System.EventHandler(this.fairy_info_Click);
            // 
            // equip_info
            // 
            this.equip_info.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.equip_info, "equip_info");
            this.equip_info.FlatAppearance.BorderSize = 0;
            this.equip_info.ForeColor = System.Drawing.Color.White;
            this.equip_info.Name = "equip_info";
            this.equip_info.UseVisualStyleBackColor = false;
            this.equip_info.Click += new System.EventHandler(this.equip_info_Click);
            // 
            // squad_info
            // 
            this.squad_info.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.squad_info, "squad_info");
            this.squad_info.FlatAppearance.BorderSize = 0;
            this.squad_info.ForeColor = System.Drawing.Color.White;
            this.squad_info.Name = "squad_info";
            this.squad_info.UseVisualStyleBackColor = false;
            this.squad_info.Click += new System.EventHandler(this.squad_info_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Title);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Name = "Title";
            // 
            // settingpanel
            // 
            this.settingpanel.BackColor = System.Drawing.Color.Transparent;
            this.settingpanel.Controls.Add(this.settingIndicator);
            this.settingpanel.Controls.Add(this.settingbtn);
            resources.ApplyResources(this.settingpanel, "settingpanel");
            this.settingpanel.Name = "settingpanel";
            // 
            // settingIndicator
            // 
            this.settingIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            resources.ApplyResources(this.settingIndicator, "settingIndicator");
            this.settingIndicator.Name = "settingIndicator";
            // 
            // settingbtn
            // 
            this.settingbtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.settingbtn, "settingbtn");
            this.settingbtn.ForeColor = System.Drawing.Color.White;
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.UseVisualStyleBackColor = true;
            this.settingbtn.Click += new System.EventHandler(this.settingbtn_click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.header.Controls.Add(this.minimizebtn);
            this.header.Controls.Add(this.normalbtn);
            this.header.Controls.Add(this.closebtn);
            resources.ApplyResources(this.header, "header");
            this.header.Name = "header";
            this.header.DoubleClick += new System.EventHandler(this.header_DoubleClick);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            // 
            // minimizebtn
            // 
            resources.ApplyResources(this.minimizebtn, "minimizebtn");
            this.minimizebtn.FlatAppearance.BorderSize = 0;
            this.minimizebtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.UseVisualStyleBackColor = true;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // normalbtn
            // 
            resources.ApplyResources(this.normalbtn, "normalbtn");
            this.normalbtn.FlatAppearance.BorderSize = 0;
            this.normalbtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.normalbtn.Name = "normalbtn";
            this.normalbtn.UseVisualStyleBackColor = true;
            this.normalbtn.Click += new System.EventHandler(this.normalbtn_Click);
            // 
            // closebtn
            // 
            resources.ApplyResources(this.closebtn, "closebtn");
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.closebtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.closebtn.Name = "closebtn";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            resources.ApplyResources(this.contentPanel, "contentPanel");
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.SizeChanged += new System.EventHandler(this.contentPanel_SizeChanged);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.settingpanel.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button chip_info;
        private System.Windows.Forms.Button firesupport_info;
        private System.Windows.Forms.Button fairy_info;
        private System.Windows.Forms.Button equip_info;
        private System.Windows.Forms.Button squad_info;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Button normalbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel indicator;
        public System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel settingpanel;
        private System.Windows.Forms.Button settingbtn;
        private System.Windows.Forms.Panel settingIndicator;
    }
}

