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
                list.Add(cellulare);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Tv tv = new Tv(int.Parse(textBoxNumser.Text), textBoxModello.Text, int.Parse(textBoxPollici.Text));
                listView1.Items.Add(tv.ToString());
                list.Add(tv);
            }
            textBoxRam.Text = null;
            textBoxCapienza.Text = null;
            textBoxPollici.Text = null;
            textBoxModello.Text = null;
            textBoxNumser.Text = null;
        }


        private void buttonSort_Click(object sender, EventArgs e)
        {
            list.Sort();
            listView1.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                listView1.Items.Add(list[i].ToString());
            }
        }

        private void buttonIndexOf_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Cellulare cellulare = new Cellulare(int.Parse(textBoxNumser.Text), textBoxModello.Text, float.Parse(textBoxRam.Text), float.Parse(textBoxCapienza.Text));
                MessageBox.Show("Posizione: " + Convert.ToString(list.IndexOf(cellulare)));
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Tv tv = new Tv(int.Parse(textBoxNumser.Text), textBoxModello.Text, int.Parse(textBoxPollici.Text));
                MessageBox.Show("Posizione: " + Convert.ToString(list.IndexOf(tv)));
            }

        }
    }
}
