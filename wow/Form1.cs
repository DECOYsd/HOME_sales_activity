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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         double totalSales_Daniela = 0;
         double totalSales_Edward = 0;
         double totalSales_Fatima = 0;


        private double getSalesPerson_Amount(string salesInitial, double salesAmount)
        {
            if (salesInitial == "D")
            {
                totalSales_Daniela += salesAmount;
                return totalSales_Daniela;
            }
            else if (salesInitial == "E")
            {
                totalSales_Edward += salesAmount;
                return totalSales_Edward;
            }
            else if (salesInitial == "F")
            {
                totalSales_Fatima += salesAmount;
                return totalSales_Fatima;
            }
            else
            {
                return 0;
            }
        }

        private void clearEntry()
        {
            textBox_Initial.Text = "";
            textBox_AmountOfSale.Text = "";
            label_ResultS.Text = "";
        }



        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string salesInitial = textBox_Initial.Text;
            double salesAmount = Convert.ToDouble(textBox_AmountOfSale.Text);

            double amount = getSalesPerson_Amount(salesInitial, salesAmount);
            label_ResultS.Text = "Updated " + salesInitial + " to " + amount + ".";
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            string print = "";
            print += "Daniela: " + totalSales_Daniela + "\n";
            print += "Edward: " + totalSales_Edward + "\n";
            print += "Fatima: " + totalSales_Fatima + "\n\n";
            print += "Total: " + (totalSales_Daniela + totalSales_Edward + totalSales_Fatima);

            label_ResultS.Text = print;
        }   
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
