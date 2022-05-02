namespace SecuirtyUI
{
    
    public partial class Form1 : Form
    {
        
       






        public Form1()
        {
            InitializeComponent();
        }
        
        int clicks = 0;
        List<string> users = new List<string>();
        Reports reps1 = new Reports();

        Form4 form4 = new Form4();
        private void label1_Click(object sender, EventArgs e)
        {

            
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicks++;
            label1.Text = Convert.ToString(clicks);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        int r = 255, g = 0, b = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label7.Text == "Logged in as: System Administrator")
            {
                Close();

            }
            else
            {
                this.Hide();

                //form.Show();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void iconButton3_Click(object sender, EventArgs e)
        {
            //Spit out data into Dialog Box

            System.Windows.Forms.MessageBox.Show(reps1.getData());
         
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form4.Show();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
           

            this.label2.ForeColor = Color.FromArgb(r, g, b);

            if (r>0 && b == 0 )
            {
                r-=3;
                g+=3;
            }
            if (g> 0 && r == 0)
            {
                g-=3;
                b+=3;
            }
            if (b > 0 && g == 0)
            {
                b-=3;
                r+=3;
            }

        }
        
    }
}