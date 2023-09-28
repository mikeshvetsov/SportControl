
namespace SportControl
{
    partial class FormMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Read = new System.Windows.Forms.Button();
            this.groupBox_ant = new System.Windows.Forms.GroupBox();
            this.checkBox_ant4 = new System.Windows.Forms.CheckBox();
            this.checkBox_ant3 = new System.Windows.Forms.CheckBox();
            this.checkBox_ant2 = new System.Windows.Forms.CheckBox();
            this.checkBox_ant1 = new System.Windows.Forms.CheckBox();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.numericUpDown_reader_port = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBox_reader_ip = new System.Windows.Forms.MaskedTextBox();
            this.checkBox_Simulator = new System.Windows.Forms.CheckBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timerRemoveOldRecords = new System.Windows.Forms.Timer(this.components);
            this.dgvPerson = new SportControl.DataGridViewPersonTag();
            this.TID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RacingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_ant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reader_port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 595);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPerson);
            this.tabPage1.Controls.Add(this.button_Read);
            this.tabPage1.Controls.Add(this.groupBox_ant);
            this.tabPage1.Controls.Add(this.button_disconnect);
            this.tabPage1.Controls.Add(this.numericUpDown_reader_port);
            this.tabPage1.Controls.Add(this.maskedTextBox_reader_ip);
            this.tabPage1.Controls.Add(this.checkBox_Simulator);
            this.tabPage1.Controls.Add(this.button_connect);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(569, 18);
            this.button_Read.Margin = new System.Windows.Forms.Padding(1);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(86, 23);
            this.button_Read.TabIndex = 31;
            this.button_Read.Text = "Читать";
            this.button_Read.UseVisualStyleBackColor = true;
            // 
            // groupBox_ant
            // 
            this.groupBox_ant.Controls.Add(this.checkBox_ant4);
            this.groupBox_ant.Controls.Add(this.checkBox_ant3);
            this.groupBox_ant.Controls.Add(this.checkBox_ant2);
            this.groupBox_ant.Controls.Add(this.checkBox_ant1);
            this.groupBox_ant.Location = new System.Drawing.Point(8, 6);
            this.groupBox_ant.Name = "groupBox_ant";
            this.groupBox_ant.Size = new System.Drawing.Size(228, 48);
            this.groupBox_ant.TabIndex = 30;
            this.groupBox_ant.TabStop = false;
            this.groupBox_ant.Text = "Антены";
            // 
            // checkBox_ant4
            // 
            this.checkBox_ant4.AutoSize = true;
            this.checkBox_ant4.Location = new System.Drawing.Point(174, 19);
            this.checkBox_ant4.Name = "checkBox_ant4";
            this.checkBox_ant4.Size = new System.Drawing.Size(50, 17);
            this.checkBox_ant4.TabIndex = 3;
            this.checkBox_ant4.Tag = "8";
            this.checkBox_ant4.Text = "Ант4";
            this.checkBox_ant4.UseVisualStyleBackColor = true;
            // 
            // checkBox_ant3
            // 
            this.checkBox_ant3.AutoSize = true;
            this.checkBox_ant3.Location = new System.Drawing.Point(118, 19);
            this.checkBox_ant3.Name = "checkBox_ant3";
            this.checkBox_ant3.Size = new System.Drawing.Size(50, 17);
            this.checkBox_ant3.TabIndex = 2;
            this.checkBox_ant3.Tag = "4";
            this.checkBox_ant3.Text = "Ант3";
            this.checkBox_ant3.UseVisualStyleBackColor = true;
            // 
            // checkBox_ant2
            // 
            this.checkBox_ant2.AutoSize = true;
            this.checkBox_ant2.Location = new System.Drawing.Point(62, 19);
            this.checkBox_ant2.Name = "checkBox_ant2";
            this.checkBox_ant2.Size = new System.Drawing.Size(50, 17);
            this.checkBox_ant2.TabIndex = 1;
            this.checkBox_ant2.Tag = "2";
            this.checkBox_ant2.Text = "Ант2";
            this.checkBox_ant2.UseVisualStyleBackColor = true;
            // 
            // checkBox_ant1
            // 
            this.checkBox_ant1.AutoSize = true;
            this.checkBox_ant1.Checked = true;
            this.checkBox_ant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ant1.Location = new System.Drawing.Point(6, 19);
            this.checkBox_ant1.Name = "checkBox_ant1";
            this.checkBox_ant1.Size = new System.Drawing.Size(50, 17);
            this.checkBox_ant1.TabIndex = 0;
            this.checkBox_ant1.Tag = "1";
            this.checkBox_ant1.Text = "Ант1";
            this.checkBox_ant1.UseVisualStyleBackColor = true;
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(659, 18);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(85, 23);
            this.button_disconnect.TabIndex = 29;
            this.button_disconnect.Text = "Отключить";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // numericUpDown_reader_port
            // 
            this.numericUpDown_reader_port.Location = new System.Drawing.Point(332, 23);
            this.numericUpDown_reader_port.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numericUpDown_reader_port.Name = "numericUpDown_reader_port";
            this.numericUpDown_reader_port.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_reader_port.TabIndex = 28;
            this.numericUpDown_reader_port.Value = new decimal(new int[] {
            9090,
            0,
            0,
            0});
            // 
            // maskedTextBox_reader_ip
            // 
            this.maskedTextBox_reader_ip.Location = new System.Drawing.Point(238, 22);
            this.maskedTextBox_reader_ip.Name = "maskedTextBox_reader_ip";
            this.maskedTextBox_reader_ip.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBox_reader_ip.TabIndex = 27;
            this.maskedTextBox_reader_ip.Text = "192.168.1.116";
            // 
            // checkBox_Simulator
            // 
            this.checkBox_Simulator.AutoSize = true;
            this.checkBox_Simulator.Location = new System.Drawing.Point(393, 24);
            this.checkBox_Simulator.Name = "checkBox_Simulator";
            this.checkBox_Simulator.Size = new System.Drawing.Size(81, 17);
            this.checkBox_Simulator.TabIndex = 26;
            this.checkBox_Simulator.Text = "Симулятор";
            this.checkBox_Simulator.UseVisualStyleBackColor = true;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(480, 18);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(85, 23);
            this.button_connect.TabIndex = 25;
            this.button_connect.Text = "Подключить";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timerRemoveOldRecords
            // 
            this.timerRemoveOldRecords.Enabled = true;
            this.timerRemoveOldRecords.Interval = 1000;
            this.timerRemoveOldRecords.Tick += new System.EventHandler(this.timerRemoveOldRecords_Tick);
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TID1,
            this.TID2,
            this.RacingNumber,
            this.Family,
            this.FirstName,
            this.Kid});
            this.dgvPerson.Location = new System.Drawing.Point(8, 60);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.RowHeadersWidth = 25;
            this.dgvPerson.Size = new System.Drawing.Size(1019, 474);
            this.dgvPerson.TabIndex = 32;
            // 
            // TID1
            // 
            this.TID1.HeaderText = "TID1";
            this.TID1.Name = "TID1";
            this.TID1.ReadOnly = true;
            this.TID1.Width = 250;
            // 
            // TID2
            // 
            this.TID2.HeaderText = "TID2";
            this.TID2.Name = "TID2";
            this.TID2.ReadOnly = true;
            this.TID2.Width = 250;
            // 
            // RacingNumber
            // 
            this.RacingNumber.HeaderText = "Номер";
            this.RacingNumber.Name = "RacingNumber";
            this.RacingNumber.ReadOnly = true;
            this.RacingNumber.Width = 50;
            // 
            // Family
            // 
            this.Family.HeaderText = "Фамилия";
            this.Family.Name = "Family";
            this.Family.ReadOnly = true;
            this.Family.Width = 200;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 200;
            // 
            // Kid
            // 
            this.Kid.HeaderText = "-18";
            this.Kid.Name = "Kid";
            this.Kid.ReadOnly = true;
            this.Kid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Kid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Kid.Width = 30;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 596);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox_ant.ResumeLayout(false);
            this.groupBox_ant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reader_port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox_Simulator;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.GroupBox groupBox_ant;
        private System.Windows.Forms.CheckBox checkBox_ant4;
        private System.Windows.Forms.CheckBox checkBox_ant3;
        private System.Windows.Forms.CheckBox checkBox_ant2;
        private System.Windows.Forms.CheckBox checkBox_ant1;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.NumericUpDown numericUpDown_reader_port;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_reader_ip;
        private DataGridViewPersonTag dgvPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Kid;
        private System.Windows.Forms.Timer timerRemoveOldRecords;
    }
}