namespace HospitalManagementSystem
{
    partial class ManagerUC
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.patientsButton = new System.Windows.Forms.Button();
            this.doctorsButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.receptionistButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.panel4);
            this.bodyPanel.Controls.Add(this.panel3);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bodyPanel.Location = new System.Drawing.Point(214, 0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(986, 765);
            this.bodyPanel.TabIndex = 3;
            this.bodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyPanel_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Honeydew;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(986, 720);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.removeButton);
            this.panel5.Controls.Add(this.addUserBtn);
            this.panel5.Location = new System.Drawing.Point(919, 250);
            this.panel5.Margin = new System.Windows.Forms.Padding(100);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(67, 183);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 48);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(347, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Portal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.patientsButton);
            this.panel1.Controls.Add(this.doctorsButton);
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.receptionistButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 768);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 362);
            this.button4.Margin = new System.Windows.Forms.Padding(30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 64);
            this.button4.TabIndex = 10;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // patientsButton
            // 
            this.patientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientsButton.Location = new System.Drawing.Point(0, 298);
            this.patientsButton.Margin = new System.Windows.Forms.Padding(30);
            this.patientsButton.Name = "patientsButton";
            this.patientsButton.Size = new System.Drawing.Size(214, 64);
            this.patientsButton.TabIndex = 9;
            this.patientsButton.Text = "Patient Summary";
            this.patientsButton.UseVisualStyleBackColor = true;
            this.patientsButton.Click += new System.EventHandler(this.patientsButton_Click);
            // 
            // doctorsButton
            // 
            this.doctorsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorsButton.Location = new System.Drawing.Point(0, 234);
            this.doctorsButton.Margin = new System.Windows.Forms.Padding(30);
            this.doctorsButton.Name = "doctorsButton";
            this.doctorsButton.Size = new System.Drawing.Size(214, 64);
            this.doctorsButton.TabIndex = 8;
            this.doctorsButton.Text = "Doctors";
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
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // receptionistButton
            // 
            this.receptionistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.receptionistButton.Location = new System.Drawing.Point(0, 170);
            this.receptionistButton.Margin = new System.Windows.Forms.Padding(30);
            this.receptionistButton.Name = "receptionistButton";
            this.receptionistButton.Size = new System.Drawing.Size(214, 64);
            this.receptionistButton.TabIndex = 2;
            this.receptionistButton.Text = "Receptionists";
            this.receptionistButton.UseVisualStyleBackColor = true;
            this.receptionistButton.Click += new System.EventHandler(this.receptionistButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Image = global::HospitalManagementSystem.Properties.Resources.edit_info;
            this.button2.Location = new System.Drawing.Point(10, 118);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 54);
            this.button2.TabIndex = 3;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.Image = global::HospitalManagementSystem.Properties.Resources.delete_user;
            this.removeButton.Location = new System.Drawing.Point(10, 64);
            this.removeButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(47, 54);
            this.removeButton.TabIndex = 2;
            this.removeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addUserBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addUserBtn.FlatAppearance.BorderSize = 0;
            this.addUserBtn.Image = global::HospitalManagementSystem.Properties.Resources.new_user;
            this.addUserBtn.Location = new System.Drawing.Point(10, 10);
            this.addUserBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(47, 54);
            this.addUserBtn.TabIndex = 1;
            this.addUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ManagerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ManagerUC";
            this.Size = new System.Drawing.Size(1200, 768);
            this.panel2.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button receptionistButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button patientsButton;
        private System.Windows.Forms.Button doctorsButton;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addUserBtn;
    }
}
