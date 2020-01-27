namespace WindowsFormsApp1.Views
{
    partial class Form1
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
            this.curFloorLabel = new System.Windows.Forms.Label();
            this.nofPeopleTextLabel = new System.Windows.Forms.Label();
            this.nofFloorsTextLabel = new System.Windows.Forms.Label();
            this.PeopleField = new System.Windows.Forms.TextBox();
            this.FloorsField = new System.Windows.Forms.TextBox();
            this.InitialDataGBox = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.peopleCarriedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeElapsedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.destFloorTextLabel = new System.Windows.Forms.Label();
            this.DestinationFloorField = new System.Windows.Forms.TextBox();
            this.weighTextLabel = new System.Windows.Forms.Label();
            this.initFloorTextLabel = new System.Windows.Forms.Label();
            this.InitialFloorField = new System.Windows.Forms.TextBox();
            this.WeighField = new System.Windows.Forms.TextBox();
            this.nameTextLabel = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.newUserGBox = new System.Windows.Forms.GroupBox();
            this.InfoBox = new System.Windows.Forms.ListBox();
            this.OverloadLabel = new System.Windows.Forms.Label();
            this.InitialDataGBox.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.newUserGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // curFloorLabel
            // 
            this.curFloorLabel.AutoSize = true;
            this.curFloorLabel.Location = new System.Drawing.Point(26, 399);
            this.curFloorLabel.Name = "curFloorLabel";
            this.curFloorLabel.Size = new System.Drawing.Size(0, 13);
            this.curFloorLabel.TabIndex = 14;
            // 
            // nofPeopleTextLabel
            // 
            this.nofPeopleTextLabel.AutoSize = true;
            this.nofPeopleTextLabel.Location = new System.Drawing.Point(18, 65);
            this.nofPeopleTextLabel.Name = "nofPeopleTextLabel";
            this.nofPeopleTextLabel.Size = new System.Drawing.Size(89, 13);
            this.nofPeopleTextLabel.TabIndex = 7;
            this.nofPeopleTextLabel.Text = "number of people";
            // 
            // nofFloorsTextLabel
            // 
            this.nofFloorsTextLabel.AutoSize = true;
            this.nofFloorsTextLabel.Location = new System.Drawing.Point(25, 39);
            this.nofFloorsTextLabel.Name = "nofFloorsTextLabel";
            this.nofFloorsTextLabel.Size = new System.Drawing.Size(82, 13);
            this.nofFloorsTextLabel.TabIndex = 6;
            this.nofFloorsTextLabel.Text = "number of floors";
            // 
            // PeopleField
            // 
            this.PeopleField.Location = new System.Drawing.Point(113, 62);
            this.PeopleField.Name = "PeopleField";
            this.PeopleField.Size = new System.Drawing.Size(100, 20);
            this.PeopleField.TabIndex = 1;
            this.PeopleField.Text = "А НАФИГА ЭТО ПОЛЕ??";
            // 
            // FloorsField
            // 
            this.FloorsField.Location = new System.Drawing.Point(113, 36);
            this.FloorsField.Name = "FloorsField";
            this.FloorsField.Size = new System.Drawing.Size(100, 20);
            this.FloorsField.TabIndex = 0;
            // 
            // InitialDataGBox
            // 
            this.InitialDataGBox.Controls.Add(this.nofPeopleTextLabel);
            this.InitialDataGBox.Controls.Add(this.nofFloorsTextLabel);
            this.InitialDataGBox.Controls.Add(this.PeopleField);
            this.InitialDataGBox.Controls.Add(this.FloorsField);
            this.InitialDataGBox.Controls.Add(this.StartButton);
            this.InitialDataGBox.Location = new System.Drawing.Point(29, 11);
            this.InitialDataGBox.Name = "InitialDataGBox";
            this.InitialDataGBox.Size = new System.Drawing.Size(230, 147);
            this.InitialDataGBox.TabIndex = 12;
            this.InitialDataGBox.TabStop = false;
            this.InitialDataGBox.Text = "initial data";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(77, 107);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.AllowDrop = true;
            this.StopButton.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.StopButton.Location = new System.Drawing.Point(106, 394);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 11;
            this.StopButton.Text = "stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // peopleCarriedStatusLabel
            // 
            this.peopleCarriedStatusLabel.Name = "peopleCarriedStatusLabel";
            this.peopleCarriedStatusLabel.Size = new System.Drawing.Size(75, 17);
            this.peopleCarriedStatusLabel.Text = "people carried";
            // 
            // timeElapsedStatusLabel
            // 
            this.timeElapsedStatusLabel.Name = "timeElapsedStatusLabel";
            this.timeElapsedStatusLabel.Size = new System.Drawing.Size(69, 17);
            this.timeElapsedStatusLabel.Text = "Time elapsed";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeElapsedStatusLabel,
            this.peopleCarriedStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 437);
            this.statusBar.Name = "statusBar";
            this.statusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusBar.Size = new System.Drawing.Size(633, 22);
            this.statusBar.TabIndex = 10;
            this.statusBar.Text = "StatusBar";
            // 
            // destFloorTextLabel
            // 
            this.destFloorTextLabel.AutoSize = true;
            this.destFloorTextLabel.Location = new System.Drawing.Point(26, 100);
            this.destFloorTextLabel.Name = "destFloorTextLabel";
            this.destFloorTextLabel.Size = new System.Drawing.Size(81, 13);
            this.destFloorTextLabel.TabIndex = 5;
            this.destFloorTextLabel.Text = "destination floor";
            // 
            // DestinationFloorField
            // 
            this.DestinationFloorField.Location = new System.Drawing.Point(113, 97);
            this.DestinationFloorField.Name = "DestinationFloorField";
            this.DestinationFloorField.Size = new System.Drawing.Size(100, 20);
            this.DestinationFloorField.TabIndex = 4;
            // 
            // weighTextLabel
            // 
            this.weighTextLabel.AutoSize = true;
            this.weighTextLabel.Location = new System.Drawing.Point(69, 48);
            this.weighTextLabel.Name = "weighTextLabel";
            this.weighTextLabel.Size = new System.Drawing.Size(35, 13);
            this.weighTextLabel.TabIndex = 3;
            this.weighTextLabel.Text = "weigh";
            // 
            // initFloorTextLabel
            // 
            this.initFloorTextLabel.AutoSize = true;
            this.initFloorTextLabel.Location = new System.Drawing.Point(54, 74);
            this.initFloorTextLabel.Name = "initFloorTextLabel";
            this.initFloorTextLabel.Size = new System.Drawing.Size(53, 13);
            this.initFloorTextLabel.TabIndex = 4;
            this.initFloorTextLabel.Text = "initial floor";
            // 
            // InitialFloorField
            // 
            this.InitialFloorField.Location = new System.Drawing.Point(113, 71);
            this.InitialFloorField.Name = "InitialFloorField";
            this.InitialFloorField.Size = new System.Drawing.Size(100, 20);
            this.InitialFloorField.TabIndex = 3;
            // 
            // WeighField
            // 
            this.WeighField.Location = new System.Drawing.Point(113, 45);
            this.WeighField.Name = "WeighField";
            this.WeighField.Size = new System.Drawing.Size(100, 20);
            this.WeighField.TabIndex = 2;
            // 
            // nameTextLabel
            // 
            this.nameTextLabel.AutoSize = true;
            this.nameTextLabel.Location = new System.Drawing.Point(74, 22);
            this.nameTextLabel.Name = "nameTextLabel";
            this.nameTextLabel.Size = new System.Drawing.Size(33, 13);
            this.nameTextLabel.TabIndex = 2;
            this.nameTextLabel.Text = "name";
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(113, 19);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(100, 20);
            this.NameField.TabIndex = 1;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(77, 133);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(75, 23);
            this.AddUserButton.TabIndex = 1;
            this.AddUserButton.Text = "add";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // newUserGBox
            // 
            this.newUserGBox.BackColor = System.Drawing.SystemColors.Control;
            this.newUserGBox.Controls.Add(this.destFloorTextLabel);
            this.newUserGBox.Controls.Add(this.DestinationFloorField);
            this.newUserGBox.Controls.Add(this.weighTextLabel);
            this.newUserGBox.Controls.Add(this.initFloorTextLabel);
            this.newUserGBox.Controls.Add(this.InitialFloorField);
            this.newUserGBox.Controls.Add(this.WeighField);
            this.newUserGBox.Controls.Add(this.nameTextLabel);
            this.newUserGBox.Controls.Add(this.NameField);
            this.newUserGBox.Controls.Add(this.AddUserButton);
            this.newUserGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newUserGBox.Location = new System.Drawing.Point(29, 196);
            this.newUserGBox.Name = "newUserGBox";
            this.newUserGBox.Size = new System.Drawing.Size(230, 176);
            this.newUserGBox.TabIndex = 9;
            this.newUserGBox.TabStop = false;
            this.newUserGBox.Text = "New user";
            // 
            // InfoBox
            // 
            this.InfoBox.FormattingEnabled = true;
            this.InfoBox.Location = new System.Drawing.Point(278, 12);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(343, 368);
            this.InfoBox.TabIndex = 16;
            // 
            // OverloadLabel
            // 
            this.OverloadLabel.AutoSize = true;
            this.OverloadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OverloadLabel.ForeColor = System.Drawing.Color.Red;
            this.OverloadLabel.Location = new System.Drawing.Point(82, 173);
            this.OverloadLabel.Name = "OverloadLabel";
            this.OverloadLabel.Size = new System.Drawing.Size(122, 20);
            this.OverloadLabel.TabIndex = 17;
            this.OverloadLabel.Text = "ПЕРЕГРУЗКА!!";
            this.OverloadLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 459);
            this.Controls.Add(this.OverloadLabel);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.curFloorLabel);
            this.Controls.Add(this.InitialDataGBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.newUserGBox);
            this.Name = "Form1";
            this.Text = "Control Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.InitialDataGBox.ResumeLayout(false);
            this.InitialDataGBox.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.newUserGBox.ResumeLayout(false);
            this.newUserGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label curFloorLabel;
        private System.Windows.Forms.Label nofPeopleTextLabel;
        private System.Windows.Forms.Label nofFloorsTextLabel;
        private System.Windows.Forms.TextBox PeopleField;
        private System.Windows.Forms.TextBox FloorsField;
        private System.Windows.Forms.GroupBox InitialDataGBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ToolStripStatusLabel peopleCarriedStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel timeElapsedStatusLabel;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Label destFloorTextLabel;
        private System.Windows.Forms.TextBox DestinationFloorField;
        private System.Windows.Forms.Label weighTextLabel;
        private System.Windows.Forms.Label initFloorTextLabel;
        private System.Windows.Forms.TextBox InitialFloorField;
        private System.Windows.Forms.TextBox WeighField;
        private System.Windows.Forms.Label nameTextLabel;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.GroupBox newUserGBox;
        private System.Windows.Forms.ListBox InfoBox;
        private System.Windows.Forms.Label OverloadLabel;
    }
}