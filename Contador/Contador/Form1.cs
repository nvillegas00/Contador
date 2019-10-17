using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador
{
    public partial class Form1 : Form
    {
        public int nro;
        public Form1()
        {
            InitializeComponent();
            txtAumento.Text = "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            nro++;
            txtAumento.Text = nro.ToString();
        }
    }
}
