﻿
namespace aru_software_eng_UI
{
    partial class RelationshipManagerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelationshipManagerLogin));
            this.RMlabel = new System.Windows.Forms.Label();
            this.RM_backButton = new System.Windows.Forms.Button();
            this.RM_login_name_entry = new System.Windows.Forms.TextBox();
            this.RM_login_password_entry = new System.Windows.Forms.TextBox();
            this.RM_login_name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RM_login_manager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RMlabel
            // 
            this.RMlabel.AutoSize = true;
            this.RMlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.RMlabel.Location = new System.Drawing.Point(0, 0);
            this.RMlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RMlabel.Name = "RMlabel";
            this.RMlabel.Size = new System.Drawing.Size(1766, 153);
            this.RMlabel.TabIndex = 0;
            this.RMlabel.Text = "Relationship Manager Login";
            this.RMlabel.Click += new System.EventHandler(this.RMlogin_Click);
            // 
            // RM_backButton
            // 
            this.RM_backButton.Image = ((System.Drawing.Image)(resources.GetObject("RM_backButton.Image")));
            this.RM_backButton.Location = new System.Drawing.Point(1388, 23);
            this.RM_backButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RM_backButton.Name = "RM_backButton";
            this.RM_backButton.Size = new System.Drawing.Size(256, 123);
            this.RM_backButton.TabIndex = 1;
            this.RM_backButton.UseVisualStyleBackColor = true;
            this.RM_backButton.Click += new System.EventHandler(this.RM_backButton_Click);
            // 
            // RM_login_name_entry
            // 
            this.RM_login_name_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.RM_login_name_entry.Location = new System.Drawing.Point(588, 329);
            this.RM_login_name_entry.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RM_login_name_entry.Name = "RM_login_name_entry";
            this.RM_login_name_entry.Size = new System.Drawing.Size(1000, 98);
            this.RM_login_name_entry.TabIndex = 2;
            // 
            // RM_login_password_entry
            // 
            this.RM_login_password_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.RM_login_password_entry.Location = new System.Drawing.Point(588, 483);
            this.RM_login_password_entry.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RM_login_password_entry.Name = "RM_login_password_entry";
            this.RM_login_password_entry.Size = new System.Drawing.Size(1000, 98);
            this.RM_login_password_entry.TabIndex = 3;
            // 
            // RM_login_name_label
            // 
            this.RM_login_name_label.AutoSize = true;
            this.RM_login_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.RM_login_name_label.Location = new System.Drawing.Point(20, 335);
            this.RM_login_name_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RM_login_name_label.Name = "RM_login_name_label";
            this.RM_login_name_label.Size = new System.Drawing.Size(279, 91);
            this.RM_login_name_label.TabIndex = 4;
            this.RM_login_name_label.Text = "Name:";
            this.RM_login_name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 481);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 91);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password:";
            // 
            // RM_login_manager
            // 
            this.RM_login_manager.BackColor = System.Drawing.SystemColors.Highlight;
            this.RM_login_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RM_login_manager.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RM_login_manager.Location = new System.Drawing.Point(42, 671);
            this.RM_login_manager.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RM_login_manager.Name = "RM_login_manager";
            this.RM_login_manager.Size = new System.Drawing.Size(1550, 165);
            this.RM_login_manager.TabIndex = 6;
            this.RM_login_manager.Text = "Login";
            this.RM_login_manager.UseVisualStyleBackColor = false;
            this.RM_login_manager.Click += new System.EventHandler(this.RM_login_manager_Click);
            // 
            // RelationshipManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 887);
            this.Controls.Add(this.RM_login_manager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RM_login_name_label);
            this.Controls.Add(this.RM_login_password_entry);
            this.Controls.Add(this.RM_login_name_entry);
            this.Controls.Add(this.RM_backButton);
            this.Controls.Add(this.RMlabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "RelationshipManagerLogin";
            this.Text = "RelationshipManagerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RMlabel;
        private System.Windows.Forms.Button RM_backButton;
        private System.Windows.Forms.TextBox RM_login_name_entry;
        private System.Windows.Forms.TextBox RM_login_password_entry;
        private System.Windows.Forms.Label RM_login_name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RM_login_manager;
    }
}