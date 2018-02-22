using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBilet
    
{
    
    public partial class Arif216cs : Form
    {
        int quantize = 0;
        double price = 0.0;
        int quantize2 = 0;
        double price2 = 0.0;
        double kolaFiyat = 0.0;
        double suFiyat = 0.0;
        double ayranFiyat = 0.0;
        double mısırFiyat = 0.0;
        double hesap = 0.0;





        public Arif216cs()

        {
           
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            quantize++;
            price += 8.50;

            textBox1.Text = quantize.ToString();
            textBox2.Text = price.ToString();

            if(quantize == 20)
            {
                button1.Enabled = false;
                MessageBox.Show("Salon Dolmuştur! ", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Hand);

            }

        }

        private void Arif216cs_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button9.Enabled = false;
            button11.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            quantize--;
            price -= 8.50;
            textBox1.Text = quantize.ToString();
            textBox2.Text = price.ToString();


            if(quantize == 0)
            {
                button2.Enabled = false;
                MessageBox.Show("Sıfırlandı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            quantize2++;
            price2 += 8.50;

            textBox4.Text = quantize2.ToString();
            textBox3.Text = price2.ToString();

            if (quantize2 == 20)
            {
                button4.Enabled = false;
                MessageBox.Show("Salon Dolmuştur! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            quantize2--;
            price2 -= 8.50;
            textBox4.Text = quantize2.ToString();
            textBox3.Text = price2.ToString();


            if (quantize2 == 0)
            {
                button3.Enabled = false;
                MessageBox.Show("Sıfırlandı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            kolaFiyat -= 2.5;
            textBox5.Text = kolaFiyat.ToString();
            if(kolaFiyat == 0.0)
            {
                button6.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kolaFiyat+=2.50;
            button6.Enabled = true;
            textBox5.Text = kolaFiyat.ToString();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            ayranFiyat += 1.5;
            button7.Enabled = true;
            textBox6.Text = ayranFiyat.ToString();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ayranFiyat -= 1.5;
            textBox6.Text = ayranFiyat.ToString();
            if(ayranFiyat == 0.0)
            {
                button7.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            suFiyat += 1;
            button9.Enabled = true;
            textBox7.Text = suFiyat.ToString();        }

        private void button9_Click(object sender, EventArgs e)
        {
            suFiyat -= 1;
            textBox7.Text = suFiyat.ToString();
            if(suFiyat == 0)
            {
                button9.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mısırFiyat += 6.5;
            button11.Enabled = true;
            textBox8.Text = mısırFiyat.ToString();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mısırFiyat -= 6.5;
            textBox8.Text = mısırFiyat.ToString();
            if(mısırFiyat == 0.0)
            {
                button11.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hesap = price + price2+kolaFiyat+suFiyat+ayranFiyat+mısırFiyat;
            label12.Text = hesap.ToString();
        }
    }
}
