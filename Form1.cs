using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineNew
{
    public partial class Form1 : Form
    {

        double movement = 2;
        
        Control item;
        Point itemPosition;
        private static readonly Coin[] COINS = {
            Coin.NICKEL, Coin.DIME, Coin.QUARTER, Coin.DOLLAR, Coin.FIVE_DOLLAR };
        VendingMachine machine;
        List<Product> products;
        List<string> productsRows = new List<string>();
        List<double> productsPrice = new List<double>();
        List<int> productsCount = new List<int>();

        public Form1()
        {
            InitializeComponent();
            Run();
        }

        private void Choice(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Product p = products.Find(i => i.Row == b.Text); //Predicate
            
            
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && b.Text == x.Name && p.Price <= VendingMachine.currentCoins.GetValue())
                {
                    item = x;
                    itemPosition = item.Location;
                    double change = VendingMachine.BuyProduct(p);
                    label2.Text = "Change: " + change.ToString("C");
                    UpdateText();
                    timer.Start();                                                                           
                }
                else if (x is PictureBox && b.Text == x.Name)
                {
                    UpdateText(p.Price);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            item.Top += (int) movement;
            movement += 0.5;
            item.BringToFront();
            pictureBox8.BringToFront();
            label2.BringToFront();

            if (item.Top > pictureBox8.Top)
            {
                timer.Stop();
                
                item.Location = itemPosition;
                movement = 2;
            }
        }
        private void Run()
        {
            products = new List<Product>();
            string[] fields;

            FileStream inFile = new FileStream("FirstProducts.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recordIn = reader.ReadLine();
            while (recordIn != null)
            {
                fields = recordIn.Split(',');
                products.Add(new Product(fields[0], Convert.ToDouble(fields[1]), Convert.ToInt32(fields[2])));
                productsRows.Add(fields[0]);
                productsPrice.Add(Convert.ToDouble(fields[1]));
                productsCount.Add(Convert.ToInt32(fields[2]));
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();

            ShowInitialProducts(products);
        }
        private void ShowInitialProducts(List<Product> products)
        {
            foreach (Product p in products)
            {
                if (p.Count == 1)
                {
                    foreach (Control x in this.Controls)
                    {
                        if (x is PictureBox && x.Name == p.Row)
                        {
                            x.Visible = true;
                        }
                    }
                }
                else if (p.Count > 1)
                {
                    foreach (Control x in this.Controls)
                    {
                        if (x is PictureBox && (x.Name == p.Row || x.Name == "still" + p.Row))
                        {
                            x.Visible = true;
                        }

                    }
                }               
            }
            machine = new VendingMachine(products);
        }
        /*
         * Insert coin method and displays the total
         */
        private void PickCoin(object sender, EventArgs e)
        {
            if ((string)listBox1.SelectedItem == "Nickel")
            {
                machine.AddCoin(COINS[0]);
            }
            if ((string)listBox1.SelectedItem == "Dime")
            {
                machine.AddCoin(COINS[1]);
            }
            if ((string)listBox1.SelectedItem == "Quarter")
            {
                machine.AddCoin(COINS[2]);
            }
            if ((string)listBox1.SelectedItem == "Dollar")
            {
                machine.AddCoin(COINS[3]);
            }
            if ((string)listBox1.SelectedItem == "Five Dollars")
            {
                machine.AddCoin(COINS[4]);
            }
            UpdateText();
        }
        private void UpdateText(double price = 0)
        {
            label1.Text = "Price: " + price.ToString("C") + "\nCash: " + VendingMachine.currentCoins.GetValue().ToString("C");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                this.Close();
            }
        }

        private void CancelTransactionButton_Click(object sender, EventArgs e)
        {
            double money = machine.CancelTransaction();
            UpdateText(0);
            label2.Text = "Money Returned: " + money.ToString("C");
        }
        /* 
*Assign each machine code (ex. 
private void Operator(object sender, EventArgs e)
{
const string DELIM = ",";
FileStream outFile = new FileStream("FirstProducts.txt", 
FileMode.Create, FileAccess.Write);
StreamWriter writer = new StreamWriter(outFile);
Button b = (Button)sender;
bool enableOp = false;
if (b.text == "F3")
{
enableOp = true;
}
writer.Close();
outFile.Close();
}
*/

    }
}
