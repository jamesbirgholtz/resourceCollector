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
            this.resource3ToRocket = new System.Windows.Forms.Button();
            this.resource4ToRocket = new System.Windows.Forms.Button();
            this.resource1ToRocket = new System.Windows.Forms.Button();
            this.resource2ToRocket = new System.Windows.Forms.Button();
            this.rocketProgressBar = new System.Windows.Forms.ProgressBar();
            this.resource3TextBox = new System.Windows.Forms.TextBox();
            this.resource1PerClickUpgrade = new System.Windows.Forms.Button();
            this.resource1PerSecondUpgrade1 = new System.Windows.Forms.Button();
            this.resource1PerSecondUpgrade2 = new System.Windows.Forms.Button();
            this.resource1PerSecondUpgrade3 = new System.Windows.Forms.Button();
            this.resource2PerSecondUpgrade3 = new System.Windows.Forms.Button();
            this.resource2PerSecondUpgrade2 = new System.Windows.Forms.Button();
            this.resource2PerSecondUpgrade1 = new System.Windows.Forms.Button();
            this.resource2PerClickUpgrade = new System.Windows.Forms.Button();
            this.resource3PerSecondUpgrade3 = new System.Windows.Forms.Button();
            this.resource3PerSecondUpgrade2 = new System.Windows.Forms.Button();
            this.resource3PerSecondUpgrade1 = new System.Windows.Forms.Button();
            this.resource3PerClickUpgrade = new System.Windows.Forms.Button();
            this.resource4PerSecondUpgrade3 = new System.Windows.Forms.Button();
            this.resource4PerSecondUpgrade2 = new System.Windows.Forms.Button();
            this.resource4PerSecondUpgrade1 = new System.Windows.Forms.Button();
            this.resource4PerClickUpgrade = new System.Windows.Forms.Button();
            this.resource1TextBox = new System.Windows.Forms.TextBox();
            this.resource2TextBox = new System.Windows.Forms.TextBox();
            this.resource4TextBox = new System.Windows.Forms.TextBox();
            this.textUpdater = new System.Windows.Forms.Timer(this.components);
            this.perSecondResource = new System.Windows.Forms.Timer(this.components);
            this.saveGameButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showMinerUpgrades = new System.Windows.Forms.Button();
            this.minerUpgrades = new System.Windows.Forms.Panel();
            this.resource4MinerUpgrade = new System.Windows.Forms.Button();
            this.resource3MinerUpgrade = new System.Windows.Forms.Button();
            this.resource2MinerUpgrade = new System.Windows.Forms.Button();
            this.resource1MinerUpgrade = new System.Windows.Forms.Button();
            this.showDrillUpgrades = new System.Windows.Forms.Button();
            this.drillUpgrades = new System.Windows.Forms.Panel();
            this.resource4DrillUpgrade = new System.Windows.Forms.Button();
            this.resource3DrillUpgrade = new System.Windows.Forms.Button();
            this.resource2DrillUpgrade = new System.Windows.Forms.Button();
            this.resource1DrillUpgrade = new System.Windows.Forms.Button();
            this.showEscUpgrades = new System.Windows.Forms.Button();
            this.excavatorUpgrades = new System.Windows.Forms.Panel();
            this.resource4EscUpgrade = new System.Windows.Forms.Button();
            this.resource3EscUpgrade = new System.Windows.Forms.Button();
            this.resource2EscUpgrade = new System.Windows.Forms.Button();
            this.resource1EscUpgrade = new System.Windows.Forms.Button();
            this.launchButton = new System.Windows.Forms.Button();
            this.loadGameButton = new System.Windows.Forms.Button();
            this.tokenUpgrades = new System.Windows.Forms.Button();
            this.tokenUpgradesMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.minerUpgrades.SuspendLayout();
            this.drillUpgrades.SuspendLayout();
            this.excavatorUpgrades.SuspendLayout();
            this.SuspendLayout();
            // 
            // resourceButton
            // 
            this.resourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resourceButton.Location = new System.Drawing.Point(20, 153);
            this.resourceButton.Name = "resourceButton";
            this.resourceButton.Size = new System.Drawing.Size(286, 276);
            this.resourceButton.TabIndex = 1;
            this.resourceButton.Text = "resource button";
            this.resourceButton.UseVisualStyleBackColor = true;
            this.resourceButton.Click += new System.EventHandler(this.resourceButton_Click);
            // 
            // resource3ToRocket
            // 
            this.resource3ToRocket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource3ToRocket.Location = new System.Drawing.Point(20, 569);
            this.resource3ToRocket.Name = "resource3ToRocket";
            this.resource3ToRocket.Size = new System.Drawing.Size(140, 71);
            this.resource3ToRocket.TabIndex = 2;
            this.resource3ToRocket.Text = "tit to rocket";
            this.resource3ToRocket.UseVisualStyleBackColor = true;
            this.resource3ToRocket.Click += new System.EventHandler(this.titaniumToRocket_Click);
            // 
            // resource4ToRocket
            // 
            this.resource4ToRocket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource4ToRocket.Location = new System.Drawing.Point(166, 569);
            this.resource4ToRocket.Name = "resource4ToRocket";
            this.resource4ToRocket.Size = new System.Drawing.Size(140, 71);
            this.resource4ToRocket.TabIndex = 3;
            this.resource4ToRocket.Text = "diam to rocket";
            this.resource4ToRocket.UseVisualStyleBackColor = true;
            this.resource4ToRocket.Click += new System.EventHandler(this.diamondToRocket_Click);
            // 
            // resource1ToRocket
            // 
            this.resource1ToRocket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource1ToRocket.Location = new System.Drawing.Point(20, 492);
            this.resource1ToRocket.Name = "resource1ToRocket";
            this.resource1ToRocket.Size = new System.Drawing.Size(140, 71);
            this.resource1ToRocket.TabIndex = 4;
            this.resource1ToRocket.Text = "resource1 to rocket";
            this.resource1ToRocket.UseVisualStyleBackColor = true;
            this.resource1ToRocket.Click += new System.EventHandler(this.ironToRocket_Click);
            // 
            // resource2ToRocket
            // 
            this.resource2ToRocket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource2ToRocket.Location = new System.Drawing.Point(166, 492);
            this.resource2ToRocket.Name = "resource2ToRocket";
            this.resource2ToRocket.Size = new System.Drawing.Size(140, 71);
            this.resource2ToRocket.TabIndex = 5;
            this.resource2ToRocket.Text = "resource2 to rocket";
            this.resource2ToRocket.UseVisualStyleBackColor = true;
            this.resource2ToRocket.Click += new System.EventHandler(this.goldToRocket_Click);
            // 
            // rocketProgressBar
            // 
            this.rocketProgressBar.Location = new System.Drawing.Point(20, 642);
            this.rocketProgressBar.Name = "rocketProgressBar";
            this.rocketProgressBar.Size = new System.Drawing.Size(286, 23);
            this.rocketProgressBar.Step = 1;
            this.rocketProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.rocketProgressBar.TabIndex = 6;
            this.rocketProgressBar.Click += new System.EventHandler(this.rocketProgressBar_Click);
            // 
            // resource3TextBox
            // 
            this.resource3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resource3TextBox.Location = new System.Drawing.Point(20, 82);
            this.resource3TextBox.Multiline = true;
            this.resource3TextBox.Name = "resource3TextBox";
            this.resource3TextBox.ReadOnly = true;
            this.resource3TextBox.Size = new System.Drawing.Size(140, 65);
            this.resource3TextBox.TabIndex = 10;
            this.resource3TextBox.TabStop = false;
            this.resource3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resource1PerClickUpgrade
            // 
            this.resource1PerClickUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource1PerClickUpgrade.Location = new System.Drawing.Point(312, 12);
            this.resource1PerClickUpgrade.Name = "resource1PerClickUpgrade";
            this.resource1PerClickUpgrade.Size = new System.Drawing.Size(130, 100);
            this.resource1PerClickUpgrade.TabIndex = 12;
            this.resource1PerClickUpgrade.UseVisualStyleBackColor = true;
            this.resource1PerClickUpgrade.Click += new System.EventHandler(this.ironPerClickUpgrade_Click);
            // 
            // resource1PerSecondUpgrade1
            // 
            this.resource1PerSecondUpgrade1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource1PerSecondUpgrade1.Location = new System.Drawing.Point(448, 12);
            this.resource1PerSecondUpgrade1.Name = "resource1PerSecondUpgrade1";
            this.resource1PerSecondUpgrade1.Size = new System.Drawing.Size(130, 100);
            this.resource1PerSecondUpgrade1.TabIndex = 13;
            this.resource1PerSecondUpgrade1.Text = "resource1 per sec up1";
            this.resource1PerSecondUpgrade1.UseVisualStyleBackColor = true;
            this.resource1PerSecondUpgrade1.Click += new System.EventHandler(this.ironPerSecondUpgrade1_Click);
            // 
            // resource1PerSecondUpgrade2
            // 
            this.resource1PerSecondUpgrade2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource1PerSecondUpgrade2.Location = new System.Drawing.Point(584, 12);
            this.resource1PerSecondUpgrade2.Name = "resource1PerSecondUpgrade2";
            this.resource1PerSecondUpgrade2.Size = new System.Drawing.Size(130, 100);
            this.resource1PerSecondUpgrade2.TabIndex = 14;
            this.resource1PerSecondUpgrade2.Text = "resource1 per sec up2";
            this.resource1PerSecondUpgrade2.UseVisualStyleBackColor = true;
            this.resource1PerSecondUpgrade2.Click += new System.EventHandler(this.ironPerSecondUpgrade2_Click);
            // 
            // resource1PerSecondUpgrade3
            // 
            this.resource1PerSecondUpgrade3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource1PerSecondUpgrade3.Location = new System.Drawing.Point(720, 12);
            this.resource1PerSecondUpgrade3.Name = "resource1PerSecondUpgrade3";
            this.resource1PerSecondUpgrade3.Size = new System.Drawing.Size(130, 100);
            this.resource1PerSecondUpgrade3.TabIndex = 15;
            this.resource1PerSecondUpgrade3.Text = "resource1 per sec up2";
            this.resource1PerSecondUpgrade3.UseVisualStyleBackColor = true;
            this.resource1PerSecondUpgrade3.Click += new System.EventHandler(this.ironPerSecondUpgrade3_Click);
            // 
            // resource2PerSecondUpgrade3
            // 
            this.resource2PerSecondUpgrade3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource2PerSecondUpgrade3.Location = new System.Drawing.Point(720, 118);
            this.resource2PerSecondUpgrade3.Name = "resource2PerSecondUpgrade3";
            this.resource2PerSecondUpgrade3.Size = new System.Drawing.Size(130, 100);
            this.resource2PerSecondUpgrade3.TabIndex = 19;
            this.resource2PerSecondUpgrade3.Text = "resource2 per sec up3";
            this.resource2PerSecondUpgrade3.UseVisualStyleBackColor = true;
            this.resource2PerSecondUpgrade3.Click += new System.EventHandler(this.goldPerSecondUpgrade3_Click);
            // 
            // resource2PerSecondUpgrade2
            // 
            this.resource2PerSecondUpgrade2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource2PerSecondUpgrade2.Location = new System.Drawing.Point(584, 118);
            this.resource2PerSecondUpgrade2.Name = "resource2PerSecondUpgrade2";
            this.resource2PerSecondUpgrade2.Size = new System.Drawing.Size(130, 100);
            this.resource2PerSecondUpgrade2.TabIndex = 18;
            this.resource2PerSecondUpgrade2.Text = "resource2 per sec up2";
            this.resource2PerSecondUpgrade2.UseVisualStyleBackColor = true;
            this.resource2PerSecondUpgrade2.Click += new System.EventHandler(this.goldPerSecondUpgrade2_Click);
            // 
            // resource2PerSecondUpgrade1
            // 
            this.resource2PerSecondUpgrade1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource2PerSecondUpgrade1.Location = new System.Drawing.Point(448, 118);
            this.resource2PerSecondUpgrade1.Name = "resource2PerSecondUpgrade1";
            this.resource2PerSecondUpgrade1.Size = new System.Drawing.Size(130, 100);
            this.resource2PerSecondUpgrade1.TabIndex = 17;
            this.resource2PerSecondUpgrade1.Text = "resource2 per sec up1";
            this.resource2PerSecondUpgrade1.UseVisualStyleBackColor = true;
            this.resource2PerSecondUpgrade1.Click += new System.EventHandler(this.goldPerSecondUpgrade1_Click);
            // 
            // resource2PerClickUpgrade
            // 
            this.resource2PerClickUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource2PerClickUpgrade.Location = new System.Drawing.Point(312, 118);
            this.resource2PerClickUpgrade.Name = "resource2PerClickUpgrade";
            this.resource2PerClickUpgrade.Size = new System.Drawing.Size(130, 100);
            this.resource2PerClickUpgrade.TabIndex = 16;
            this.resource2PerClickUpgrade.Text = "goldperclickupgrade";
            this.resource2PerClickUpgrade.UseVisualStyleBackColor = true;
            this.resource2PerClickUpgrade.Click += new System.EventHandler(this.goldPerClickUpgrade_Click);
            // 
            // resource3PerSecondUpgrade3
            // 
            this.resource3PerSecondUpgrade3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource3PerSecondUpgrade3.Location = new System.Drawing.Point(720, 224);
            this.resource3PerSecondUpgrade3.Name = "resource3PerSecondUpgrade3";
            this.resource3PerSecondUpgrade3.Size = new System.Drawing.Size(130, 100);
            this.resource3PerSecondUpgrade3.TabIndex = 23;
            this.resource3PerSecondUpgrade3.Text = "tit per sec up3";
            this.resource3PerSecondUpgrade3.UseVisualStyleBackColor = true;
            this.resource3PerSecondUpgrade3.Click += new System.EventHandler(this.titaniumPerSecondUpgrade3_Click);
            // 
            // resource3PerSecondUpgrade2
            // 
            this.resource3PerSecondUpgrade2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource3PerSecondUpgrade2.Location = new System.Drawing.Point(584, 224);
            this.resource3PerSecondUpgrade2.Name = "resource3PerSecondUpgrade2";
            this.resource3PerSecondUpgrade2.Size = new System.Drawing.Size(130, 100);
            this.resource3PerSecondUpgrade2.TabIndex = 22;
            this.resource3PerSecondUpgrade2.Text = "tit per sec up2";
            this.resource3PerSecondUpgrade2.UseVisualStyleBackColor = true;
            this.resource3PerSecondUpgrade2.Click += new System.EventHandler(this.titaniumPerSecondUpgrade2_Click);
            // 
            // resource3PerSecondUpgrade1
            // 
            this.resource3PerSecondUpgrade1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource3PerSecondUpgrade1.Location = new System.Drawing.Point(448, 224);
            this.resource3PerSecondUpgrade1.Name = "resource3PerSecondUpgrade1";
            this.resource3PerSecondUpgrade1.Size = new System.Drawing.Size(130, 100);
            this.resource3PerSecondUpgrade1.TabIndex = 21;
            this.resource3PerSecondUpgrade1.Text = "tit per sec up1";
            this.resource3PerSecondUpgrade1.UseVisualStyleBackColor = true;
            this.resource3PerSecondUpgrade1.Click += new System.EventHandler(this.titaniumPerSecondUpgrade1_Click);
            // 
            // resource3PerClickUpgrade
            // 
            this.resource3PerClickUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource3PerClickUpgrade.Location = new System.Drawing.Point(312, 224);
            this.resource3PerClickUpgrade.Name = "resource3PerClickUpgrade";
            this.resource3PerClickUpgrade.Size = new System.Drawing.Size(130, 100);
            this.resource3PerClickUpgrade.TabIndex = 20;
            this.resource3PerClickUpgrade.Text = "titperclickupgrade";
            this.resource3PerClickUpgrade.UseVisualStyleBackColor = true;
            this.resource3PerClickUpgrade.Click += new System.EventHandler(this.titaniumPerClickUpgrade_Click);
            // 
            // resource4PerSecondUpgrade3
            // 
            this.resource4PerSecondUpgrade3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource4PerSecondUpgrade3.Location = new System.Drawing.Point(720, 330);
            this.resource4PerSecondUpgrade3.Name = "resource4PerSecondUpgrade3";
            this.resource4PerSecondUpgrade3.Size = new System.Drawing.Size(130, 100);
            this.resource4PerSecondUpgrade3.TabIndex = 27;
            this.resource4PerSecondUpgrade3.Text = "diam per sec up3";
            this.resource4PerSecondUpgrade3.UseVisualStyleBackColor = true;
            this.resource4PerSecondUpgrade3.Click += new System.EventHandler(this.diamondPerSecondUpgrade3_Click);
            // 
            // resource4PerSecondUpgrade2
            // 
            this.resource4PerSecondUpgrade2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource4PerSecondUpgrade2.Location = new System.Drawing.Point(584, 330);
            this.resource4PerSecondUpgrade2.Name = "resource4PerSecondUpgrade2";
            this.resource4PerSecondUpgrade2.Size = new System.Drawing.Size(130, 100);
            this.resource4PerSecondUpgrade2.TabIndex = 26;
            this.resource4PerSecondUpgrade2.Text = "diam per sec up2";
            this.resource4PerSecondUpgrade2.UseVisualStyleBackColor = true;
            this.resource4PerSecondUpgrade2.Click += new System.EventHandler(this.diamondPerSecondUpgrade2_Click);
            // 
            // resource4PerSecondUpgrade1
            // 
            this.resource4PerSecondUpgrade1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource4PerSecondUpgrade1.Location = new System.Drawing.Point(448, 330);
            this.resource4PerSecondUpgrade1.Name = "resource4PerSecondUpgrade1";
            this.resource4PerSecondUpgrade1.Size = new System.Drawing.Size(130, 100);
            this.resource4PerSecondUpgrade1.TabIndex = 25;
            this.resource4PerSecondUpgrade1.Text = "diam per sec up1";
            this.resource4PerSecondUpgrade1.UseVisualStyleBackColor = true;
            this.resource4PerSecondUpgrade1.Click += new System.EventHandler(this.diamondPerSecondUpgrade1_Click);
            // 
            // resource4PerClickUpgrade
            // 
            this.resource4PerClickUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource4PerClickUpgrade.Location = new System.Drawing.Point(312, 330);
            this.resource4PerClickUpgrade.Name = "resource4PerClickUpgrade";
            this.resource4PerClickUpgrade.Size = new System.Drawing.Size(130, 100);
            this.resource4PerClickUpgrade.TabIndex = 24;
            this.resource4PerClickUpgrade.Text = "diamperclickupgrade";
            this.resource4PerClickUpgrade.UseVisualStyleBackColor = true;
            this.resource4PerClickUpgrade.Click += new System.EventHandler(this.diamondPerClickUpgrade_Click);
            // 
            // resource1TextBox
            // 
            this.resource1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resource1TextBox.Location = new System.Drawing.Point(20, 11);
            this.resource1TextBox.Multiline = true;
            this.resource1TextBox.Name = "resource1TextBox";
            this.resource1TextBox.ReadOnly = true;
            this.resource1TextBox.Size = new System.Drawing.Size(140, 65);
            this.resource1TextBox.TabIndex = 28;
            this.resource1TextBox.TabStop = false;
            this.resource1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resource1TextBox.TextChanged += new System.EventHandler(this.ironTextBox_TextChanged);
            // 
            // resource2TextBox
            // 
            this.resource2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resource2TextBox.Location = new System.Drawing.Point(166, 11);
            this.resource2TextBox.Multiline = true;
            this.resource2TextBox.Name = "resource2TextBox";
            this.resource2TextBox.ReadOnly = true;
            this.resource2TextBox.Size = new System.Drawing.Size(140, 65);
            this.resource2TextBox.TabIndex = 30;
            this.resource2TextBox.TabStop = false;
            this.resource2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resource4TextBox
            // 
            this.resource4TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resource4TextBox.Location = new System.Drawing.Point(166, 82);
            this.resource4TextBox.Multiline = true;
            this.resource4TextBox.Name = "resource4TextBox";
            this.resource4TextBox.ReadOnly = true;
            this.resource4TextBox.Size = new System.Drawing.Size(140, 65);
            this.resource4TextBox.TabIndex = 29;
            this.resource4TextBox.TabStop = false;
            this.resource4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.saveGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveGameButton.Location = new System.Drawing.Point(20, 436);
            this.saveGameButton.Name = "saveGameButton";
            this.saveGameButton.Size = new System.Drawing.Size(70, 35);
            this.saveGameButton.TabIndex = 31;
            this.saveGameButton.Text = "saveButton";
            this.saveGameButton.UseVisualStyleBackColor = true;
            this.saveGameButton.Click += new System.EventHandler(this.saveGameButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(20, 473);
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
            this.showMinerUpgrades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.minerUpgrades.Controls.Add(this.resource4MinerUpgrade);
            this.minerUpgrades.Controls.Add(this.resource3MinerUpgrade);
            this.minerUpgrades.Controls.Add(this.resource2MinerUpgrade);
            this.minerUpgrades.Controls.Add(this.resource1MinerUpgrade);
            this.minerUpgrades.Location = new System.Drawing.Point(448, 487);
            this.minerUpgrades.Margin = new System.Windows.Forms.Padding(0);
            this.minerUpgrades.Name = "minerUpgrades";
            this.minerUpgrades.Size = new System.Drawing.Size(130, 179);
            this.minerUpgrades.TabIndex = 35;
            this.minerUpgrades.Visible = false;
            // 
            // resource4MinerUpgrade
            // 
            this.resource4MinerUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource4MinerUpgrade.Location = new System.Drawing.Point(0, 134);
            this.resource4MinerUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.resource4MinerUpgrade.Name = "resource4MinerUpgrade";
            this.resource4MinerUpgrade.Size = new System.Drawing.Size(130, 45);
            this.resource4MinerUpgrade.TabIndex = 3;
            this.resource4MinerUpgrade.Text = "Diamond Miner Upgrade";
            this.resource4MinerUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resource4MinerUpgrade.UseVisualStyleBackColor = true;
            this.resource4MinerUpgrade.Click += new System.EventHandler(this.diamondMinerUpgrade_Click);
            // 
            // resource3MinerUpgrade
            // 
            this.resource3MinerUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource3MinerUpgrade.Location = new System.Drawing.Point(0, 90);
            this.resource3MinerUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.resource3MinerUpgrade.Name = "resource3MinerUpgrade";
            this.resource3MinerUpgrade.Size = new System.Drawing.Size(130, 45);
            this.resource3MinerUpgrade.TabIndex = 2;
            this.resource3MinerUpgrade.Text = "Titanium miner upgrade";
            this.resource3MinerUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resource3MinerUpgrade.UseVisualStyleBackColor = true;
            this.resource3MinerUpgrade.Click += new System.EventHandler(this.titaniumMinerUpgrade_Click);
            // 
            // resource2MinerUpgrade
            // 
            this.resource2MinerUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource2MinerUpgrade.Location = new System.Drawing.Point(0, 45);
            this.resource2MinerUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.resource2MinerUpgrade.Name = "resource2MinerUpgrade";
            this.resource2MinerUpgrade.Size = new System.Drawing.Size(130, 45);
            this.resource2MinerUpgrade.TabIndex = 1;
            this.resource2MinerUpgrade.Text = "Gold miner upgrade";
            this.resource2MinerUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resource2MinerUpgrade.UseVisualStyleBackColor = true;
            this.resource2MinerUpgrade.Click += new System.EventHandler(this.goldMinerUpgrade_Click);
            // 
            // resource1MinerUpgrade
            // 
            this.resource1MinerUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource1MinerUpgrade.Location = new System.Drawing.Point(0, 0);
            this.resource1MinerUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.resource1MinerUpgrade.Name = "resource1MinerUpgrade";
            this.resource1MinerUpgrade.Size = new System.Drawing.Size(130, 45);
            this.resource1MinerUpgrade.TabIndex = 0;
            this.resource1MinerUpgrade.Text = "Iron miner upgrade";
            this.resource1MinerUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resource1MinerUpgrade.UseVisualStyleBackColor = true;
            this.resource1MinerUpgrade.Click += new System.EventHandler(this.ironMinerUpgrade_Click);
            // 
            // showDrillUpgrades
            // 
            this.showDrillUpgrades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.drillUpgrades.Controls.Add(this.resource4DrillUpgrade);
            this.drillUpgrades.Controls.Add(this.resource3DrillUpgrade);
            this.drillUpgrades.Controls.Add(this.resource2DrillUpgrade);
            this.drillUpgrades.Controls.Add(this.resource1DrillUpgrade);
            this.drillUpgrades.Location = new System.Drawing.Point(584, 487);
            this.drillUpgrades.Margin = new System.Windows.Forms.Padding(0);
            this.drillUpgrades.Name = "drillUpgrades";
            this.drillUpgrades.Size = new System.Drawing.Size(130, 179);
            this.drillUpgrades.TabIndex = 37;
            this.drillUpgrades.Visible = false;
            // 
            // resource4DrillUpgrade
            // 
            this.resource4DrillUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource4DrillUpgrade.Location = new System.Drawing.Point(0, 134);
            this.resource4DrillUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.resource4DrillUpgrade.Name = "resource4DrillUpgrade";
            this.resource4DrillUpgrade.Size = new System.Drawing.Size(130, 45);
            this.resource4DrillUpgrade.TabIndex = 3;
            this.resource4DrillUpgrade.Text = "resource4 drill upgrade";
            this.resource4DrillUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resource4DrillUpgrade.UseVisualStyleBackColor = true;
            this.resource4DrillUpgrade.Click += new System.EventHandler(this.diamondDrillUpgrade_Click);
            // 
            // resource3DrillUpgrade
            // 
            this.resource3DrillUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource3DrillUpgrade.Location = new System.Drawing.Point(0, 90);
            this.resource3DrillUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.resource3DrillUpgrade.Name = "resource3DrillUpgrade";
            this.resource3DrillUpgrade.Size = new System.Drawing.Size(130, 45);
            this.resource3DrillUpgrade.TabIndex = 2;
            this.resource3DrillUpgrade.Text = "Titanium Drill upgrade";
            this.resource3DrillUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resource3DrillUpgrade.UseVisualStyleBackColor = true;
            this.resource3DrillUpgrade.Click += new System.EventHandler(this.titaniumDrillUpgrade_Click);
            // 
            // resource2DrillUpgrade
            // 
            this.resource2DrillUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource2DrillUpgrade.Location = new System.Drawing.Point(0, 45);
            this.resource2DrillUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.resource2DrillUpgrade.Name = "resource2DrillUpgrade";
            this.resource2DrillUpgrade.Size = new System.Drawing.Size(130, 45);
            this.resource2DrillUpgrade.TabIndex = 1;
            this.resource2DrillUpgrade.Text = "Gold drill upgrade";
            this.resource2DrillUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resource2DrillUpgrade.UseVisualStyleBackColor = true;
            this.resource2DrillUpgrade.Click += new System.EventHandler(this.goldDrillUpgrade_Click);
            // 
            // resource1DrillUpgrade
            // 
            this.resource1DrillUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource1DrillUpgrade.Location = new System.Drawing.Point(0, 0);
            this.resource1DrillUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.resource1DrillUpgrade.Name = "resource1DrillUpgrade";
            this.resource1DrillUpgrade.Size = new System.Drawing.Size(130, 45);
            this.resource1DrillUpgrade.TabIndex = 0;
            this.resource1DrillUpgrade.Text = "Iron drill upgrade";
            this.resource1DrillUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resource1DrillUpgrade.UseVisualStyleBackColor = true;
            this.resource1DrillUpgrade.Click += new System.EventHandler(this.ironDrillUpgrade_Click);
            // 
            // showEscUpgrades
            // 
            this.showEscUpgrades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.excavatorUpgrades.Controls.Add(this.resource4EscUpgrade);
            this.excavatorUpgrades.Controls.Add(this.resource3EscUpgrade);
            this.excavatorUpgrades.Controls.Add(this.resource2EscUpgrade);
            this.excavatorUpgrades.Controls.Add(this.resource1EscUpgrade);
            this.excavatorUpgrades.Location = new System.Drawing.Point(720, 487);
            this.excavatorUpgrades.Margin = new System.Windows.Forms.Padding(0);
            this.excavatorUpgrades.Name = "excavatorUpgrades";
            this.excavatorUpgrades.Size = new System.Drawing.Size(130, 179);
            this.excavatorUpgrades.TabIndex = 39;
            this.excavatorUpgrades.Visible = false;
            // 
            // resource4EscUpgrade
            // 
            this.resource4EscUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource4EscUpgrade.Location = new System.Drawing.Point(0, 134);
            this.resource4EscUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.resource4EscUpgrade.Name = "resource4EscUpgrade";
            this.resource4EscUpgrade.Size = new System.Drawing.Size(130, 45);
            this.resource4EscUpgrade.TabIndex = 3;
            this.resource4EscUpgrade.Text = "resource4 esc upgrade";
            this.resource4EscUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resource4EscUpgrade.UseVisualStyleBackColor = true;
            this.resource4EscUpgrade.Click += new System.EventHandler(this.diamondEscUpgrade_Click);
            // 
            // resource3EscUpgrade
            // 
            this.resource3EscUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource3EscUpgrade.Location = new System.Drawing.Point(0, 90);
            this.resource3EscUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.resource3EscUpgrade.Name = "resource3EscUpgrade";
            this.resource3EscUpgrade.Size = new System.Drawing.Size(130, 45);
            this.resource3EscUpgrade.TabIndex = 2;
            this.resource3EscUpgrade.Text = "resource3 esc upgrade";
            this.resource3EscUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resource3EscUpgrade.UseVisualStyleBackColor = true;
            this.resource3EscUpgrade.Click += new System.EventHandler(this.titaniumEscUpgrade_Click);
            // 
            // resource2EscUpgrade
            // 
            this.resource2EscUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource2EscUpgrade.Location = new System.Drawing.Point(0, 45);
            this.resource2EscUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.resource2EscUpgrade.Name = "resource2EscUpgrade";
            this.resource2EscUpgrade.Size = new System.Drawing.Size(130, 45);
            this.resource2EscUpgrade.TabIndex = 1;
            this.resource2EscUpgrade.Text = "resource2 esc upgrade";
            this.resource2EscUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resource2EscUpgrade.UseVisualStyleBackColor = true;
            this.resource2EscUpgrade.Click += new System.EventHandler(this.goldEscUpgrade_Click);
            // 
            // resource1EscUpgrade
            // 
            this.resource1EscUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resource1EscUpgrade.Location = new System.Drawing.Point(0, 0);
            this.resource1EscUpgrade.Margin = new System.Windows.Forms.Padding(0);
            this.resource1EscUpgrade.Name = "resource1EscUpgrade";
            this.resource1EscUpgrade.Size = new System.Drawing.Size(130, 45);
            this.resource1EscUpgrade.TabIndex = 0;
            this.resource1EscUpgrade.Text = "Iron esc upgrade";
            this.resource1EscUpgrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resource1EscUpgrade.UseVisualStyleBackColor = true;
            this.resource1EscUpgrade.Click += new System.EventHandler(this.ironEscUpgrade_Click);
            // 
            // launchButton
            // 
            this.launchButton.BackColor = System.Drawing.Color.Red;
            this.launchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.launchButton.Location = new System.Drawing.Point(30, 161);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(266, 260);
            this.launchButton.TabIndex = 40;
            this.launchButton.Text = "launchbutton";
            this.launchButton.UseVisualStyleBackColor = false;
            this.launchButton.Visible = false;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // loadGameButton
            // 
            this.loadGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadGameButton.Location = new System.Drawing.Point(90, 436);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(70, 35);
            this.loadGameButton.TabIndex = 41;
            this.loadGameButton.Text = "load button";
            this.loadGameButton.UseVisualStyleBackColor = true;
            // 
            // tokenUpgrades
            // 
            this.tokenUpgrades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tokenUpgrades.Location = new System.Drawing.Point(166, 436);
            this.tokenUpgrades.Name = "tokenUpgrades";
            this.tokenUpgrades.Size = new System.Drawing.Size(140, 35);
            this.tokenUpgrades.TabIndex = 43;
            this.tokenUpgrades.Text = "token upgrades";
            this.tokenUpgrades.UseVisualStyleBackColor = true;
            this.tokenUpgrades.Visible = false;
            this.tokenUpgrades.Click += new System.EventHandler(this.tokenUpgrades_Click);
            // 
            // tokenUpgradesMenu
            // 
            this.tokenUpgradesMenu.Enabled = false;
            this.tokenUpgradesMenu.Location = new System.Drawing.Point(312, 436);
            this.tokenUpgradesMenu.Name = "tokenUpgradesMenu";
            this.tokenUpgradesMenu.Size = new System.Drawing.Size(538, 230);
            this.tokenUpgradesMenu.TabIndex = 44;
            this.tokenUpgradesMenu.Visible = false;
            // 
            // gameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(856, 678);
            this.Controls.Add(this.tokenUpgradesMenu);
            this.Controls.Add(this.tokenUpgrades);
            this.Controls.Add(this.loadGameButton);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.excavatorUpgrades);
            this.Controls.Add(this.showEscUpgrades);
            this.Controls.Add(this.drillUpgrades);
            this.Controls.Add(this.showDrillUpgrades);
            this.Controls.Add(this.minerUpgrades);
            this.Controls.Add(this.showMinerUpgrades);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.saveGameButton);
            this.Controls.Add(this.resource2TextBox);
            this.Controls.Add(this.resource4TextBox);
            this.Controls.Add(this.resource1TextBox);
            this.Controls.Add(this.resource4PerSecondUpgrade3);
            this.Controls.Add(this.resource4PerSecondUpgrade2);
            this.Controls.Add(this.resource4PerSecondUpgrade1);
            this.Controls.Add(this.resource4PerClickUpgrade);
            this.Controls.Add(this.resource3PerSecondUpgrade3);
            this.Controls.Add(this.resource3PerSecondUpgrade2);
            this.Controls.Add(this.resource3PerSecondUpgrade1);
            this.Controls.Add(this.resource3PerClickUpgrade);
            this.Controls.Add(this.resource2PerSecondUpgrade3);
            this.Controls.Add(this.resource2PerSecondUpgrade2);
            this.Controls.Add(this.resource2PerSecondUpgrade1);
            this.Controls.Add(this.resource2PerClickUpgrade);
            this.Controls.Add(this.resource1PerSecondUpgrade3);
            this.Controls.Add(this.resource1PerSecondUpgrade2);
            this.Controls.Add(this.resource1PerSecondUpgrade1);
            this.Controls.Add(this.resource1PerClickUpgrade);
            this.Controls.Add(this.resource3TextBox);
            this.Controls.Add(this.rocketProgressBar);
            this.Controls.Add(this.resource2ToRocket);
            this.Controls.Add(this.resource1ToRocket);
            this.Controls.Add(this.resource4ToRocket);
            this.Controls.Add(this.resource3ToRocket);
            this.Controls.Add(this.resourceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(872, 0);
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
        private System.Windows.Forms.Button resource3ToRocket;
        private System.Windows.Forms.Button resource4ToRocket;
        private System.Windows.Forms.Button resource1ToRocket;
        private System.Windows.Forms.Button resource2ToRocket;
        private System.Windows.Forms.ProgressBar rocketProgressBar;
        private System.Windows.Forms.TextBox resource3TextBox;
        private System.Windows.Forms.Button resource1PerClickUpgrade;
        private System.Windows.Forms.Button resource1PerSecondUpgrade1;
        private System.Windows.Forms.Button resource1PerSecondUpgrade2;
        private System.Windows.Forms.Button resource1PerSecondUpgrade3;
        private System.Windows.Forms.Button resource2PerSecondUpgrade3;
        private System.Windows.Forms.Button resource2PerSecondUpgrade2;
        private System.Windows.Forms.Button resource2PerSecondUpgrade1;
        private System.Windows.Forms.Button resource2PerClickUpgrade;
        private System.Windows.Forms.Button resource3PerSecondUpgrade3;
        private System.Windows.Forms.Button resource3PerSecondUpgrade2;
        private System.Windows.Forms.Button resource3PerSecondUpgrade1;
        private System.Windows.Forms.Button resource3PerClickUpgrade;
        private System.Windows.Forms.Button resource4PerSecondUpgrade3;
        private System.Windows.Forms.Button resource4PerSecondUpgrade2;
        private System.Windows.Forms.Button resource4PerSecondUpgrade1;
        private System.Windows.Forms.Button resource4PerClickUpgrade;
        private System.Windows.Forms.TextBox resource1TextBox;
        private System.Windows.Forms.TextBox resource2TextBox;
        private System.Windows.Forms.TextBox resource4TextBox;
        private System.Windows.Forms.Timer textUpdater;
        private System.Windows.Forms.Timer perSecondResource;
        private System.Windows.Forms.Button saveGameButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button showMinerUpgrades;
        private System.Windows.Forms.Panel minerUpgrades;
        private System.Windows.Forms.Button resource4MinerUpgrade;
        private System.Windows.Forms.Button resource3MinerUpgrade;
        private System.Windows.Forms.Button resource2MinerUpgrade;
        private System.Windows.Forms.Button resource1MinerUpgrade;
        private System.Windows.Forms.Button showDrillUpgrades;
        private System.Windows.Forms.Panel drillUpgrades;
        private System.Windows.Forms.Button resource4DrillUpgrade;
        private System.Windows.Forms.Button resource3DrillUpgrade;
        private System.Windows.Forms.Button resource2DrillUpgrade;
        private System.Windows.Forms.Button resource1DrillUpgrade;
        private System.Windows.Forms.Button showEscUpgrades;
        private System.Windows.Forms.Panel excavatorUpgrades;
        private System.Windows.Forms.Button resource4EscUpgrade;
        private System.Windows.Forms.Button resource3EscUpgrade;
        private System.Windows.Forms.Button resource2EscUpgrade;
        private System.Windows.Forms.Button resource1EscUpgrade;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Button loadGameButton;
        private System.Windows.Forms.Button tokenUpgrades;
        private System.Windows.Forms.FlowLayoutPanel tokenUpgradesMenu;
    }
}

