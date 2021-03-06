﻿namespace View.View
{
    partial class RegisterMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterMachine));
            this.ClientLabel = new System.Windows.Forms.Label();
            this.MachineComplexityLabel = new System.Windows.Forms.Label();
            this.MachineDescriptionLabel = new System.Windows.Forms.Label();
            this.ClientsComboBox = new System.Windows.Forms.ComboBox();
            this.ComplexityComboBox = new System.Windows.Forms.ComboBox();
            this.MachineDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.MachineNameLabel = new System.Windows.Forms.Label();
            this.GeneratedNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(107, 21);
            this.ClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(47, 17);
            this.ClientLabel.TabIndex = 0;
            this.ClientLabel.Text = "Client:";
            // 
            // MachineComplexityLabel
            // 
            this.MachineComplexityLabel.AutoSize = true;
            this.MachineComplexityLabel.Location = new System.Drawing.Point(16, 49);
            this.MachineComplexityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MachineComplexityLabel.Name = "MachineComplexityLabel";
            this.MachineComplexityLabel.Size = new System.Drawing.Size(136, 17);
            this.MachineComplexityLabel.TabIndex = 1;
            this.MachineComplexityLabel.Text = "Machine Complexity:";
            // 
            // MachineDescriptionLabel
            // 
            this.MachineDescriptionLabel.AutoSize = true;
            this.MachineDescriptionLabel.Location = new System.Drawing.Point(71, 81);
            this.MachineDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MachineDescriptionLabel.Name = "MachineDescriptionLabel";
            this.MachineDescriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.MachineDescriptionLabel.TabIndex = 2;
            this.MachineDescriptionLabel.Text = "Description:";
            // 
            // ClientsComboBox
            // 
            this.ClientsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientsComboBox.FormattingEnabled = true;
            this.ClientsComboBox.Location = new System.Drawing.Point(164, 16);
            this.ClientsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientsComboBox.Name = "ClientsComboBox";
            this.ClientsComboBox.Size = new System.Drawing.Size(236, 24);
            this.ClientsComboBox.TabIndex = 3;
            this.ClientsComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientsComboBox_SelectedIndexChanged);
            // 
            // ComplexityComboBox
            // 
            this.ComplexityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComplexityComboBox.FormattingEnabled = true;
            this.ComplexityComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ComplexityComboBox.Location = new System.Drawing.Point(164, 46);
            this.ComplexityComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComplexityComboBox.Name = "ComplexityComboBox";
            this.ComplexityComboBox.Size = new System.Drawing.Size(67, 24);
            this.ComplexityComboBox.TabIndex = 4;
            this.ComplexityComboBox.SelectedIndexChanged += new System.EventHandler(this.ComplexityComboBox_SelectedIndexChanged);
            // 
            // MachineDescriptionTextBox
            // 
            this.MachineDescriptionTextBox.Location = new System.Drawing.Point(164, 78);
            this.MachineDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MachineDescriptionTextBox.Name = "MachineDescriptionTextBox";
            this.MachineDescriptionTextBox.Size = new System.Drawing.Size(236, 194);
            this.MachineDescriptionTextBox.TabIndex = 5;
            this.MachineDescriptionTextBox.Text = "";
            this.MachineDescriptionTextBox.TextChanged += new System.EventHandler(this.MachineDescriptionTextBox_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(301, 327);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 28);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Enabled = false;
            this.AcceptButton.Location = new System.Drawing.Point(193, 327);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(100, 28);
            this.AcceptButton.TabIndex = 7;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // MachineNameLabel
            // 
            this.MachineNameLabel.AutoSize = true;
            this.MachineNameLabel.Location = new System.Drawing.Point(45, 288);
            this.MachineNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MachineNameLabel.Name = "MachineNameLabel";
            this.MachineNameLabel.Size = new System.Drawing.Size(106, 17);
            this.MachineNameLabel.TabIndex = 8;
            this.MachineNameLabel.Text = "Machine Name:";
            // 
            // GeneratedNameLabel
            // 
            this.GeneratedNameLabel.AutoSize = true;
            this.GeneratedNameLabel.Location = new System.Drawing.Point(164, 288);
            this.GeneratedNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GeneratedNameLabel.Name = "GeneratedNameLabel";
            this.GeneratedNameLabel.Size = new System.Drawing.Size(108, 17);
            this.GeneratedNameLabel.TabIndex = 9;
            this.GeneratedNameLabel.Text = "MACHINENAME";
            // 
            // RegisterMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 370);
            this.Controls.Add(this.GeneratedNameLabel);
            this.Controls.Add(this.MachineNameLabel);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.MachineDescriptionTextBox);
            this.Controls.Add(this.ComplexityComboBox);
            this.Controls.Add(this.ClientsComboBox);
            this.Controls.Add(this.MachineDescriptionLabel);
            this.Controls.Add(this.MachineComplexityLabel);
            this.Controls.Add(this.ClientLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Machine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterMachine_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label MachineComplexityLabel;
        private System.Windows.Forms.Label MachineDescriptionLabel;
        private System.Windows.Forms.ComboBox ClientsComboBox;
        private System.Windows.Forms.ComboBox ComplexityComboBox;
        private System.Windows.Forms.RichTextBox MachineDescriptionTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label MachineNameLabel;
        private System.Windows.Forms.Label GeneratedNameLabel;
    }
}