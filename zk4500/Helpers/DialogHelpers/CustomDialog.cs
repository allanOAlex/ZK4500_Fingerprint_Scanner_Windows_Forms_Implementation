﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace zk4500.Helpers.DialogHelpers
{
    public partial class CustomDialog : Form
    {
        public CustomDialog(string errorMessage, string caption)
        {
            InitializeComponent();
            SetErrorMessage(errorMessage, caption);
        }

        private void CustomDialog_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void SetErrorMessage(string errorMessage, string caption)
        {
            labelDialogueMessage.Text = errorMessage;
            labelDialogueCaption.Text = caption;
            labelDialogueCaption.ForeColor = Color.Red; 

        }

        private void btnDismissDialog_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
