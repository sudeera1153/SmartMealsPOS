﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            CashierMain cashierMain = new CashierMain();
            this.Hide();
            cashierMain.Show();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            CashierLoginForm cashierLoginForm = new CashierLoginForm();
            cashierLoginForm.attemptcount = 5;
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btCASHIERSET_Click(object sender, EventArgs e)
        {
            AdminCashierMain adminCashierMain = new AdminCashierMain();
            this.Dispose();
            adminCashierMain.Show();
        }

        private void btREVSET_Click(object sender, EventArgs e)
        {
            AdminViewRevenue adminViewRevenue = new AdminViewRevenue();
            this.Hide();
            adminViewRevenue.Show();
        }

        private void btITEMSET_Click(object sender, EventArgs e)
        {
            AdminFoodItemMain adminFoodItemMain = new AdminFoodItemMain();
            this.Hide();
            adminFoodItemMain.Show();
        }
    }
}
