﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.View
{
    public partial class RegisterJobForm : Form, IRegisterJob
    {
        // TODO: JAMIE: Add component to add attachments to the job listing to RegisterJob.
        public RegisterJobForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Add new job
            // TODO: Make sure a new job is entered and added to the database.
            // Register job, close this form and focus parent
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Cancel register job, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }

        private void RegisterJob_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel register job, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }

        private void ValidateRegisterButton()
        {
            //TODO: JAMIE: Make sure ValidateRegisterButton works when database is intergrated into this form.
            if(ClientComboBox.SelectedItem != null &&
                (ExistingMachineComboBox.SelectedItem != null || NewMachineRadioButton.Checked) &&
                FaultDescriptionTextBox.TextLength > 0 &&
                UrgencyComboBox.SelectedItem != null)
            {
                RegisterButton.Enabled = true;
            }
        }

        private void ExistingMachineRadioButton_Click(object sender, EventArgs e)
        {
            // Disable new machine options
            NewMachineRadioButton.Checked = false;
            NewMachineNameLabel.Enabled = false;
            CreateNewMachine.Enabled = false;
            // Enable existing machine options
            ExistingMachineComboBox.Enabled = true;
        }

        private void NewMachineRadioButton_Click(object sender, EventArgs e)
        {
            // Disable existing machine options
            ExistingMachineRadioButton.Checked = false;
            ExistingMachineComboBox.Enabled = false;
            // Enable new machine options
            NewMachineNameLabel.Enabled = true;
            CreateNewMachine.Enabled = true;
        }

        private void CreateNewMachine_Click(object sender, EventArgs e)
        {
            //TODO: JAMIE: Add new Create Machine Form

        }
    }
}
