using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3_VeriYapiları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listBoxTemizle() {
            listBox1.Items.Clear();
        }        
        liste liste = new liste();        
        private void Form1_Load(object sender, EventArgs e)
        {
            liste.maxDeger = Convert.ToInt32(numericUpDown1.Value.ToString());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            liste.maxDeger = Convert.ToInt32(numericUpDown1.Value.ToString());
            listBoxTemizle();
            liste.push(textBox1.Text);
            liste.listBoxaEkle(listBox1);
            labelStackSize.Text = liste.size().ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {        
            listBoxTemizle();
            liste.pop();
            textBox2.Text = liste.sonsilinen;
            liste.listBoxaEkle(listBox1);
            labelStackSize.Text = liste.size().ToString();
        }
    }
    
}
