namespace HospitalManagementSystem
{
    partial class ReceiptionistUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.patientQueueBtn = new System.Windows.Forms.Button();
            this.patientSumBtn = new System.Windows.Forms.Button();
            this.doctorsButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.patientEntryButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.bodyPanel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 768);
            this.panel2.TabIndex = 3;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bodyPanel.Location = new System.Drawing.Point(214, 0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(986, 765);
            this.bodyPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.patientQueueBtn);
            this.panel1.Controls.Add(this.patientSumBtn);
            this.panel1.Controls.Add(this.doctorsButton);
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.patientEntryButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 768);
            this.panel1.TabIndex = 0;
            // 
            // patientQueueBtn
            // 
            this.patientQueueBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientQueueBtn.Location = new System.Drawing.Point(0, 362);
            this.patientQueueBtn.Margin = new System.Windows.Forms.Padding(30);
            this.patientQueueBtn.Name = "patientQueueBtn";
            this.patientQueueBtn.Size = new System.Drawing.Size(214, 64);
            this.patientQueueBtn.TabIndex = 10;
            this.patientQueueBtn.Text = "Patient Queue";
            this.patientQueueBtn.UseVisualStyleBackColor = true;
            this.patientQueueBtn.Click += new System.EventHandler(this.patientQueueBtn_Click);
            // 
            // patientSumBtn
            // 
            this.patientSumBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientSumBtn.Location = new System.Drawing.Point(0, 298);
            this.patientSumBtn.Margin = new System.Windows.Forms.Padding(30);
            this.patientSumBtn.Name = "patientSumBtn";
            this.patientSumBtn.Size = new System.Drawing.Size(214, 64);
            this.patientSumBtn.TabIndex = 9;
            this.patientSumBtn.Text = "Patient Summary";
            this.patientSumBtn.UseVisualStyleBackColor = true;
            this.patientSumBtn.Click += new System.EventHandler(this.patientSumBtn_Click);
            // 
            // doctorsButton
            // 
            this.doctorsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorsButton.Location = new System.Drawing.Point(0, 234);
            this.doctorsButton.Margin = new System.Windows.Forms.Padding(30);
            this.doctorsButton.Name = "doctorsButton";
            this.doctorsButton.Size = new System.Drawing.Size(214, 64);
            this.doctorsButton.TabIndex = 8;
            this.doctorsButton.Text = "View Doctors";
            this.doctorsButton.UseVisualStyleBackColor = true;
            this.doctorsButton.Click += new System.EventHandler(this.doctorsButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutButton.Location = new System.Drawing.Point(0, 704);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(214, 64);
            this.logOutButton.TabIndex = 7;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            // 
            // patientEntryButton
            // 
            this.patientEntryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientEntryButton.Location = new System.Drawing.Point(0, 170);
            this.patientEntryButton.Margin = new System.Windows.Forms.Padding(30);
            this.patientEntryButton.Name = "patientEntryButton";
            this.patientEntryButton.Size = new System.Drawing.Size(214, 64);
            this.patientEntryButton.TabIndex = 2;
            this.patientEntryButton.Text = "Patient Entry";
            this.patientEntryButton.UseVisualStyleBackColor = true;
            this.patientEntryButton.Click += new System.EventHandler(this.patientEntryButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.Health_Care_Medical_Clinic_Center_Logo__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ReceiptionistUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ReceiptionistUC";
            this.Size = new System.Drawing.Size(1200, 768);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button patientQueueBtn;
        private System.Windows.Forms.Button patientSumBtn;
        private System.Windows.Forms.Button doctorsButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button patientEntryButton;
    }
}
