﻿namespace HospitalManagementSystem
{
    partial class DoctorsListUserControl
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
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.crudPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bodyPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.crudPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.panel4);
            this.bodyPanel.Controls.Add(this.panel3);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(986, 768);
            this.bodyPanel.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.crudPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(986, 720);
            this.panel4.TabIndex = 4;
            // 
            // crudPanel
            // 
            this.crudPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.crudPanel.Controls.Add(this.button2);
            this.crudPanel.Controls.Add(this.removeButton);
            this.crudPanel.Controls.Add(this.addUserBtn);
            this.crudPanel.Location = new System.Drawing.Point(919, 250);
            this.crudPanel.Margin = new System.Windows.Forms.Padding(100);
            this.crudPanel.Name = "crudPanel";
            this.crudPanel.Padding = new System.Windows.Forms.Padding(10);
            this.crudPanel.Size = new System.Drawing.Size(67, 183);
            this.crudPanel.TabIndex = 0;
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
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 48);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(429, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctors";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoctorsListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bodyPanel);
            this.Name = "DoctorsListUserControl";
            this.Size = new System.Drawing.Size(986, 768);
            this.bodyPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.crudPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addUserBtn;
        public System.Windows.Forms.Panel crudPanel;
    }
}
