using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Tuşu Çalışıyor");


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esc Tuşu Çalışıyor");
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if (this.ControlBox == true)
                this.ControlBox = false;
            else
                this.ControlBox = true;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form2 form2 =new Form2();

            form2.Show();

        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog();
        }
    }
}
