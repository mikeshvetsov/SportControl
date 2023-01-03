
namespace SportControl
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
            this.components = new System.ComponentModel.Container();
            this.maskedTextBox_reader_ip = new System.Windows.Forms.MaskedTextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.numericUpDown_reader_port = new System.Windows.Forms.NumericUpDown();
            this.label_connection_status = new System.Windows.Forms.Label();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.groupBox_ant = new System.Windows.Forms.GroupBox();
            this.checkBox_ant4 = new System.Windows.Forms.CheckBox();
            this.checkBox_ant3 = new System.Windows.Forms.CheckBox();
            this.checkBox_ant2 = new System.Windows.Forms.CheckBox();
            this.checkBox_ant1 = new System.Windows.Forms.CheckBox();
            this.button_Read = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_tag = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reader_port)).BeginInit();
            this.groupBox_ant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tag)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox_reader_ip
            // 
            this.maskedTextBox_reader_ip.Location = new System.Drawing.Point(12, 12);
            this.maskedTextBox_reader_ip.Name = "maskedTextBox_reader_ip";
            this.maskedTextBox_reader_ip.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBox_reader_ip.TabIndex = 0;
            this.maskedTextBox_reader_ip.Text = "192.168.0.116";
            this.maskedTextBox_reader_ip.TextChanged += new System.EventHandler(this.text_ip_TextChanged);
            this.maskedTextBox_reader_ip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_ip_KeyPress);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(167, 12);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(85, 23);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Подключить";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // numericUpDown_reader_port
            // 
            this.numericUpDown_reader_port.Location = new System.Drawing.Point(106, 12);
            this.numericUpDown_reader_port.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numericUpDown_reader_port.Name = "numericUpDown_reader_port";
            this.numericUpDown_reader_port.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_reader_port.TabIndex = 3;
            this.numericUpDown_reader_port.Value = new decimal(new int[] {
            9090,
            0,
            0,
            0});
            // 
            // label_connection_status
            // 
            this.label_connection_status.AutoSize = true;
            this.label_connection_status.Location = new System.Drawing.Point(12, 47);
            this.label_connection_status.Name = "label_connection_status";
            this.label_connection_status.Size = new System.Drawing.Size(57, 13);
            this.label_connection_status.TabIndex = 4;
            this.label_connection_status.Text = "Отключен";
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(346, 12);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(85, 23);
            this.button_disconnect.TabIndex = 5;
            this.button_disconnect.Text = "Отключить";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // groupBox_ant
            // 
            this.groupBox_ant.Controls.Add(this.checkBox_ant4);
            this.groupBox_ant.Controls.Add(this.checkBox_ant3);
            this.groupBox_ant.Controls.Add(this.checkBox_ant2);
            this.groupBox_ant.Controls.Add(this.checkBox_ant1);
            this.groupBox_ant.Location = new System.Drawing.Point(457, 12);
            this.groupBox_ant.Name = "groupBox_ant";
            this.groupBox_ant.Size = new System.Drawing.Size(241, 48);
            this.groupBox_ant.TabIndex = 6;
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
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(256, 12);
            this.button_Read.Margin = new System.Windows.Forms.Padding(1);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(86, 23);
            this.button_Read.TabIndex = 7;
            this.button_Read.Text = "Чиать";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(SportControl.Form1);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(SportControl.Form1);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(SportControl.Person);
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataSource = typeof(SportControl.Person);
            // 
            // dataGridView_tag
            // 
            this.dataGridView_tag.AllowUserToAddRows = false;
            this.dataGridView_tag.AllowUserToDeleteRows = false;
            this.dataGridView_tag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tag.Location = new System.Drawing.Point(15, 77);
            this.dataGridView_tag.Name = "dataGridView_tag";
            this.dataGridView_tag.ReadOnly = true;
            this.dataGridView_tag.Size = new System.Drawing.Size(683, 365);
            this.dataGridView_tag.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 454);
            this.Controls.Add(this.dataGridView_tag);
            this.Controls.Add(this.button_Read);
            this.Controls.Add(this.groupBox_ant);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.label_connection_status);
            this.Controls.Add(this.numericUpDown_reader_port);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.maskedTextBox_reader_ip);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reader_port)).EndInit();
            this.groupBox_ant.ResumeLayout(false);
            this.groupBox_ant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_reader_ip;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.NumericUpDown numericUpDown_reader_port;
        private System.Windows.Forms.Label label_connection_status;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.GroupBox groupBox_ant;
        private System.Windows.Forms.CheckBox checkBox_ant4;
        private System.Windows.Forms.CheckBox checkBox_ant3;
        private System.Windows.Forms.CheckBox checkBox_ant2;
        private System.Windows.Forms.CheckBox checkBox_ant1;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView_tag;
    }
}

