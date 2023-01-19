
namespace SportControl
{
    partial class Form2
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
            this.button_StopRace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TimeStart = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_TimeRace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_StopRace
            // 
            this.button_StopRace.Location = new System.Drawing.Point(713, 12);
            this.button_StopRace.Name = "button_StopRace";
            this.button_StopRace.Size = new System.Drawing.Size(75, 23);
            this.button_StopRace.TabIndex = 2;
            this.button_StopRace.Text = "Скрыть";
            this.button_StopRace.UseVisualStyleBackColor = true;
            this.button_StopRace.Click += new System.EventHandler(this.button_StopRace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Время старта:";
            // 
            // label_TimeStart
            // 
            this.label_TimeStart.AutoSize = true;
            this.label_TimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TimeStart.Location = new System.Drawing.Point(437, 93);
            this.label_TimeStart.Name = "label_TimeStart";
            this.label_TimeStart.Size = new System.Drawing.Size(132, 55);
            this.label_TimeStart.TabIndex = 4;
            this.label_TimeStart.Text = "0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(79, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время гонки:";
            // 
            // label_TimeRace
            // 
            this.label_TimeRace.AutoSize = true;
            this.label_TimeRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TimeRace.Location = new System.Drawing.Point(437, 208);
            this.label_TimeRace.Name = "label_TimeRace";
            this.label_TimeRace.Size = new System.Drawing.Size(132, 55);
            this.label_TimeRace.TabIndex = 7;
            this.label_TimeRace.Text = "0000";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label_TimeRace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_TimeStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_StopRace);
            this.Name = "Form2";
            this.Text = "Время";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_StopRace;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label_TimeStart;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label_TimeRace;
    }
}