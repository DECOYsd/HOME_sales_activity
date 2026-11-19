using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wow
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(double d, double e , double f) {
            InitializeComponent();

            label_Danielle.Text = "Danielle Total sales:  $" + d;
            label_Edward.Text = "Edward Total sales:  $" + e;
            label_Fatima.Text = "Fatima Total sales:  $" + f;

            label_Total.Text = "Total Sales: $" + (d + e + f);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
