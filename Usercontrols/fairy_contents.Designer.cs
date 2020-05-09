namespace GFBattleSimulator
{
    partial class fairyContents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fairyContents));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterbtn = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.trait = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.skillLv = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stat = new System.Windows.Forms.FlowLayoutPanel();
            this.crit = new System.Windows.Forms.Panel();
            this.critValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pow = new System.Windows.Forms.Panel();
            this.powValue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.hit = new System.Windows.Forms.Panel();
            this.hitValue = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dodge = new System.Windows.Forms.Panel();
            this.dodgeValue = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.armor = new System.Windows.Forms.Panel();
            this.armorValue = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toggle1 = new GFBattleSimulator.Usercontrols.Toggle();
            this.fairy_tile = new GFBattleSimulator.Usercontrols.fairy_tile();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.stat.SuspendLayout();
            this.crit.SuspendLayout();
            this.pow.SuspendLayout();
            this.hit.SuspendLayout();
            this.dodge.SuspendLayout();
            this.armor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidepanel.Location = new System.Drawing.Point(787, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(250, 539);
            this.sidepanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filterbtn);
            this.panel1.Controls.Add(this.loadbtn);
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.panel1.Size = new System.Drawing.Size(787, 40);
            this.panel1.TabIndex = 1;
            // 
            // filterbtn
            // 
            this.filterbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.filterbtn.FlatAppearance.BorderSize = 0;
            this.filterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterbtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterbtn.ForeColor = System.Drawing.Color.White;
            this.filterbtn.Location = new System.Drawing.Point(691, 0);
            this.filterbtn.Name = "filterbtn";
            this.filterbtn.Size = new System.Drawing.Size(40, 40);
            this.filterbtn.TabIndex = 2;
            this.filterbtn.Text = "filter";
            this.filterbtn.UseVisualStyleBackColor = true;
            // 
            // loadbtn
            // 
            this.loadbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.loadbtn.FlatAppearance.BorderSize = 0;
            this.loadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadbtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbtn.ForeColor = System.Drawing.Color.White;
            this.loadbtn.Location = new System.Drawing.Point(731, 0);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(40, 40);
            this.loadbtn.TabIndex = 1;
            this.loadbtn.Text = "load";
            this.loadbtn.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(16, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(141, 40);
            this.title.TabIndex = 0;
            this.title.Text = "요정 정보";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.panel2.Size = new System.Drawing.Size(787, 499);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.trait);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(24, 402);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panel5.Size = new System.Drawing.Size(739, 81);
            this.panel5.TabIndex = 2;
            // 
            // trait
            // 
            this.trait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.trait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trait.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trait.ForeColor = System.Drawing.Color.White;
            this.trait.FormattingEnabled = true;
            this.trait.Location = new System.Drawing.Point(3, 55);
            this.trait.Name = "trait";
            this.trait.Size = new System.Drawing.Size(150, 23);
            this.trait.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(-7, 8);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 8, 3, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 40);
            this.label15.TabIndex = 55;
            this.label15.Text = "요정 특성";
            // 
            // panel11
            // 
            this.panel11.AutoSize = true;
            this.panel11.Controls.Add(this.toggle1);
            this.panel11.Controls.Add(this.skillLv);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(24, 252);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panel11.Size = new System.Drawing.Size(739, 150);
            this.panel11.TabIndex = 1;
            // 
            // skillLv
            // 
            this.skillLv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.skillLv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skillLv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillLv.ForeColor = System.Drawing.Color.White;
            this.skillLv.FormattingEnabled = true;
            this.skillLv.Location = new System.Drawing.Point(3, 124);
            this.skillLv.Name = "skillLv";
            this.skillLv.Size = new System.Drawing.Size(150, 23);
            this.skillLv.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-4, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 56;
            this.label8.Text = "스킬레벨";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-7, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 40);
            this.label6.TabIndex = 55;
            this.label6.Text = "요정 스킬";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.fairy_tile);
            this.panel3.Controls.Add(this.stat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(24, 16);
            this.panel3.MaximumSize = new System.Drawing.Size(3000, 246);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.panel3.Size = new System.Drawing.Size(739, 236);
            this.panel3.TabIndex = 0;
            // 
            // stat
            // 
            this.stat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stat.AutoSize = true;
            this.stat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.stat.Controls.Add(this.crit);
            this.stat.Controls.Add(this.pow);
            this.stat.Controls.Add(this.hit);
            this.stat.Controls.Add(this.dodge);
            this.stat.Controls.Add(this.armor);
            this.stat.Location = new System.Drawing.Point(200, 11);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(507, 206);
            this.stat.TabIndex = 5;
            // 
            // crit
            // 
            this.crit.Controls.Add(this.critValue);
            this.crit.Controls.Add(this.label7);
            this.crit.Controls.Add(this.pictureBox1);
            this.crit.Location = new System.Drawing.Point(3, 3);
            this.crit.Name = "crit";
            this.crit.Padding = new System.Windows.Forms.Padding(8);
            this.crit.Size = new System.Drawing.Size(176, 41);
            this.crit.TabIndex = 0;
            // 
            // critValue
            // 
            this.critValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.critValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critValue.ForeColor = System.Drawing.Color.Lime;
            this.critValue.Location = new System.Drawing.Point(103, 8);
            this.critValue.Name = "critValue";
            this.critValue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.critValue.Size = new System.Drawing.Size(70, 25);
            this.critValue.TabIndex = 2;
            this.critValue.Text = "+ 값%";
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 8);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "치명상";
            // 
            // pow
            // 
            this.pow.Controls.Add(this.powValue);
            this.pow.Controls.Add(this.label11);
            this.pow.Controls.Add(this.pictureBox2);
            this.pow.Location = new System.Drawing.Point(185, 3);
            this.pow.Name = "pow";
            this.pow.Padding = new System.Windows.Forms.Padding(8);
            this.pow.Size = new System.Drawing.Size(176, 41);
            this.pow.TabIndex = 3;
            // 
            // powValue
            // 
            this.powValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.powValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powValue.ForeColor = System.Drawing.Color.Lime;
            this.powValue.Location = new System.Drawing.Point(103, 8);
            this.powValue.Name = "powValue";
            this.powValue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.powValue.Size = new System.Drawing.Size(70, 25);
            this.powValue.TabIndex = 2;
            this.powValue.Text = "+ 값%";
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(33, 8);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "화력";
            // 
            // hit
            // 
            this.hit.Controls.Add(this.hitValue);
            this.hit.Controls.Add(this.label19);
            this.hit.Controls.Add(this.pictureBox6);
            this.hit.Location = new System.Drawing.Point(3, 50);
            this.hit.Name = "hit";
            this.hit.Padding = new System.Windows.Forms.Padding(8);
            this.hit.Size = new System.Drawing.Size(176, 41);
            this.hit.TabIndex = 3;
            // 
            // hitValue
            // 
            this.hitValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.hitValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitValue.ForeColor = System.Drawing.Color.Lime;
            this.hitValue.Location = new System.Drawing.Point(103, 8);
            this.hitValue.Name = "hitValue";
            this.hitValue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.hitValue.Size = new System.Drawing.Size(70, 25);
            this.hitValue.TabIndex = 2;
            this.hitValue.Text = "+ 값%";
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Left;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(33, 8);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label19.Size = new System.Drawing.Size(70, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "명중";
            // 
            // dodge
            // 
            this.dodge.Controls.Add(this.dodgeValue);
            this.dodge.Controls.Add(this.label17);
            this.dodge.Controls.Add(this.pictureBox5);
            this.dodge.Location = new System.Drawing.Point(185, 50);
            this.dodge.Name = "dodge";
            this.dodge.Padding = new System.Windows.Forms.Padding(8);
            this.dodge.Size = new System.Drawing.Size(176, 41);
            this.dodge.TabIndex = 3;
            // 
            // dodgeValue
            // 
            this.dodgeValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodgeValue.ForeColor = System.Drawing.Color.Lime;
            this.dodgeValue.Location = new System.Drawing.Point(103, 8);
            this.dodgeValue.Name = "dodgeValue";
            this.dodgeValue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dodgeValue.Size = new System.Drawing.Size(70, 25);
            this.dodgeValue.TabIndex = 2;
            this.dodgeValue.Text = "+ 값%";
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Left;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(33, 8);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label17.Size = new System.Drawing.Size(70, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "회피";
            // 
            // armor
            // 
            this.armor.Controls.Add(this.armorValue);
            this.armor.Controls.Add(this.label13);
            this.armor.Controls.Add(this.pictureBox3);
            this.armor.Location = new System.Drawing.Point(3, 97);
            this.armor.Name = "armor";
            this.armor.Padding = new System.Windows.Forms.Padding(8);
            this.armor.Size = new System.Drawing.Size(176, 41);
            this.armor.TabIndex = 3;
            // 
            // armorValue
            // 
            this.armorValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.armorValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armorValue.ForeColor = System.Drawing.Color.Lime;
            this.armorValue.Location = new System.Drawing.Point(103, 8);
            this.armorValue.Name = "armorValue";
            this.armorValue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.armorValue.Size = new System.Drawing.Size(70, 25);
            this.armorValue.TabIndex = 2;
            this.armorValue.Text = "+ 값%";
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(33, 8);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label13.Size = new System.Drawing.Size(70, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "장갑";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GFBattleSimulator.Properties.Resources.치명상;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GFBattleSimulator.Properties.Resources.화력;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(25, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::GFBattleSimulator.Properties.Resources.명중;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox6.Location = new System.Drawing.Point(8, 8);
            this.pictureBox6.MinimumSize = new System.Drawing.Size(25, 25);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::GFBattleSimulator.Properties.Resources.회피;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox5.Location = new System.Drawing.Point(8, 8);
            this.pictureBox5.MinimumSize = new System.Drawing.Size(25, 25);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GFBattleSimulator.Properties.Resources.장갑;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Location = new System.Drawing.Point(8, 8);
            this.pictureBox3.MinimumSize = new System.Drawing.Size(25, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // toggle1
            // 
            this.toggle1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toggle1.BackColor = System.Drawing.Color.Transparent;
            this.toggle1.Location = new System.Drawing.Point(-1, 55);
            this.toggle1.Name = "toggle1";
            this.toggle1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toggle1.ShowTitle = false;
            this.toggle1.Size = new System.Drawing.Size(105, 34);
            this.toggle1.TabIndex = 58;
            this.toggle1.Title = "토글";
            this.toggle1.toggleState = true;
            // 
            // fairy_tile
            // 
            this.fairy_tile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fairy_tile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fairy_tile.BackgroundImage")));
            this.fairy_tile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fairy_tile.fairy_lv = "100";
            this.fairy_tile.Location = new System.Drawing.Point(40, 11);
            this.fairy_tile.Margin = new System.Windows.Forms.Padding(0);
            this.fairy_tile.MaximumSize = new System.Drawing.Size(128, 204);
            this.fairy_tile.MinimumSize = new System.Drawing.Size(128, 204);
            this.fairy_tile.Name = "fairy_tile";
            this.fairy_tile.Size = new System.Drawing.Size(128, 204);
            this.fairy_tile.TabIndex = 6;
            // 
            // fairyContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidepanel);
            this.Name = "fairyContents";
            this.Size = new System.Drawing.Size(1037, 539);
            this.Load += new System.EventHandler(this.fairyContents_Load);
            this.SizeChanged += new System.EventHandler(this.UserControl4_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.stat.ResumeLayout(false);
            this.crit.ResumeLayout(false);
            this.pow.ResumeLayout(false);
            this.hit.ResumeLayout(false);
            this.dodge.ResumeLayout(false);
            this.armor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button filterbtn;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel stat;
        private System.Windows.Forms.Panel crit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label critValue;
        private System.Windows.Forms.Panel pow;
        private System.Windows.Forms.Label powValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel hit;
        private System.Windows.Forms.Label hitValue;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel dodge;
        private System.Windows.Forms.Label dodgeValue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel armor;
        private System.Windows.Forms.Label armorValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel11;
        private Usercontrols.Toggle toggle1;
        private System.Windows.Forms.ComboBox skillLv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox trait;
        private System.Windows.Forms.Label label15;
        private Usercontrols.fairy_tile fairy_tile;
    }
}
