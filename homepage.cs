using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Leadersoftware
{
    public partial class Home : Form
    {
        List<double> movingdata = new List<double>();
        List<string> stringmoveing = new List<string>();
        public Home()
        {
            InitializeComponent();
            inputP1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputP1.Show();
            thisgrid11.cleardatagride();
            thisgrid11.Hide();
        }



        private void Home_Load(object sender, EventArgs e)
        {
            
            thisgrid11.Hide();
        }

        private void inputPage1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputP1.Hide();
        }

        private void displaynum_Click(object sender, EventArgs e)
        {
           int k;
           k = inputP1.datamoving();
            if (k == 1)
            {
                actionmovingtoDisplay();
                strmoving();
                thisgrid11.Show();
                thisgrid11.push();
            }

            
        }
        public void actionmovingtoDisplay() //sending data
        {
            thisgrid11.recvingdata = sendingtoDisplay;
        }
        public List<double> sendingtoDisplay
        {
            get { return movingdata; }

        }
        public void strmoving()
        {
            thisgrid11.strdata = namedatamoving;
        }
        public List<string> namedatamoving
        {
            get { return stringmoveing; }
        }


        private void thisgrid1_Load(object sender, EventArgs e)
        {

        }
        public List<double> inputcontrol // Receving Data form input page
        {
            set { movingdata = value; }
        }

        public List<string> inputcontrol2
        {
            set { stringmoveing = value; }
        }
        //
        private void thisgrid11_Load(object sender, EventArgs e)
        {

        }

        private void inputP1_Load(object sender, EventArgs e)
        {

        }

        private void thisgrid11_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thisgrid11_Load_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
