namespace FootballTeamGenerator
{
    partial class FootballTeamGenerator
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
            this.lsvFootballers = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colShooting = new System.Windows.Forms.ColumnHeader();
            this.colPassing = new System.Windows.Forms.ColumnHeader();
            this.colDefending = new System.Windows.Forms.ColumnHeader();
            this.colTackling = new System.Windows.Forms.ColumnHeader();
            this.colEnergy = new System.Windows.Forms.ColumnHeader();
            this.colBallControl = new System.Windows.Forms.ColumnHeader();
            this.colGoalkeeping = new System.Windows.Forms.ColumnHeader();
            this.colOverall = new System.Windows.Forms.ColumnHeader();
            this.cmdAddFootballer = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numShooting = new System.Windows.Forms.NumericUpDown();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.lsvAvailablePlayers = new System.Windows.Forms.ListView();
            this.colPlayerName = new System.Windows.Forms.ColumnHeader();
            this.colPlayerShooting = new System.Windows.Forms.ColumnHeader();
            this.colPlayerPassing = new System.Windows.Forms.ColumnHeader();
            this.colPlayerDefending = new System.Windows.Forms.ColumnHeader();
            this.colPlayerTackling = new System.Windows.Forms.ColumnHeader();
            this.colPlayerBallControl = new System.Windows.Forms.ColumnHeader();
            this.colPlayerGoalkeeping = new System.Windows.Forms.ColumnHeader();
            this.colPlayerEnergy = new System.Windows.Forms.ColumnHeader();
            this.colPlayerOverall = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numTackling = new System.Windows.Forms.NumericUpDown();
            this.numDefending = new System.Windows.Forms.NumericUpDown();
            this.numPassing = new System.Windows.Forms.NumericUpDown();
            this.numEnergy = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdSortAvailable = new System.Windows.Forms.Button();
            this.cmdSaveList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label99 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.numBallControl = new System.Windows.Forms.NumericUpDown();
            this.numGoalkeeping = new System.Windows.Forms.NumericUpDown();
            this.cmdSwap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numShooting)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTackling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPassing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnergy)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBallControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoalkeeping)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvFootballers
            // 
            this.lsvFootballers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvFootballers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colShooting,
            this.colPassing,
            this.colDefending,
            this.colTackling,
            this.colEnergy,
            this.colBallControl,
            this.colGoalkeeping,
            this.colOverall});
            this.lsvFootballers.FullRowSelect = true;
            this.lsvFootballers.GridLines = true;
            this.lsvFootballers.Location = new System.Drawing.Point(723, 7);
            this.lsvFootballers.Name = "lsvFootballers";
            this.lsvFootballers.Size = new System.Drawing.Size(642, 474);
            this.lsvFootballers.TabIndex = 0;
            this.lsvFootballers.UseCompatibleStateImageBehavior = false;
            this.lsvFootballers.View = System.Windows.Forms.View.Details;
            this.lsvFootballers.SelectedIndexChanged += new System.EventHandler(this.lsvFootballers_SelectedIndexChanged);
            this.lsvFootballers.DoubleClick += new System.EventHandler(this.lsvFootballers_DoubleClick);
            this.lsvFootballers.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lsvFootballers_ColumnClick);
            this.lsvFootballers.Click += new System.EventHandler(this.lsvFootballers_Click);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 123;
            // 
            // colShooting
            // 
            this.colShooting.Text = "Shooting";
            // 
            // colPassing
            // 
            this.colPassing.Text = "Passing";
            // 
            // colDefending
            // 
            this.colDefending.Text = "Defending";
            this.colDefending.Width = 66;
            // 
            // colTackling
            // 
            this.colTackling.Text = "Tackling";
            // 
            // colEnergy
            // 
            this.colEnergy.DisplayIndex = 7;
            this.colEnergy.Text = "Energy";
            // 
            // colBallControl
            // 
            this.colBallControl.DisplayIndex = 5;
            this.colBallControl.Text = "Ball Control";
            this.colBallControl.Width = 70;
            // 
            // colGoalkeeping
            // 
            this.colGoalkeeping.DisplayIndex = 6;
            this.colGoalkeeping.Text = "Goalkeeping";
            this.colGoalkeeping.Width = 79;
            // 
            // colOverall
            // 
            this.colOverall.Text = "Overall";
            this.colOverall.Width = 58;
            // 
            // cmdAddFootballer
            // 
            this.cmdAddFootballer.Location = new System.Drawing.Point(270, 21);
            this.cmdAddFootballer.Name = "cmdAddFootballer";
            this.cmdAddFootballer.Size = new System.Drawing.Size(58, 23);
            this.cmdAddFootballer.TabIndex = 1;
            this.cmdAddFootballer.Text = "Add";
            this.cmdAddFootballer.UseVisualStyleBackColor = true;
            this.cmdAddFootballer.Click += new System.EventHandler(this.cmdAddFootballer_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 20);
            this.txtName.TabIndex = 2;
            // 
            // numShooting
            // 
            this.numShooting.Location = new System.Drawing.Point(20, 72);
            this.numShooting.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numShooting.Name = "numShooting";
            this.numShooting.Size = new System.Drawing.Size(45, 20);
            this.numShooting.TabIndex = 3;
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdGenerate.Location = new System.Drawing.Point(947, 487);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(96, 40);
            this.cmdGenerate.TabIndex = 5;
            this.cmdGenerate.Text = "Generate Teams";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // lsvAvailablePlayers
            // 
            this.lsvAvailablePlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lsvAvailablePlayers.CheckBoxes = true;
            this.lsvAvailablePlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPlayerName,
            this.colPlayerShooting,
            this.colPlayerPassing,
            this.colPlayerDefending,
            this.colPlayerTackling,
            this.colPlayerBallControl,
            this.colPlayerGoalkeeping,
            this.colPlayerEnergy,
            this.colPlayerOverall});
            this.lsvAvailablePlayers.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvAvailablePlayers.FullRowSelect = true;
            this.lsvAvailablePlayers.GridLines = true;
            this.lsvAvailablePlayers.Location = new System.Drawing.Point(10, 12);
            this.lsvAvailablePlayers.Name = "lsvAvailablePlayers";
            this.lsvAvailablePlayers.Size = new System.Drawing.Size(629, 469);
            this.lsvAvailablePlayers.TabIndex = 6;
            this.lsvAvailablePlayers.UseCompatibleStateImageBehavior = false;
            this.lsvAvailablePlayers.View = System.Windows.Forms.View.Details;
            this.lsvAvailablePlayers.SelectedIndexChanged += new System.EventHandler(this.lsvAvailablePlayers_SelectedIndexChanged);
            this.lsvAvailablePlayers.DoubleClick += new System.EventHandler(this.lsvAvailablePlayers_DoubleClick);
            // 
            // colPlayerName
            // 
            this.colPlayerName.Text = "Name";
            this.colPlayerName.Width = 129;
            // 
            // colPlayerShooting
            // 
            this.colPlayerShooting.Text = "Shooting";
            this.colPlayerShooting.Width = 56;
            // 
            // colPlayerPassing
            // 
            this.colPlayerPassing.Text = "Passing";
            this.colPlayerPassing.Width = 52;
            // 
            // colPlayerDefending
            // 
            this.colPlayerDefending.Text = "Defending";
            this.colPlayerDefending.Width = 61;
            // 
            // colPlayerTackling
            // 
            this.colPlayerTackling.Text = "Tackling";
            // 
            // colPlayerBallControl
            // 
            this.colPlayerBallControl.Text = "Ball Control";
            this.colPlayerBallControl.Width = 70;
            // 
            // colPlayerGoalkeeping
            // 
            this.colPlayerGoalkeeping.Text = "Goalkeeping";
            this.colPlayerGoalkeeping.Width = 76;
            // 
            // colPlayerEnergy
            // 
            this.colPlayerEnergy.Text = "Energy";
            // 
            // colPlayerOverall
            // 
            this.colPlayerOverall.Text = "Overall";
            this.colPlayerOverall.Width = 51;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cmdEmail
            // 
            this.cmdEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdEmail.Location = new System.Drawing.Point(1122, 487);
            this.cmdEmail.Name = "cmdEmail";
            this.cmdEmail.Size = new System.Drawing.Size(87, 40);
            this.cmdEmail.TabIndex = 8;
            this.cmdEmail.Text = "Email Teams";
            this.cmdEmail.UseVisualStyleBackColor = true;
            this.cmdEmail.Click += new System.EventHandler(this.cmdEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Shooting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Passing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tackling";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Defending";
            // 
            // numTackling
            // 
            this.numTackling.Location = new System.Drawing.Point(241, 72);
            this.numTackling.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTackling.Name = "numTackling";
            this.numTackling.Size = new System.Drawing.Size(45, 20);
            this.numTackling.TabIndex = 14;
            // 
            // numDefending
            // 
            this.numDefending.Location = new System.Drawing.Point(165, 72);
            this.numDefending.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numDefending.Name = "numDefending";
            this.numDefending.Size = new System.Drawing.Size(45, 20);
            this.numDefending.TabIndex = 15;
            // 
            // numPassing
            // 
            this.numPassing.Location = new System.Drawing.Point(95, 72);
            this.numPassing.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numPassing.Name = "numPassing";
            this.numPassing.Size = new System.Drawing.Size(45, 20);
            this.numPassing.TabIndex = 16;
            // 
            // numEnergy
            // 
            this.numEnergy.Location = new System.Drawing.Point(305, 72);
            this.numEnergy.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numEnergy.Name = "numEnergy";
            this.numEnergy.Size = new System.Drawing.Size(45, 20);
            this.numEnergy.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Energy";
            // 
            // cmdSortAvailable
            // 
            this.cmdSortAvailable.Location = new System.Drawing.Point(645, 79);
            this.cmdSortAvailable.Name = "cmdSortAvailable";
            this.cmdSortAvailable.Size = new System.Drawing.Size(72, 32);
            this.cmdSortAvailable.TabIndex = 19;
            this.cmdSortAvailable.Text = "Sort";
            this.cmdSortAvailable.UseVisualStyleBackColor = true;
            this.cmdSortAvailable.Click += new System.EventHandler(this.cmdSortAvailable_Click);
            // 
            // cmdSaveList
            // 
            this.cmdSaveList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSaveList.Location = new System.Drawing.Point(653, 442);
            this.cmdSaveList.Name = "cmdSaveList";
            this.cmdSaveList.Size = new System.Drawing.Size(57, 39);
            this.cmdSaveList.TabIndex = 20;
            this.cmdSaveList.Text = "Save List";
            this.cmdSaveList.UseVisualStyleBackColor = true;
            this.cmdSaveList.Click += new System.EventHandler(this.cmdSaveList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label99);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.numBallControl);
            this.groupBox1.Controls.Add(this.numGoalkeeping);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdAddFootballer);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.numShooting);
            this.groupBox1.Controls.Add(this.numEnergy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numPassing);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numDefending);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numTackling);
            this.groupBox1.Location = new System.Drawing.Point(12, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 115);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(360, 56);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(60, 13);
            this.label99.TabIndex = 22;
            this.label99.Text = "Ball Control";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(435, 56);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 13);
            this.label.TabIndex = 21;
            this.label.Text = "Goalkeeping";
            // 
            // numBallControl
            // 
            this.numBallControl.Location = new System.Drawing.Point(367, 72);
            this.numBallControl.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBallControl.Name = "numBallControl";
            this.numBallControl.Size = new System.Drawing.Size(45, 20);
            this.numBallControl.TabIndex = 20;
            // 
            // numGoalkeeping
            // 
            this.numGoalkeeping.Location = new System.Drawing.Point(442, 72);
            this.numGoalkeeping.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numGoalkeeping.Name = "numGoalkeeping";
            this.numGoalkeeping.Size = new System.Drawing.Size(45, 20);
            this.numGoalkeeping.TabIndex = 19;
            // 
            // cmdSwap
            // 
            this.cmdSwap.Location = new System.Drawing.Point(645, 119);
            this.cmdSwap.Name = "cmdSwap";
            this.cmdSwap.Size = new System.Drawing.Size(72, 32);
            this.cmdSwap.TabIndex = 22;
            this.cmdSwap.Text = "Swap";
            this.cmdSwap.UseVisualStyleBackColor = true;
            this.cmdSwap.Click += new System.EventHandler(this.cmdSwap_Click);
            // 
            // FootballTeamGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 616);
            this.Controls.Add(this.cmdSwap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsvAvailablePlayers);
            this.Controls.Add(this.lsvFootballers);
            this.Controls.Add(this.cmdSaveList);
            this.Controls.Add(this.cmdSortAvailable);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.cmdEmail);
            this.Name = "FootballTeamGenerator";
            this.Text = "Football Team Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FootballTeamGenerator_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numShooting)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTackling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPassing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnergy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBallControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoalkeeping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvFootballers;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colOverall;
        private System.Windows.Forms.Button cmdAddFootballer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numShooting;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.ListView lsvAvailablePlayers;
        private System.Windows.Forms.ColumnHeader colPlayerName;
        private System.Windows.Forms.ColumnHeader colPlayerOverall;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button cmdEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numTackling;
        private System.Windows.Forms.NumericUpDown numDefending;
        private System.Windows.Forms.NumericUpDown numPassing;
        private System.Windows.Forms.ColumnHeader colPlayerDefending;
        private System.Windows.Forms.ColumnHeader colPlayerTackling;
        private System.Windows.Forms.ColumnHeader colPlayerPassing;
        private System.Windows.Forms.ColumnHeader colPlayerShooting;
        private System.Windows.Forms.ColumnHeader colShooting;
        private System.Windows.Forms.ColumnHeader colPassing;
        private System.Windows.Forms.ColumnHeader colDefending;
        private System.Windows.Forms.ColumnHeader colTackling;
        private System.Windows.Forms.ColumnHeader colEnergy;
        private System.Windows.Forms.ColumnHeader colPlayerEnergy;
        private System.Windows.Forms.NumericUpDown numEnergy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdSortAvailable;
        private System.Windows.Forms.Button cmdSaveList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown numBallControl;
        private System.Windows.Forms.NumericUpDown numGoalkeeping;
        private System.Windows.Forms.ColumnHeader colPlayerBallControl;
        private System.Windows.Forms.ColumnHeader colPlayerGoalkeeping;
        private System.Windows.Forms.ColumnHeader colBallControl;
        private System.Windows.Forms.ColumnHeader colGoalkeeping;
        private System.Windows.Forms.Button cmdSwap;
    }
}

