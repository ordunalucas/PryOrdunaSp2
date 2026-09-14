using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryOrdunaSp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBox.Items.Add("Basico");
            cmbBox.Items.Add("Estandar");
            cmbBox.Items.Add("Premium");
        }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
