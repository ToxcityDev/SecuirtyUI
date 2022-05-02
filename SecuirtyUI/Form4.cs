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

    public partial class Form4 : Form
    {



        public Form4()
        {
            InitializeComponent();
        }
        List<Reports> reps = new List<Reports>();



        int reportsin = 0;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)


        {
            String where = this.textBox2.Text;
            String who = this.textBox3.Text;
            String explain = this.textBox1.Text;

            String whole = "A security guard has been detected in " + where + ". The security has been described as " + who + "." + "Explaination: " + explain;
            reps.Add(new Reports());
            reps[reportsin].Who = who;
            reps[reportsin].Where = where;
            reps[reportsin].Explanation = explain;
            reportsin++;

            foreach (Reports re in reps)
            {
              
                string dir = @"C:\Reports";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                string path = @"C:\Reports\" + getDate() + ".txt";

                
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine(whole);
    }


        }







                System.Windows.Forms.MessageBox.Show("Report: " + whole);

                this.Hide();
                Form1 frm = new Form1();
                frm.Show();

            }
        
        public String getDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") ;
        }
        
        
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
     
        
        
    }
}
