using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testPratico
{
    public partial class Form1 : Form
    {
        List<Dispositivo> list = new List<Dispositivo>();
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Cellulare");
            comboBox1.Items.Add("Tv");

            textBoxRam.Hide();
            textBoxCapienza.Hide();
            textBoxPollici.Hide();
            labelRam.Hide();
            labelCapienza.Hide();
            labelPollici.Hide();

                
            /*
            Cellulare dispositivo1 = new Cellulare(1234, "samsung", 2, 256);
            list.Add(dispositivo1);
            Tv dispositivo2 = new Tv(1523, "lg", 55);
            list.Add(dispositivo2);
            textBox1.Text = list[0].ToString() + list[1].ToString();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBoxRam.Show();
                textBoxCapienza.Show();
                textBoxPollici.Hide();
                labelPollici.Hide();
                labelRam.Show();
                labelCapienza.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBoxPollici.Show();
                textBoxCapienza.Hide();
                textBoxRam.Hide();
                labelRam.Hide();
                labelCapienza.Hide();
                labelPollici.Show();
            }
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Cellulare cellulare = new Cellulare(int.Parse(textBoxNumser.Text), textBoxModello.Text, float.Parse(textBoxRam.Text), float.Parse(textBoxCapienza.Text));
                listView1.Items.Add(cellulare.ToString());
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Tv tv = new Tv(int.Parse(textBoxNumser.Text), textBoxModello.Text, int.Parse(textBoxPollici.Text));
                listView1.Items.Add(tv.ToString());
            }
            textBoxRam.Text = null;
            textBoxCapienza.Text = null;
            textBoxPollici.Text = null;
            textBoxModello.Text = null;
            textBoxNumser.Text = null;
        }
    }
}
