using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecuirtyUI
{
    public partial class Form2 : Form
    {
        Form1 form = new Form1();
        Label label7 = new Label();
        public string username { get; set; }
        public string password { get; set; }

        public Form2()
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (txtusername.Text == "user" && txtpassword.Text == "pass")
            {
                this.Hide();
                
                form.Show();

               // ((Label)form.Controls["label7"]).Text = "Logged in as: Member";

            }
            if (txtusername.Text == "jasiah" && txtpassword.Text == "metalfusion")
            {
                this.Hide();

                form.Show();
                
                // ((Label)form.Controls["label7"]).Text = "Logged in as: System Administrator";


            }
            if (txtusername.Text == "guest" && txtpassword.Text == "")
            {
                this.Hide();

                form.Show();
                // ((Label)form.Controls["label7"]).Text = "Logged in as: Guest";
                
            }


            else
            {
                label3.Show();
                
            }

            }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

