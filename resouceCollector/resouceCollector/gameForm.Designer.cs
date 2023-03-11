namespace resouceCollector
{
    partial class gameForm
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
            this.components = new System.ComponentModel.Container();
            this.resourceButton = new System.Windows.Forms.Button();
            this.titaniumToRocket = new System.Windows.Forms.Button();
            this.diamondToRocket = new System.Windows.Forms.Button();
            this.ironToRocket = new System.Windows.Forms.Button();
            this.goldToRocket = new System.Windows.Forms.Button();
            this.rocketProgressBar = new System.Windows.Forms.ProgressBar();
            this.titaniumTextBox = new System.Windows.Forms.TextBox();
            this.ironPerClickUpgrade = new System.Windows.Forms.Button();
            this.ironPerSecondUpgrade1 = new System.Windows.Forms.Button();
            this.ironPerSecondUpgrade2 = new System.Windows.Forms.Button();
            this.ironPerSecondUpgrade3 = new System.Windows.Forms.Button();
            this.goldPerSecondUpgrade3 = new System.Windows.Forms.Button();
            this.goldPerSecondUpgrade2 = new System.Windows.Forms.Button();
            this.goldPerSecondUpgrade1 = new System.Windows.Forms.Button();
            this.goldPerClickUpgrade = new System.Windows.Forms.Button();
            this.titaniumPerSecondUpgrade3 = new System.Windows.Forms.Button();
            this.titaniumPerSecondUpgrade2 = new System.Windows.Forms.Button();
            this.titaniumPerSecondUpgrade1 = new System.Windows.Forms.Button();
            this.titaniumPerClickUpgrade = new System.Windows.Forms.Button();
            this.diamondPerSecondUpgrade3 = new System.Windows.Forms.Button();
            this.diamondPerSecondUpgrade2 = new System.Windows.Forms.Button();
            this.diamondPerSecondUpgrade1 = new System.Windows.Forms.Button();
            this.diamondPerClickUpgrade = new System.Windows.Forms.Button();
            this.ironTextBox = new System.Windows.Forms.TextBox();
            this.goldTextBox = new System.Windows.Forms.TextBox();
            this.diamondTextBox = new System.Windows.Forms.TextBox();
            this.textUpdater = new System.Windows.Forms.Timer(this.components);
            this.perSecondResource = new System.Windows.Forms.Timer(this.components);
            this.saveGameButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showMinerUpgrades = new System.Windows.Forms.Button();
            this.minerUpgrades = new System.Windows.Forms.Panel();
            this.ironMinerUpgrade = new System.Windows.Forms.Button();
            this.goldMinerUpgrade = new System.Windows.Forms.Button();
            this.titaniumMinerUpgrade = new System.Windows.Forms.Button();
            this.diamondMinerUpgrade = new System.Windows.Forms.Button();
            this.showDrillUpgrades = new System.Windows.Forms.Button();
            this.drillUpgrades = new System.Windows.Forms.Panel();
            this.diamondDrillUpgrade = new System.Windows.Forms.Button();
            this.titaniumDrillUpgrade = new System.Windows.Forms.Button();
            this.goldDrillUpgrade = new System.Windows.Forms.Button();
            this.ironDrillUpgrade = new System.Windows.Forms.Button();
            this.showEscUpgrades = new System.Windows.Forms.Button();
            this.excavatorUpgrades = new System.Windows.Forms.Panel();
            this.diamondEscUpgrade = new System.Windows.Forms.Button();
            this.titaniumEscUpgrade = new System.Windows.Forms.Button();
            this.goldEscUpgrade = new System.Windows.Forms.Button();
            this.ironEscUpgrade = new System.Windows.Forms.Button();
            this.minerUpgrades.SuspendLayout();
            this.drillUpgrades.SuspendLayout();
            this.excavatorUpgrades.SuspendLayout();
            this.SuspendLayout();
            // 
            // resourceButton
            // 
            this.resourceButton.Location = new System.Drawing.Point(12, 154);
            this.resourceButton.Name = "resourceButton";
            this.resourceButton.Size = new System.Drawing.Size(286, 276);
            this.resourceButton.TabIndex = 1;
            this.resourceButton.Text = "resource button";
            this.resourceButton.UseVisualStyleBackColor = true;
            this.resourceButton.Click += new System.EventHandler(this.resourceButton_Click);
            // 
            // titaniumToRocket
            // 
            this.titaniumToRocket.Location = new System.Drawing.Point(12, 570);
            this.titaniumToRocket.Name = "titaniumToRocket";
            this.titaniumToRocket.Size = new System.Drawing.Size(140, 71);
            this.titaniumToRocket.TabIndex = 2;
            this.titaniumToRocket.Text = "tit to rocket";
            this.titaniumToRocket.UseVisualStyleBackColor = true;
            this.titaniumToRocket.Click += new System.EventHandler(this.titaniumToRocket_Click);
            // 
            // diamondToRocket
            // 
            this.diamondToRocket.Location = new System.Drawing.Point(158, 570);
            this.diamondToRocket.Name = "diamondToRocket";
            this.diamondToRocket.Size = new System.Drawing.Size(140, 71);
            this.diamondToRocket.TabIndex = 3;
            this.diamondToRocket.Text = "diam to rocket";
            this.diamondToRocket.UseVisualStyleBackColor = true;
            this.diamondToRocket.Click += new System.EventHandler(this.diamondToRocket_Click);
            // 
            // ironToRocket
            // 
            this.ironToRocket.Location = new System.Drawing.Point(12, 493);
            this.ironToRocket.Name = "ironToRocket";
            this.ironToRocket.Size = new System.Drawing.Size(140, 71);
            this.ironToRocket.TabIndex = 4;
            this.ironToRocket.Text = "iron to rocket";
            this.ironToRocket.UseVisualStyleBackColor = true;
            this.ironToRocket.Click += new System.EventHandler(this.ironToRocket_Click);
            // 
            // goldToRocket
            // 
            this.goldToRocket.Location = new System.Drawing.Point(158, 493);
            this.goldToRocket.Name = "goldToRocket";
            this.goldToRocket.Size = new System.Drawing.Size(140, 71);
            this.goldToRocket.TabIndex = 5;
            this.goldToRocket.Text = "gold to rocket";
            this.goldToRocket.UseVisualStyleBackColor = true;
            this.goldToRocket.Click += new System.EventHandler(this.goldToRocket_Click);
            // 
            // rocketProgressBar
            // 
            this.rocketProgressBar.Location = new System.Drawing.Point(12, 643);
            this.rocketProgressBar.Name = "rocketProgressBar";
            this.rocketProgressBar.Size = new System.Drawing.Size(286, 23);
            this.rocketProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.rocketProgressBar.TabIndex = 6;
            this.rocketProgressBar.Click += new System.EventHandler(this.rocketProgressBar_Click);
            // 
            // titaniumTextBox
            // 
            this.titaniumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titaniumTextBox.Location = new System.Drawing.Point(12, 83);
            this.titaniumTextBox.Multiline = true;
            this.titaniumTextBox.Name = "titaniumTextBox";
            this.titaniumTextBox.ReadOnly = true;
            this.titaniumTextBox.Size = new System.Drawing.Size(140, 65);
            this.titaniumTextBox.TabIndex = 10;
            this.titaniumTextBox.TabStop = false;
            this.titaniumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ironPerClickUpgrade
            // 
            this.ironPerClickUpgrade.Location = new System.Drawing.Point(312, 12);
            this.ironPerClickUpgrade.Name = "ironPerClickUpgrade";
            this.ironPerClickUpgrade.Size = new System.Drawing.Size(130, 100);
            this.ironPerClickUpgrade.TabIndex = 12;
            this.ironPerClickUpgrade.UseVisualStyleBackColor = true;
            this.ironPerClickUpgrade.Click += new System.EventHandler(this.ironPerClickUpgrade_Click);
            // 
            // ironPerSecondUpgrade1
            // 
            this.ironPerSecondUpgrade1.Location = new System.Drawing.Point(448, 12);
            this.ironPerSecondUpgrade1.Name = "ironPerSecondUpgrade1";
            this.ironPerSecondUpgrade1.Size = new System.Drawing.Size(130, 100);
            this.ironPerSecondUpgrade1.TabIndex = 13;
            this.ironPerSecondUpgrade1.Text = "iron per sec up1";
            this.ironPerSecondUpgrade1.UseVisualStyleBackColor = true;
            this.ironPerSecondUpgrade1.Click += new System.EventHandler(this.ironPerSecondUpgrade1_Click);
            // 
            // ironPerSecondUpgrade2
            // 
            this.ironPerSecondUpgrade2.Location = new System.Drawing.Point(584, 12);
            this.ironPerSecondUpgrade2.Name = "ironPerSecondUpgrade2";
            this.ironPerSecondUpgrade2.Size = new System.Drawing.Size(130, 100);
            this.ironPerSecondUpgrade2.TabIndex = 14;
            this.ironPerSecondUpgrade2.Text = "iron per sec up2";
            this.ironPerSecondUpgrade2.UseVisualStyleBackColor = true;
            this.ironPerSecondUpgrade2.Click += new System.EventHandler(this.ironPerSecondUpgrade2_Click);
            // 
            // ironPerSecondUpgrade3
            // 
            this.ironPerSecondUpgrade3.Location = new System.Drawing.Point(720, 12);
            this.ironPerSecondUpgrade3.Name = "ironPerSecondUpgrade3";
            this.ironPerSecondUpgrade3.Size = new System.Drawing.Size(130, 100);
            this.ironPerSecondUpgrade3.TabIndex = 15;
            this.ironPerSecondUpgrade3.Text = "iron per sec up2";
            this.ironPerSecondUpgrade3.UseVisualStyleBackColor = true;
            this.ironPerSecondUpgrade3.Click += new System.EventHandler(this.ironPerSecondUpgrade3_Click);
            // 
            // goldPerSecondUpgrade3
            // 
            this.goldPerSecondUpgrade3.Location = new System.Drawing.Point(720, 118);
            this.goldPerSecondUpgrade3.Name = "goldPerSecondUpgrade3";
            this.goldPerSecondUpgrade3.Size = new System.Drawing.Size(130, 100);
            this.goldPerSecondUpgrade3.TabIndex = 19;
            this.goldPerSecondUpgrade3.Text = "gold per sec up3";
            this.goldPerSecondUpgrade3.UseVisualStyleBackColor = true;
            this.goldPerSecondUpgrade3.Click += new System.EventHandler(this.goldPerSecondUpgrade3_Click);
            // 
            // goldPerSecondUpgrade2
            // 
            this.goldPerSecondUpgrade2.Location = new System.Drawing.Point(584, 118);
            this.goldPerSecondUpgrade2.Name = "goldPerSecondUpgrade2";
            this.goldPerSecondUpgrade2.Size = new System.Drawing.Size(130, 100);
            this.goldPerSecondUpgrade2.TabIndex = 18;
            this.goldPerSecondUpgrade2.Text = "gold per sec up2";
            this.goldPerSecondUpgrade2.UseVisualStyleBackColor = true;
            this.goldPerSecondUpgrade2.Click += new System.EventHandler(this.goldPerSecondUpgrade2_Click);
            // 
            // goldPerSecondUpgrade1
            // 
            this.goldPerSecondUpgrade1.Location = new System.Drawing.Point(448, 118);
            this.goldPerSecondUpgrade1.Name = "goldPerSecondUpgrade1";
            this.goldPerSecondUpgrade1.Size = new System.Drawing.Size(130, 100);
            this.goldPerSecondUpgrade1.TabIndex = 17;
            this.goldPerSecondUpgrade1.Text = "gold per sec up1";
            this.goldPerSecondUpgrade1.UseVisualStyleBackColor = true;
            this.goldPerSecondUpgrade1.Click += new System.EventHandler(this.goldPerSecondUpgrade1_Click);
            // 
            // goldPerClickUpgrade
            // 
            this.goldPerClickUpgrade.Location = new System.Drawing.Point(312, 118);
            this.goldPerClickUpgrade.Name = "goldPerClickUpgrade";
            this.goldPerClickUpgrade.Size = new System.Drawing.Size(130, 100);
            this.goldPerClickUpgrade.TabIndex = 16;
            this.goldPerClickUpgrade.Text = "goldperclickupgrade";
            this.goldPerClickUpgrade.UseVisualStyleBackColor = true;
            this.goldPerClickUpgrade.Click += new System.EventHandler(this.goldPerClickUpgrade_Click);
            // 
            // titaniumPerSecondUpgrade3
            // 
            this.titaniumPerSecondUpgrade3.Location = new System.Drawing.Point(720, 224);
            this.titaniumPerSecondUpgrade3.Name = "titaniumPerSecondUpgrade3";
            this.titaniumPerSecondUpgrade3.Size = new System.Drawing.Size(130, 100);
            this.titaniumPerSecondUpgrade3.TabIndex = 23;
            this.titaniumPerSecondUpgrade3.Text = "tit per sec up3";
            this.titaniumPerSecondUpgrade3.UseVisualStyleBackColor = true;
            this.titaniumPerSecondUpgrade3.Click += new System.EventHandler(this.titaniumPerSecondUpgrade3_Click);
            // 
            // titaniumPerSecondUpgrade2
            // 
            this.titaniumPerSecondUpgrade2.Location = new System.Drawing.Point(584, 224);
            this.titaniumPerSecondUpgrade2.Name = "titaniumPerSecondUpgrade2";
            this.titaniumPerSecondUpgrade2.Size = new System.Drawing.Size(130, 100);
            this.titaniumPerSecondUpgrade2.TabIndex = 22;
            this.titaniumPerSecondUpgrade2.Text = "tit per sec up2";
            this.titaniumPerSecondUpgrade2.UseVisualStyleBackColor = true;
            this.titaniumPerSecondUpgrade2.Click += new System.EventHandler(this.titaniumPerSecondUpgrade2_Click);
            // 
            // titaniumPerSecondUpgrade1
            // 
            this.titaniumPerSecondUpgrade1.Location = new System.Drawing.Point(448, 224);
            this.titaniumPerSecondUpgrade1.Name = "titaniumPerSecondUpgrade1";
            this.titaniumPerSecondUpgrade1.Size = new System.Drawing.Size(130, 100);
            this.titaniumPerSecondUpgrade1.TabIndex = 21;
            this.titaniumPerSecondUpgrade1.Text = "tit per sec up1";
            this.titaniumPerSecondUpgrade1.UseVisualStyleBackColor = true;
            this.titaniumPerSecondUpgrade1.Click += new System.EventHandler(this.titaniumPerSecondUpgrade1_Click);
            // 
            // titaniumPerClickUpgrade
            // 
            this.titaniumPerClickUpgrade.Location = new System.Drawing.Point(312, 224);
            this.titaniumPerClickUpgrade.Name = "titaniumPerClickUpgrade";
            this.titaniumPerClickUpgrade.Size = new System.Drawing.Size(130, 100);
            this.titaniumPerClickUpgrade.TabIndex = 20;
            this.titaniumPerClickUpgrade.Text = "titperclickupgrade";
            this.titaniumPerClickUpgrade.UseVisualStyleBackColor = true;
            this.titaniumPerClickUpgrade.Click += new System.EventHandler(this.titaniumPerClickUpgrade_Click);
            // 
            // diamondPerSecondUpgrade3
            // 
            this.diamondPerSecondUpgrade3.Location = new System.Drawing.Point(720, 330);
            this.diamondPerSecondUpgrade3.Name = "diamondPerSecondUpgrade3";
            this.diamondPerSecondUpgrade3.Size = new System.Drawing.Size(130, 100);
            this.diamondPerSecondUpgrade3.TabIndex = 27;
            this.diamondPerSecondUpgrade3.Text = "diam per sec up3";
            this.diamondPerSecondUpgrade3.UseVisualStyleBackColor = true;
            this.diamondPerSecondUpgrade3.Click += new System.EventHandler(this.diamondPerSecondUpgrade3_Click);
            // 
            // diamondPerSecondUpgrade2
            // 
            this.diamondPerSecondUpgrade2.Location = new System.Drawing.Point(584, 330);
            this.diamondPerSecondUpgrade2.Name = "diamondPerSecondUpgrade2";
            this.diamondPerSecondUpgrade2.Size = new System.Drawing.Size(130, 100);
            this.diamondPerSecondUpgrade2.TabIndex = 26;
            this.diamondPerSecondUpgrade2.Text = "diam per sec up2";
            this.diamondPerSecondUpgrade2.UseVisualStyleBackColor = true;
            this.diamondPerSecondUpgrade2.Click += new System.EventHandler(this.diamondPerSecondUpgrade2_Click);
            // 
            // diamondPerSecondUpgrade1
            // 
            this.diamondPerSecondUpgrade1.Location = new System.Drawing.Point(448, 330);
            this.diamondPerSecondUpgrade1.Name = "diamondPerSecondUpgrade1";
            this.diamondPerSecondUpgrade1.Size = new System.Drawing.Size(130, 100);
            this.diamondPerSecondUpgrade1.TabIndex = 25;
            this.diamondPerSecondUpgrade1.Text = "diam per sec up1";
            this.diamondPerSecondUpgrade1.UseVisualStyleBackColor = true;
            this.diamondPerSecondUpgrade1.Click += new System.EventHandler(this.diamondPerSecondUpgrade1_Click);
            // 
            // diamondPerClickUpgrade
            // 
            this.diamondPerClickUpgrade.Location = new System.Drawing.Point(312, 330);
            this.diamondPerClickUpgrade.Name = "diamondPerClickUpgrade";
            this.diamondPerClickUpgrade.Size = new System.Drawing.Size(130, 100);
            this.diamondPerClickUpgrade.TabIndex = 24;
            this.diamondPerClickUpgrade.Text = "diamperclickupgrade";
            this.diamondPerClickUpgrade.UseVisualStyleBackColor = true;
            this.diamondPerClickUpgrade.Click += new System.EventHandler(this.diamondPerClickUpgrade_Click);
            // 
            // ironTextBox
            // 
            this.ironTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ironTextBox.Location = new System.Drawing.Point(12, 12);
            this.ironTextBox.Multiline = true;
            this.ironTextBox.Name = "ironTextBox";
            this.ironTextBox.ReadOnly = true;
            this.ironTextBox.Size = new System.Drawing.Size(140, 65);
            this.ironTextBox.TabIndex = 28;
            this.ironTextBox.TabStop = false;
            this.ironTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ironTextBox.TextChanged += new System.EventHandler(this.ironTextBox_TextChanged);
            // 
            // goldTextBox
            // 
            this.goldTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goldTextBox.Location = new System.Drawing.Point(158, 12);
            this.goldTextBox.Multiline = true;
            this.goldTextBox.Name = "goldTextBox";
            this.goldTextBox.ReadOnly = true;
            this.goldTextBox.Size = new System.Drawing.Size(140, 65);
            this.goldTextBox.TabIndex = 30;
            this.goldTextBox.TabStop = false;
            this.goldTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // diamondTextBox
            // 
            this.diamondTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diamondTextBox.Location = new System.Drawing.Point(158, 83);
            this.diamondTextBox.Multiline = true;
            this.diamondTextBox.Name = "diamondTextBox";
            this.diamondTextBox.ReadOnly = true;
            this.diamondTextBox.Size = new System.Drawing.Size(140, 65);
            this.diamondTextBox.TabIndex = 29;
            this.diamondTextBox.TabStop = false;
            this.diamondTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textUpdater
            // 
            this.textUpdater.Tick += new System.EventHandler(this.textUpdater_Tick);
            // 
            // perSecondResource
            // 
            this.perSecondResource.Enabled = true;
            this.perSecondResource.Interval = 1000;
            this.perSecondResource.Tick += new System.EventHandler(this.perSecondResource_Tick);
            // 
            // saveGameButton
            // 
            this.saveGameButton.Location = new System.Drawing.Point(12, 436);
            this.saveGameButton.Name = "saveGameButton";
            this.saveGameButton.Size = new System.Drawing.Size(286, 32);
            this.saveGameButton.TabIndex = 31;
            this.saveGameButton.Text = "saveButton";
            this.saveGameButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 474);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(286, 13);
            this.textBox1.TabIndex = 33;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Use resources to build your rocket out of here!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // showMinerUpgrades
            // 
            this.showMinerUpgrades.Location = new System.Drawing.Point(448, 436);
            this.showMinerUpgrades.Margin = new System.Windows.Forms.Padding(0);
            this.showMinerUpgrades.Name = "showMinerUpgrades";
            this.showMinerUpgrades.Size = new System.Drawing.Size(130, 51);
            this.showMinerUpgrades.TabIndex = 34;
            this.showMinerUpgrades.Text = "MINER UPGRADES";
            this.showMinerUpgrades.UseVisualStyleBackColor = true;
            this.showMinerUpgrades.Click += new System.EventHandler(this.showMinerUpgrades_Click);
            // 
            // minerUpgrades
            // 
            this.minerUpgrades.Controls.Add(this.diamondMinerUpgrade);
            this.minerUpgrades.Controls.Add(this.titaniumMinerUpgrade);
            this.minerUpgrades.Controls.Add(this.goldMinerUpgrade);
            this.minerUpgrades.Controls.Add(this.ironMinerUpgrade);
            this.minerUpgrades.Location = new System.Drawing.Point(448, 487);
            this.minerUpgrades.Margin = new System.Windows.Forms.Padding(0);
            this.minerUpgrades.Name = "minerUpgrades";
            this.minerUpgrades.Size = new System.Drawing.Size(130, 179);
            this.minerUpgrades.TabIndex = 35;
            this.minerUpgrades.Visible = false;
            // 
            // ironMinerUpgrade
            // 
            this.ironMinerUpgrade.Location = new System.Drawing.Point(0, 0);
            this.ironMinerUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.ironMinerUpgrade.Name = "ironMinerUpgrade";
            this.ironMinerUpgrade.Size = new System.Drawing.Size(130, 45);
            this.ironMinerUpgrade.TabIndex = 0;
            this.ironMinerUpgrade.Text = "Iron miner upgrade";
            this.ironMinerUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ironMinerUpgrade.UseVisualStyleBackColor = true;
            this.ironMinerUpgrade.Click += new System.EventHandler(this.ironMinerUpgrade_Click);
            // 
            // goldMinerUpgrade
            // 
            this.goldMinerUpgrade.Location = new System.Drawing.Point(0, 45);
            this.goldMinerUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.goldMinerUpgrade.Name = "goldMinerUpgrade";
            this.goldMinerUpgrade.Size = new System.Drawing.Size(130, 45);
            this.goldMinerUpgrade.TabIndex = 1;
            this.goldMinerUpgrade.Text = "Gold miner upgrade";
            this.goldMinerUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.goldMinerUpgrade.UseVisualStyleBackColor = true;
            this.goldMinerUpgrade.Click += new System.EventHandler(this.goldMinerUpgrade_Click);
            // 
            // titaniumMinerUpgrade
            // 
            this.titaniumMinerUpgrade.Location = new System.Drawing.Point(0, 90);
            this.titaniumMinerUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.titaniumMinerUpgrade.Name = "titaniumMinerUpgrade";
            this.titaniumMinerUpgrade.Size = new System.Drawing.Size(130, 45);
            this.titaniumMinerUpgrade.TabIndex = 2;
            this.titaniumMinerUpgrade.Text = "Titanium miner upgrade";
            this.titaniumMinerUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titaniumMinerUpgrade.UseVisualStyleBackColor = true;
            this.titaniumMinerUpgrade.Click += new System.EventHandler(this.titaniumMinerUpgrade_Click);
            // 
            // diamondMinerUpgrade
            // 
            this.diamondMinerUpgrade.Location = new System.Drawing.Point(0, 134);
            this.diamondMinerUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.diamondMinerUpgrade.Name = "diamondMinerUpgrade";
            this.diamondMinerUpgrade.Size = new System.Drawing.Size(130, 45);
            this.diamondMinerUpgrade.TabIndex = 3;
            this.diamondMinerUpgrade.Text = "Diamond Miner Upgrade";
            this.diamondMinerUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.diamondMinerUpgrade.UseVisualStyleBackColor = true;
            this.diamondMinerUpgrade.Click += new System.EventHandler(this.diamondMinerUpgrade_Click);
            // 
            // showDrillUpgrades
            // 
            this.showDrillUpgrades.Location = new System.Drawing.Point(584, 436);
            this.showDrillUpgrades.Margin = new System.Windows.Forms.Padding(0);
            this.showDrillUpgrades.Name = "showDrillUpgrades";
            this.showDrillUpgrades.Size = new System.Drawing.Size(130, 51);
            this.showDrillUpgrades.TabIndex = 36;
            this.showDrillUpgrades.Text = "DRILL UPGRADES";
            this.showDrillUpgrades.UseVisualStyleBackColor = true;
            this.showDrillUpgrades.Click += new System.EventHandler(this.showDrillUpgrades_Click);
            // 
            // drillUpgrades
            // 
            this.drillUpgrades.Controls.Add(this.diamondDrillUpgrade);
            this.drillUpgrades.Controls.Add(this.titaniumDrillUpgrade);
            this.drillUpgrades.Controls.Add(this.goldDrillUpgrade);
            this.drillUpgrades.Controls.Add(this.ironDrillUpgrade);
            this.drillUpgrades.Location = new System.Drawing.Point(584, 487);
            this.drillUpgrades.Margin = new System.Windows.Forms.Padding(0);
            this.drillUpgrades.Name = "drillUpgrades";
            this.drillUpgrades.Size = new System.Drawing.Size(130, 179);
            this.drillUpgrades.TabIndex = 37;
            this.drillUpgrades.Visible = false;
            // 
            // diamondDrillUpgrade
            // 
            this.diamondDrillUpgrade.Location = new System.Drawing.Point(0, 134);
            this.diamondDrillUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.diamondDrillUpgrade.Name = "diamondDrillUpgrade";
            this.diamondDrillUpgrade.Size = new System.Drawing.Size(130, 45);
            this.diamondDrillUpgrade.TabIndex = 3;
            this.diamondDrillUpgrade.Text = "diamond drill upgrade";
            this.diamondDrillUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.diamondDrillUpgrade.UseVisualStyleBackColor = true;
            this.diamondDrillUpgrade.Click += new System.EventHandler(this.diamondDrillUpgrade_Click);
            // 
            // titaniumDrillUpgrade
            // 
            this.titaniumDrillUpgrade.Location = new System.Drawing.Point(0, 90);
            this.titaniumDrillUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.titaniumDrillUpgrade.Name = "titaniumDrillUpgrade";
            this.titaniumDrillUpgrade.Size = new System.Drawing.Size(130, 45);
            this.titaniumDrillUpgrade.TabIndex = 2;
            this.titaniumDrillUpgrade.Text = "Titanium Drill upgrade";
            this.titaniumDrillUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titaniumDrillUpgrade.UseVisualStyleBackColor = true;
            this.titaniumDrillUpgrade.Click += new System.EventHandler(this.titaniumDrillUpgrade_Click);
            // 
            // goldDrillUpgrade
            // 
            this.goldDrillUpgrade.Location = new System.Drawing.Point(0, 45);
            this.goldDrillUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.goldDrillUpgrade.Name = "goldDrillUpgrade";
            this.goldDrillUpgrade.Size = new System.Drawing.Size(130, 45);
            this.goldDrillUpgrade.TabIndex = 1;
            this.goldDrillUpgrade.Text = "Gold drill upgrade";
            this.goldDrillUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.goldDrillUpgrade.UseVisualStyleBackColor = true;
            this.goldDrillUpgrade.Click += new System.EventHandler(this.goldDrillUpgrade_Click);
            // 
            // ironDrillUpgrade
            // 
            this.ironDrillUpgrade.Location = new System.Drawing.Point(0, 0);
            this.ironDrillUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.ironDrillUpgrade.Name = "ironDrillUpgrade";
            this.ironDrillUpgrade.Size = new System.Drawing.Size(130, 45);
            this.ironDrillUpgrade.TabIndex = 0;
            this.ironDrillUpgrade.Text = "Iron drill upgrade";
            this.ironDrillUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ironDrillUpgrade.UseVisualStyleBackColor = true;
            this.ironDrillUpgrade.Click += new System.EventHandler(this.ironDrillUpgrade_Click);
            // 
            // showEscUpgrades
            // 
            this.showEscUpgrades.Location = new System.Drawing.Point(720, 436);
            this.showEscUpgrades.Margin = new System.Windows.Forms.Padding(0);
            this.showEscUpgrades.Name = "showEscUpgrades";
            this.showEscUpgrades.Size = new System.Drawing.Size(130, 51);
            this.showEscUpgrades.TabIndex = 38;
            this.showEscUpgrades.Text = "ESC UPGRADES";
            this.showEscUpgrades.UseVisualStyleBackColor = true;
            this.showEscUpgrades.Click += new System.EventHandler(this.showEscUpgrades_Click);
            // 
            // excavatorUpgrades
            // 
            this.excavatorUpgrades.Controls.Add(this.diamondEscUpgrade);
            this.excavatorUpgrades.Controls.Add(this.titaniumEscUpgrade);
            this.excavatorUpgrades.Controls.Add(this.goldEscUpgrade);
            this.excavatorUpgrades.Controls.Add(this.ironEscUpgrade);
            this.excavatorUpgrades.Location = new System.Drawing.Point(720, 487);
            this.excavatorUpgrades.Margin = new System.Windows.Forms.Padding(0);
            this.excavatorUpgrades.Name = "excavatorUpgrades";
            this.excavatorUpgrades.Size = new System.Drawing.Size(130, 179);
            this.excavatorUpgrades.TabIndex = 39;
            this.excavatorUpgrades.Visible = false;
            // 
            // diamondEscUpgrade
            // 
            this.diamondEscUpgrade.Location = new System.Drawing.Point(0, 134);
            this.diamondEscUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.diamondEscUpgrade.Name = "diamondEscUpgrade";
            this.diamondEscUpgrade.Size = new System.Drawing.Size(130, 45);
            this.diamondEscUpgrade.TabIndex = 3;
            this.diamondEscUpgrade.Text = "diamond esc upgrade";
            this.diamondEscUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.diamondEscUpgrade.UseVisualStyleBackColor = true;
            this.diamondEscUpgrade.Click += new System.EventHandler(this.diamondEscUpgrade_Click);
            // 
            // titaniumEscUpgrade
            // 
            this.titaniumEscUpgrade.Location = new System.Drawing.Point(0, 90);
            this.titaniumEscUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.titaniumEscUpgrade.Name = "titaniumEscUpgrade";
            this.titaniumEscUpgrade.Size = new System.Drawing.Size(130, 45);
            this.titaniumEscUpgrade.TabIndex = 2;
            this.titaniumEscUpgrade.Text = "titanium esc upgrade";
            this.titaniumEscUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titaniumEscUpgrade.UseVisualStyleBackColor = true;
            this.titaniumEscUpgrade.Click += new System.EventHandler(this.titaniumEscUpgrade_Click);
            // 
            // goldEscUpgrade
            // 
            this.goldEscUpgrade.Location = new System.Drawing.Point(0, 45);
            this.goldEscUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.goldEscUpgrade.Name = "goldEscUpgrade";
            this.goldEscUpgrade.Size = new System.Drawing.Size(130, 45);
            this.goldEscUpgrade.TabIndex = 1;
            this.goldEscUpgrade.Text = "gold esc upgrade";
            this.goldEscUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.goldEscUpgrade.UseVisualStyleBackColor = true;
            this.goldEscUpgrade.Click += new System.EventHandler(this.goldEscUpgrade_Click);
            // 
            // ironEscUpgrade
            // 
            this.ironEscUpgrade.Location = new System.Drawing.Point(0, 0);
            this.ironEscUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.ironEscUpgrade.Name = "ironEscUpgrade";
            this.ironEscUpgrade.Size = new System.Drawing.Size(130, 45);
            this.ironEscUpgrade.TabIndex = 0;
            this.ironEscUpgrade.Text = "Iron esc upgrade";
            this.ironEscUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ironEscUpgrade.UseVisualStyleBackColor = true;
            this.ironEscUpgrade.Click += new System.EventHandler(this.ironEscUpgrade_Click);
            // 
            // gameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(856, 678);
            this.Controls.Add(this.excavatorUpgrades);
            this.Controls.Add(this.showEscUpgrades);
            this.Controls.Add(this.drillUpgrades);
            this.Controls.Add(this.showDrillUpgrades);
            this.Controls.Add(this.minerUpgrades);
            this.Controls.Add(this.showMinerUpgrades);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.saveGameButton);
            this.Controls.Add(this.goldTextBox);
            this.Controls.Add(this.diamondTextBox);
            this.Controls.Add(this.ironTextBox);
            this.Controls.Add(this.diamondPerSecondUpgrade3);
            this.Controls.Add(this.diamondPerSecondUpgrade2);
            this.Controls.Add(this.diamondPerSecondUpgrade1);
            this.Controls.Add(this.diamondPerClickUpgrade);
            this.Controls.Add(this.titaniumPerSecondUpgrade3);
            this.Controls.Add(this.titaniumPerSecondUpgrade2);
            this.Controls.Add(this.titaniumPerSecondUpgrade1);
            this.Controls.Add(this.titaniumPerClickUpgrade);
            this.Controls.Add(this.goldPerSecondUpgrade3);
            this.Controls.Add(this.goldPerSecondUpgrade2);
            this.Controls.Add(this.goldPerSecondUpgrade1);
            this.Controls.Add(this.goldPerClickUpgrade);
            this.Controls.Add(this.ironPerSecondUpgrade3);
            this.Controls.Add(this.ironPerSecondUpgrade2);
            this.Controls.Add(this.ironPerSecondUpgrade1);
            this.Controls.Add(this.ironPerClickUpgrade);
            this.Controls.Add(this.titaniumTextBox);
            this.Controls.Add(this.rocketProgressBar);
            this.Controls.Add(this.goldToRocket);
            this.Controls.Add(this.ironToRocket);
            this.Controls.Add(this.diamondToRocket);
            this.Controls.Add(this.titaniumToRocket);
            this.Controls.Add(this.resourceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "gameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resource Collector";
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.minerUpgrades.ResumeLayout(false);
            this.drillUpgrades.ResumeLayout(false);
            this.excavatorUpgrades.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resourceButton;
        private System.Windows.Forms.Button titaniumToRocket;
        private System.Windows.Forms.Button diamondToRocket;
        private System.Windows.Forms.Button ironToRocket;
        private System.Windows.Forms.Button goldToRocket;
        private System.Windows.Forms.ProgressBar rocketProgressBar;
        private System.Windows.Forms.TextBox titaniumTextBox;
        private System.Windows.Forms.Button ironPerClickUpgrade;
        private System.Windows.Forms.Button ironPerSecondUpgrade1;
        private System.Windows.Forms.Button ironPerSecondUpgrade2;
        private System.Windows.Forms.Button ironPerSecondUpgrade3;
        private System.Windows.Forms.Button goldPerSecondUpgrade3;
        private System.Windows.Forms.Button goldPerSecondUpgrade2;
        private System.Windows.Forms.Button goldPerSecondUpgrade1;
        private System.Windows.Forms.Button goldPerClickUpgrade;
        private System.Windows.Forms.Button titaniumPerSecondUpgrade3;
        private System.Windows.Forms.Button titaniumPerSecondUpgrade2;
        private System.Windows.Forms.Button titaniumPerSecondUpgrade1;
        private System.Windows.Forms.Button titaniumPerClickUpgrade;
        private System.Windows.Forms.Button diamondPerSecondUpgrade3;
        private System.Windows.Forms.Button diamondPerSecondUpgrade2;
        private System.Windows.Forms.Button diamondPerSecondUpgrade1;
        private System.Windows.Forms.Button diamondPerClickUpgrade;
        private System.Windows.Forms.TextBox ironTextBox;
        private System.Windows.Forms.TextBox goldTextBox;
        private System.Windows.Forms.TextBox diamondTextBox;
        private System.Windows.Forms.Timer textUpdater;
        private System.Windows.Forms.Timer perSecondResource;
        private System.Windows.Forms.Button saveGameButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button showMinerUpgrades;
        private System.Windows.Forms.Panel minerUpgrades;
        private System.Windows.Forms.Button diamondMinerUpgrade;
        private System.Windows.Forms.Button titaniumMinerUpgrade;
        private System.Windows.Forms.Button goldMinerUpgrade;
        private System.Windows.Forms.Button ironMinerUpgrade;
        private System.Windows.Forms.Button showDrillUpgrades;
        private System.Windows.Forms.Panel drillUpgrades;
        private System.Windows.Forms.Button diamondDrillUpgrade;
        private System.Windows.Forms.Button titaniumDrillUpgrade;
        private System.Windows.Forms.Button goldDrillUpgrade;
        private System.Windows.Forms.Button ironDrillUpgrade;
        private System.Windows.Forms.Button showEscUpgrades;
        private System.Windows.Forms.Panel excavatorUpgrades;
        private System.Windows.Forms.Button diamondEscUpgrade;
        private System.Windows.Forms.Button titaniumEscUpgrade;
        private System.Windows.Forms.Button goldEscUpgrade;
        private System.Windows.Forms.Button ironEscUpgrade;
    }
}

