using System;
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
            string name = salesInitial == "D" ? "Danielle" : (salesInitial == "E" ? "Edward" : "Fatima");
            label_ResultS.Text = $"${salesAmount} in sales has been successfully recorded for {name}.\nBringing his/her total sales to ${amount}.";
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            Form2 summary = new Form2(totalSales_Daniela, totalSales_Edward, totalSales_Fatima);
            summary.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
