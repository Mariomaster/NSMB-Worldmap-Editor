﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSMB_Worldmap_Editor
{
    public partial class NewAnimationFileDialog : Form
    {
        public NewAnimationFileDialog()
        {
            InitializeComponent();
            this.CenterToScreen();

            selectedWorld.SelectedIndex = 0;

            createButton.Focus();
        }

        public int worldIndex() { return selectedWorld.SelectedIndex; }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
