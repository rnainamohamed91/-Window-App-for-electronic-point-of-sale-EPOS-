using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        string[] bagel = new string[]{"Halloumi",	"Bangkok",	"Chicken Philly",	"Classic Club",	"Kiltimagh Special ",	"Veggie",	"Ploughmans",	"Mexicana",	"Triple Cheese",	"Atlantic Way",	"Breakfast",	"Maui",	"Classic",	"Chicken Caeser",	"Student Surprise",	"Cajun",};


        string[] size = new string[] { "Small", "Medium", "Regular", "Large", "Extra Large" };


        decimal[,] price = {   {3.45m,	3.50m,	3.55m,	3.38m,	6.83m,	3.4m,	4.49m,	4.05m,	5.5m,	8.5m,	4.25m,	4.5m,  5.36m,   6.0m,   3.23m,	4.45m},
                               {2.95m,	3.0m,	3.05m,	2.99m,	5.69m,	2.9m,	3.99m,	3.12m,	4.49m,	8.89m,	3.75m,	3.97m,	5.0m,	5.5m,	2.23m,	3.95m},
                               {3.45m,	3.5m,	3.55m,	3.38m,	6.83m,	3.4m,	4.49m,	4.05m,	5.5m,	8.5m,	4.25m,	4.5m,	5.36m,	6.0m,	3.23m,	4.45m},
                               {3.99m,	3.99m,	4.0m,	3.99m,	6.99m,	3.59m,	4.99m,	4.49m,	6.51m,	8.11m,	4.75m,	5.03m,	5.72m,	6.5m,	4.23m,	4.95m},
                               {4.53m,	4.48m,	4.45m,	4.6m,	9.99m,	3.78m,	5.49m,	4.93m,	7.52m,	7.72m,	5.25m,	5.56m,	6.08m,	7.0m,	5.23m,	5.45m}};
    
        int[,] stock = { 
                       {2,	4,	6,	8,	12,	12,	8,	4,	0,	3,	6,	9,	12,	10,	55,	6},
                       {3,	4,	5,	6,	45,	8,	5,	2,	7,	8,	9,	10,	11,	7,	3,	5},
                       {4,	7,	10,	13,	34,	19,	12,	5,	4,	6,	8,	10,	12,	8,	4,	0},
                       {5,	13,	11,	12,	23,	12,	4,	7,	10,	8,	6,	4,	21,	4,	6,	8},
                       {6,	2,	0,	2,	4,	6,	3,	4,	5,	6,	7,	8,	9,	6,	23,	8}};

        int bagelIndex, sizeIndex;
        decimal totalPrice;
        decimal collectivePrice;
        int quantity;
        bool   count = true;


       string receipt;
       string totalRciept;

       int totalNoTrans;
       decimal totalSaleValue;
       int totalBagel;

        int[,] tempStock = new int[5,16];
        int[,] formatedStock = new int[5,16];
        

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
             
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

     //add button picks the value from the array and writes to the grid box

        private void addButton_Click(object sender, EventArgs e)
        {
            bagelIndex = bagelListBox.SelectedIndex;
            sizeIndex = sizeListBox.SelectedIndex;
            
            if (int.TryParse(quantiryNumericUpDown.Text, out quantity) && quantity!= 0)
            {



                try
                {

                    if (count)
                    {
                        // Clone the value only the first time 
                        tempStock = stock.Clone() as int[,];

                    }

                    if (quantity <= tempStock[sizeIndex, bagelIndex] )
                    {

                        collectivePrice = (price[sizeIndex, bagelIndex] * quantity);

                        dataGridView1.Rows.Add(bagel[bagelIndex], size[sizeIndex], quantiryNumericUpDown.Text, price[sizeIndex, bagelIndex], collectivePrice);

                        //stock[sizeIndex, bagelIndex] -= quantity;
                        tempStock[sizeIndex, bagelIndex] -= quantity;

                        count = false; // clone is stopped by the flag

                       
                        bagelListBox.SelectedIndex = -1;
                        sizeListBox.SelectedIndex = -1;
                        quantiryNumericUpDown.Text = "0";

                    }
                    else
                    {
                        MessageBox.Show("There is only " + tempStock[sizeIndex, bagelIndex] + " available");
                        quantiryNumericUpDown.Focus();
                        
                        quantiryNumericUpDown.Text = tempStock[sizeIndex, bagelIndex].ToString();

                    }
                    
                }
                catch { }

            }
            else
            {
                MessageBox.Show("Please enter the valid input");
            }
            proceedButton.Enabled = true;
            
      }
        //clears and ready for the new transaction
        private void clearButton_Click(object sender, EventArgs e)
        {
            bagelListBox.Text = "";
            sizeListBox.Text = "";
            quantiryNumericUpDown.Text = "";
            dataGridView1.Rows.Clear();
            mealTabPage.Visible = true;          
            bagelListBox.Focus();
            deleteItem.Enabled = true;
            panel1.Visible = true;
            totalPriceLabel.Text = "";
            panel2.Visible = false;
        }

      
        // complete the traction and clone the tempstock to the formated stock
        private void compelteOrderButton_Click(object sender, EventArgs e)
        {
           

            int dgvRowIndex = dataGridView1.RowCount;
          
            try
            {

                
                for (int i = 0; i < dgvRowIndex -1; i++)
                {

                    var myTransactionId = DateTime.Now.ToString("yyyyMMddhhmmss");
                   receipt += ("transaction ID: " + myTransactionId + " Bagle: " + dataGridView1.Rows[i].Cells[0].Value.ToString() + " size: " + dataGridView1.Rows[i].Cells[1].Value.ToString() + " Quantiy: " + dataGridView1.Rows[i].Cells[2].Value.ToString() + " Individual Price :" + dataGridView1.Rows[i].Cells[3].Value.ToString() + " Collective price :" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "\n").ToString();
                    totalRciept += (receipt + "\n");

                    totalBagel += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    
                   // transcount += 1;

                   // myTransactionId = "0";
                    
                }
                MessageBox.Show("Order sucessfull \n" + receipt);
              }
            catch { }

            //totalBagel += (dataGridView1.RowCount - 1);
            totalNoTrans += 1; //for summeary
            compelteOrderButton.Enabled = false;
            totalSaleValue += totalPrice;
            newButton.Enabled = true;
            

            formatedStock = tempStock.Clone() as int[,];  // clone for the live stock
            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string line ="";
           // 2,4,6,8,12,12,8,4,0,3,6,9,12,10,55,6
            //StreamReader lin = new StreamReader("BagelStock.txt");

            //String[] lineTokens = line.Split(',');

           // tempStock = new int[size.Length, bagel.Length];
            
            

            /*StreamWriter sw = new StreamWriter("stock.txt");

            for (int k = 0; k < 5; k++)
            {
                for (int l = 0; l < 16; l++)
                {
                    sw.Write(stock[k, l] + " ");
                }
                sw.WriteLine("\n");
            }
            sw.Flush();
            sw.Close();*/

            try
            {
                //read the stock form the formated stock
                String input = File.ReadAllText("formatedStock.txt");

                int i = 0, j = 0;

                foreach (var row in input.Split('\n'))
                {
                    j = 0;
                    foreach (var col in row.Trim().Split(','))
                    {
                        stock[i, j] = int.Parse(col.Trim());
                        j++;
                    }
                    i++;
                }
                //read the price from the text file
                String loadPrice = File.ReadAllText("prices.txt");

                int k = 0, l = 0;

                foreach (var row in input.Split('\n'))
                {
                    l = 0;
                    foreach (var col in row.Trim().Split(','))
                    {
                        price[k, l] = int.Parse(col.Trim());
                        j++;
                    }
                    i++;
                }
                
                
            }
            catch { }

            panel2.Visible = false;
            proceedButton.Enabled = false;
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {

            DialogResult exit = MessageBox.Show("ARE YOU SURE YOU WANT TO EXIT(THIS END THE TRANSACTION FOR THE DAY)", "WARNING", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                try
                {
                // formatedStock = tempStock.Clone() as int[,];

              //write the formated stock to file so it can load the for the next day
                StreamWriter FS = new StreamWriter("formatedStock.txt");
                   
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        if (j != 15)

                            FS.Write(formatedStock[i, j] + ",");
                        if (j == 15)
                            FS.Write(formatedStock[i, j]);
                    }
                    FS.WriteLine();
                }

                FS.Close();
              // summary Transaction 
                    var myUniqueFileName = string.Format(@"{0}.txt", DateTime.Now.Ticks);
                    StreamWriter TR;
                    TR = File.CreateText(myUniqueFileName);
                    TR.WriteLine("*******************Transaction for the day******************");
                    TR.WriteLine("*******************MR BAGEL*********************************");
                    TR.WriteLine(totalRciept + "\n");
                    TR.Flush();
                    TR.Close();

                }
                catch { }
                this.Close();
            }
            else if (exit == DialogResult.No) 
            {
                bagelListBox.Text = "";
                sizeListBox.Text = "";
                quantiryNumericUpDown.Text = "";
                dataGridView1.Rows.Clear();
                mealTabPage.Visible = true;
                // completeTabPage.Visible = false;
                bagelListBox.Focus();
                receipt = "";
                compelteOrderButton.Enabled = true;
                totalPriceLabel.Text = "";
                deleteItem.Enabled = true;

                panel1.Visible = true;
                proceedButton.Enabled = true;
                totalPrice = 0;
                panel2.Visible = false;
            }
             
        }

        private void summary_Button_Click(object sender, EventArgs e)
        {
            summaryTabPage.Visible = true;
           
            try
            {
                totalBagelLabel.Text = totalBagel.ToString();
                totalSaleValueLabel.Text = totalSaleValue.ToString();
                totalNoTransLable.Text = totalNoTrans.ToString();
                decimal average = (totalSaleValue / totalNoTrans);
                averageLable.Text = average.ToString();
            }
            catch { }

        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                // delete the row and add the quantity back to the Tempstock

                int rowindex = dataGridView1.CurrentCell.RowIndex;
                                
                tempStock[sizeIndex, bagelIndex] += Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[2].Value.ToString());
                dataGridView1.Rows.RemoveAt(rowindex);
               
            }
            catch { }
        }
        // for new Order
        private void newButton_Click(object sender, EventArgs e)
        {
            bagelListBox.Text = "";
            sizeListBox.Text = "";
            quantiryNumericUpDown.Text = "";
            dataGridView1.Rows.Clear();
            mealTabPage.Visible = true;
           
            bagelListBox.Focus();
            receipt = "";
            compelteOrderButton.Enabled = true;
            totalPriceLabel.Text = "";
            deleteItem.Enabled = true;

            panel1.Visible = true;
            proceedButton.Enabled = true;
            totalPrice = 0;
            panel2.Visible = false;
        }

        

        private void proceedButton_Click(object sender, EventArgs e)
        {
            try
            {
                //add the all the collective values
                for (int i = 0; i <dataGridView1.RowCount -1; i++)
                {
                    totalPrice += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }

                totalPriceLabel.Text = totalPrice.ToString();
                
            }
            catch { }
            panel1.Visible = false;
            panel2.Visible = true;
            proceedButton.Enabled = false;
            newButton.Enabled = false;
            deleteItem.Enabled = false;

        }

        private void sizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mealTabPage.Visible = true;
            summaryTabPage.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bagelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            proceedButton.Enabled = false;
        }

        private void managementButton_Click(object sender, EventArgs e)
        {
            summaryTabPage.Visible = true;
            mealTabPage.Visible = false;

        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            summaryTabPage.Visible = false;
            mealTabPage.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
 
    }
}
 