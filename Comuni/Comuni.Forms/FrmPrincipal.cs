﻿using Comuni.Forms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comuni.Forms
{
    public partial class FrmPrincipal : FrmBase
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void customIconButton1_Click(object sender, EventArgs e)
        {
            new FrmBaseDialog().Show();
        }
    }
}
