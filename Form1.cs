using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateLabel.Text=DateTime.Now.ToLongDateString();
            timer1.Start();
            label17.Text = DateTime.Now.ToLongDateString(); 
        }

        private void pekingDuckCB_CheckedChanged(object sender, EventArgs e)
        {
            if (pekingDuckCB.Checked == true)
            {
                pekingDuckTB.Enabled = true;
            }
            else
            {
                
                    pekingDuckTB.Enabled = false;
                    pekingDuckTB.Text = "0";
                
            }
        }

        private void xiaolongbaoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (xiaolongbaoCB.Checked == true)
            {
                xiaolongbaoTB.Enabled = true;
            }
            else
            {

                xiaolongbaoTB.Enabled = false;
                xiaolongbaoTB.Text = "0";

            }
        }

        private void kebabCB_CheckedChanged(object sender, EventArgs e)
        {
            if (kebabCB.Checked == true)
            {
                kebabTB.Enabled = true;
            }
            else
            {

                kebabTB.Enabled = false;
                kebabTB.Text = "0";

            }

        }

        private void shawarmaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (shawarmaCB.Checked == true)
            {
                shawarmaTB.Enabled = true;
            }
            else
            {

                shawarmaTB.Enabled = false;
                shawarmaTB.Text = "0";

            }
        }

        private void chickenAdoboCB_CheckedChanged(object sender, EventArgs e)
        {
            if (chickenAdoboCB.Checked == true)
            {
                chickenAdoboTB.Enabled = true;
            }
            else
            {

                chickenAdoboTB.Enabled = false;
                chickenAdoboTB.Text = "0";

            }
        }

        private void filipinoSpringRollCB_CheckedChanged(object sender, EventArgs e)
        {
            if (filipinoSpringRollCB.Checked == true)
            {
                filipinoSpringRollTB.Enabled = true;
            }
            else
            {

                filipinoSpringRollTB.Enabled = false;
                filipinoSpringRollTB.Text = "0";

            }
        }

        private void mangoSagoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (mangoSagoCB.Checked == true)
            {
                mangoSagoTB.Enabled = true;
            }
            else
            {

                mangoSagoTB.Enabled = false;
                mangoSagoTB.Text = "0";

            }
        }

        private void baklavaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (baklavaCB.Checked == true)
            {
                baklavaTB.Enabled = true;
            }
            else
            {

                baklavaTB.Enabled = false;
                baklavaTB.Text = "0";

            }
        }

        private void halohaloCB_CheckedChanged(object sender, EventArgs e)
        {
            if (halohaloCB.Checked == true)
            {
                halohaloTB.Enabled = true;
            }
            else
            {

                halohaloTB.Enabled = false;
                halohaloTB.Text = "0";

            }
        }

        private void sodaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (sodaCB.Checked == true)
            {
                sodaTB.Enabled = true;
            }
            else
            {

                sodaTB.Enabled = false;
                sodaTB.Text = "0";

            }
        }

        private void specialIcedTeaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (specialIcedTeaCB.Checked == true)
            {
                specialIcedTeaTB.Enabled = true;
            }
            else
            {

                specialIcedTeaTB.Enabled = false;
                specialIcedTeaTB.Text = "0";

            }
        }

        private void bottledWaterCB_CheckedChanged(object sender, EventArgs e)
        {
            if (bottledWaterCB.Checked == true)
            {
                bottledWaterTB.Enabled = true;
            }
            else
            {

                bottledWaterTB.Enabled = false;
                bottledWaterTB.Text = "0";

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
        
        //unit price of each item
        double pekingDuckUnitPrice = 16.56, xiaolongbaoUnitPrice =12.00, 
            kebabUnitPrice=14.00,shawarmaUnitPrice = 11.26, 
            chickenAdoboUnitPrice=15.50, filipinoSpringRollUnitPrice = 10.58, mangoSagoUnitPrice = 8.53,
            baklavaUnitPrice = 8.51, halohaloUnitPrice = 10.5, sodaUnitPrice = 2.52, 
            specialIcedTeaUnitPrice = 2.56, bottledWatedUnitPrice = 1.59;

        private void label17_Click(object sender, EventArgs e)
        {
           
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receiptTB + "Subtotal: " + subTotal.Text + "Tax: " + tax.Text + "Grand total" + total.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Blue,new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chickenAdoboTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void baklavaTB_TextChanged(object sender, EventArgs e)
        {

        }


        //total price for each item
        double pekingDuckTP, xiaolongbaoTP, kebabTP, shawarmaTP, chickenAdoboTP, filipinoSpringRollTP,
            mangoSagoTP, baklavaTP, halohaloTP, sodaTP, specialIcedTeaTP, bottledWatedTP;
       

        private void button2_Click(object sender, EventArgs e) 
        {
            double subtotal = 0, taxrate = .15;
            receiptTB.Clear();
            
            if (pekingDuckTB.Text == "") pekingDuckTB.Text = "0";
            if (xiaolongbaoTB.Text == "") xiaolongbaoTB.Text = "0";
            if (kebabTB.Text == "") kebabTB.Text = "0";
            if (shawarmaTB.Text == "") shawarmaTB.Text = "0";
            if (chickenAdoboTB.Text == "") chickenAdoboTB.Text = "0";
            if (filipinoSpringRollTB.Text == "") filipinoSpringRollTB.Text = "0";
            if (mangoSagoTB.Text == "") mangoSagoTB.Text = "0";
            if (baklavaTB.Text == "") baklavaTB.Text = "0";
            if (halohaloTB.Text == "") halohaloTB.Text = "0";
            if (sodaTB.Text == "") sodaTB.Text = "0";
            if (specialIcedTeaTB.Text == "") specialIcedTeaTB.Text = "0";
            if (bottledWaterTB.Text == "") bottledWaterTB.Text = "0";

            pekingDuckTP = pekingDuckUnitPrice * Double.Parse(pekingDuckTB.Text);
            xiaolongbaoTP = xiaolongbaoUnitPrice * Double.Parse(xiaolongbaoTB.Text);
            kebabTP=kebabUnitPrice * Double.Parse(kebabTB.Text);
            shawarmaTP=shawarmaUnitPrice * Double.Parse(shawarmaTB.Text);
            chickenAdoboTP = chickenAdoboUnitPrice * Double.Parse(chickenAdoboTB.Text);
            filipinoSpringRollTP= filipinoSpringRollUnitPrice * Double.Parse(filipinoSpringRollTB.Text);
            mangoSagoTP = mangoSagoUnitPrice * Double.Parse(mangoSagoTB.Text);
            baklavaTP=baklavaUnitPrice * Double.Parse(baklavaTB.Text);
            halohaloTP=halohaloUnitPrice * Double.Parse(halohaloTB.Text);
            sodaTP= sodaUnitPrice * Double.Parse(sodaTB.Text);
            specialIcedTeaTP= specialIcedTeaUnitPrice * Double.Parse(specialIcedTeaTB.Text);
            bottledWatedTP = bottledWatedUnitPrice * Double.Parse(bottledWaterTB.Text);
            //-----------------------------------------------------------------------------

           
            receiptTB.AppendText("\n\t\t\t\tCIM RESTAURANT\n");
            receiptTB.AppendText("\t\t\t\t     "+DateTime.UtcNow.ToString("yyyy-MM-dd")+ "\n\t\t\t\t     "+dateLabel.Text);
            receiptTB.AppendText("\n\t\t************************************************\n");

            if(pekingDuckCB.Checked == true)
            {
                receiptTB.AppendText("\t\t\tPeking Duck:\t\t" + "$" + pekingDuckTP + "\n");
                subtotal += pekingDuckTP;
                subTotal.Text = "" + Math.Round(subtotal, 2);
            }
            if (xiaolongbaoCB.Checked == true)
            {
                receiptTB.AppendText("\t\t\tXiaolongbao:\t\t" + "$" + xiaolongbaoTP + "\n");
                subtotal += xiaolongbaoTP;
                subTotal.Text = "" + Math.Round(subtotal, 2);
            }
            if (kebabCB.Checked == true)
            {
                receiptTB.AppendText("\t\t\tKebab:\t\t\t" + "$" + kebabTP + "\n");
                subtotal += kebabTP;
                subTotal.Text = "" + Math.Round(subtotal, 2);
            }
            if (shawarmaCB.Checked == true)
            {
                receiptTB.AppendText("\t\t\tShawarma:\t\t" + "$" + shawarmaTP + "\n");
                subtotal += shawarmaTP;
                subTotal.Text = "" + Math.Round(subtotal, 2);
            }
            if (chickenAdoboCB.Checked == true)
            {
                receiptTB.AppendText("\t\t\tChicken Adobo:\t" + "$" + chickenAdoboTP + "\n");
                subtotal += chickenAdoboTP;
                subTotal.Text = "" + Math.Round(subtotal, 2);
            }
            if (filipinoSpringRollCB.Checked == true)
            {
                receiptTB.AppendText("\t\t\tFil Spr Roll:\t\t" + "$" + filipinoSpringRollTP + "\n");
                subtotal += filipinoSpringRollTP;
                subTotal.Text = "" + Math.Round(subtotal, 2);
            }
            if (mangoSagoCB.Checked == true)
            {
                receiptTB.AppendText("\t\t\tMango Sago:\t\t" + "$" + mangoSagoTP + "\n");
                subtotal = subtotal+mangoSagoTP;
                subTotal.Text = "" + Math.Round(subtotal, 2);
            }
            if (baklavaCB.Checked == true)
            {
                receiptTB.AppendText("\t\t\tBaklava:\t\t" + "$" + baklavaTP + "\n");
                subtotal = subtotal + baklavaTP;
                subTotal.Text = "" + Math.Round(subtotal, 2);
            }
            if (halohaloCB.Checked == true)
            {
                receiptTB.AppendText("\t\t\tHalo Halo:\t\t" + "$" + halohaloTP + "\n");
                subtotal = subtotal + halohaloTP;
                subTotal.Text = "" + Math.Round(subtotal, 2);
            }
            if (sodaCB.Checked == true)
            {
                receiptTB.AppendText("\t\t\tSoda:\t\t\t" + "$" + sodaTP + "\n");
                subtotal = subtotal + sodaTP;
                subTotal.Text = "" + Math.Round(subtotal, 2);
            }
            if (specialIcedTeaCB.Checked == true)
            {
                receiptTB.AppendText("\t\t\tSpcl Iced Tea:\t\t" + "$" + specialIcedTeaTP + "\n");
                subtotal = subtotal + specialIcedTeaTP;
                subTotal.Text = "" + Math.Round(subtotal, 2);
            }
            if (bottledWaterCB.Checked == true)
            {
                receiptTB.AppendText("\t\t\tBottled Water:\t\t" + "$" + bottledWatedTP + "\n");
                subtotal = subtotal + bottledWatedTP;
                subTotal.Text = "" + Math.Round(subtotal, 2);
            }
            var tax1 = Math.Round(subtotal,2) * taxrate;
            tax.Text = "" + Math.Round(tax1, 2);
            var grandTotal= Math.Round(subtotal, 2) + tax1;
            
            total.Text = ""+ Math.Round(grandTotal, 2);







        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pekingDuckCB.Checked = false;
            xiaolongbaoCB.Checked = false;
            kebabCB.Checked = false;    
            shawarmaCB.Checked = false; 
            chickenAdoboCB.Checked = false;
            filipinoSpringRollCB.Checked = false;
            mangoSagoCB.Checked = false;
            baklavaCB.Checked = false;
            halohaloCB.Checked = false;
            sodaCB.Checked = false;
            specialIcedTeaCB.Checked = false;
            bottledWaterCB.Checked = false;
        }
    }
}