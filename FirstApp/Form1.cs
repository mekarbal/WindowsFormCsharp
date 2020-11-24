using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace FirstApp
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        bool valideEmail = false;
        bool validtel = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider2.SetError(this.textBox2, "just numbers please");
                validtel=false;
            }
            else
            {
                validtel = true;
                errorProvider2.Clear();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            isValidEmail(textBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public bool isValidEmail(string email)
        {
            Regex check = new Regex(@"^\w+[\w-.]+@\w{5}.[a-z]{2,3}$");
            
            valideEmail = check.IsMatch(email);
            if (valideEmail == true)
            {
                errorProvider1.Clear();
                return true;
            }
            else
            {
                errorProvider1.SetError(this.textBox4, "please provide valid email address");
                return false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


            if (comboBox1.Text == "Maroc")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Casablanca");
                comboBox2.Items.Add("Safi");
                comboBox2.Items.Add("Eljadda");
                comboBox2.Items.Add("Tanger");
                comboBox2.Items.Add("Fés");
                comboBox2.Items.Add("Meknes");
            
            }
            else if (comboBox1.Text == "Canada")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Quebec");
            }
            else if (comboBox1.Text == "allemand")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Berlin");
            }
            else if (comboBox1.Text == "France")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Paris");
                comboBox2.Items.Add("Lyon");
                comboBox2.Items.Add("Toulouse");
            }
            

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

         





        }
    }
}
