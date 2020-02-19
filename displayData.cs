using System;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using LiveCharts;
using LiveCharts.Wpf;
using MetroSet_UI.Forms;
// This ths the most update file
namespace Leadersoftware
{
    public partial class thisgrid1 : UserControl
    {

        List<double> datafrominput = new List<double>();
        List<string> namedata = new List<string>();
        double[] masterInput = new double[10];
        double preT, afterThetax;


        public List<double> recvingdata
        {
            set { datafrominput = value; }

        }

        public List<String> strdata
        {
            set { namedata = value; }
        }
        public void cleardatagride()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }
        public thisgrid1()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void push()
        {
            int i;
            double clientAge1 = datafrominput[2];
            double spouceAge1 = datafrominput[17];

            // Client SS ====================================================================================
            double[] ssarray = new double[50];
            double[] ssSarray = new double[50];

            double[] cs1 = new double[50];
            double[] ss1 = new double[50];
            int cm = 0;

            ssarray = runningNumbers.ss(datafrominput[1] * 12);
            ssSarray = runningNumbers.ss(datafrominput[16] * 12);

            if (datafrominput[44] == 2) // This is a Check For the Spouce check box
            {
                i = 0;
                double holdage = datafrominput[3]; /// this need to be change
                while (spouceAge1 < holdage)// these two lines need to be fixed and tested!!!! Good Job coding this stuff Ryan :D Do what you say!!!
                {
                    cs1[i] = ssarray[i];
                    i++;
                    spouceAge1++;
                }

                int y = 0;
                while (i < 24)
                {
                    cs1[i] = ssSarray[y] / 2;
                    i++;
                    y++;

                }
                /// we will need to do a Check test to Show where the Change Starts!!!!
            }

            else
            {
                // This is a normal ss run thought 

                for (i = 0; i < 23; i++)
                {
                    if (clientAge1 >= datafrominput[3])// spot 3 clinet desier range
                    {
                        cs1[i] = ssarray[cm];
                        clientAge1 += 1;
                        cm++;
                    }
                    else
                    {
                        cs1[i] = 0;
                        clientAge1 += 1;
                    }
                }
            }
            ///==========================================================
            clientAge1 = datafrominput[2];
            spouceAge1 = datafrominput[17];

            cm = 0;
            if (datafrominput[44] == 1) // This is if the cleint box is Checked
            {
                // This is letting the spouce use there SS untll there client ss kicks in
                i = 0;
                double holdage = datafrominput[3];
                while (clientAge1 < holdage)
                {
                    ss1[i] = Math.Round(ssSarray[i],0);
                    i++;
                    clientAge1++;
                }

                int y = 0;
                while (i < 24)
                {
                    ss1[i] = Math.Round(ssarray[y] / 2,0);
                    i++;
                    y++;

                }
                /// we will need to do a Check test to Show where the Change Starts!!!!
            }
            else if (datafrominput[44] != 2 || datafrominput[44] != 1)     // this is when the client box is not checked
            {
                cm = 0;
                for (i = 0; i < 23; i++)
                {
                    if (spouceAge1 >= datafrominput[19])
                    {
                        ss1[i] = Math.Round(ssSarray[cm],0);
                        spouceAge1 += 1;
                        cm++;
                    }
                    else
                    {
                        ss1[i] = 0;
                        spouceAge1 += 1;

                    }
                }
            }
            else
            {
                for (int y = 0; y < 24; y++)
                    ss1[y] = 0;

                /// we Need to remove this From the chart 
            }

            //pention AREA =====================================================================


            clientAge1 = datafrominput[2];
            spouceAge1 = datafrominput[15];

            double[] penc = new double[24];
            double[] pens = new double[24];

            double[] clientA = new double[24];
            double[] spouceA = new double[24];

            double clientDagemove = datafrominput[2];


            for (int t = 0; t <= 23; t++)
            {       /// FIX THIS RYAN!!!!!!!!!!!!!!!!!!!!!!!!
                if (datafrominput[2] == 60) // this are for the check boxes 
                {
                    if (clientDagemove < datafrominput[9])
                    {
                        penc[t] += Math.Round(12 * datafrominput[10],0);
                    }

                }
                else if (clientDagemove >= datafrominput[9])
                    penc[t] += Math.Round(12 * datafrominput[10],0);
                else
                    penc[t] += 0;



                if (clientDagemove >= datafrominput[11])
                    penc[t] += Math.Round(12 * datafrominput[12],0);
                else
                    penc[t] += 0;
                if (clientDagemove >= datafrominput[13])
                    penc[t] += Math.Round(12 * datafrominput[14],0);
                else
                    penc[t] += 0;

                clientDagemove++;

                //Spouce 

                double spouceDagemove = datafrominput[19];

                if (datafrominput[19] == 1) // this are for the check boxes 
                {
                    if (spouceDagemove < datafrominput[25])
                    {
                        pens[t] += Math.Round(12 * datafrominput[26], 0);
                    }

                }
                else if (spouceDagemove >= datafrominput[25])
                    pens[t] += Math.Round(12 * datafrominput[10], 0);
                else
                    pens[t] += 0;

                if (spouceDagemove >= datafrominput[27])
                    pens[t] += 12 * datafrominput[28];
                if (spouceDagemove >= datafrominput[29])
                    pens[t] += 12 * datafrominput[30];
                spouceDagemove++;  
            }


            // Exsting Growth!=====================================================================

            preT = Math.Round(runningNumbers.investment(datafrominput[35], datafrominput[2] - datafrominput[0], datafrominput[5] / 100), 0);// running the pre tax
            label37.Text = preT.ToString("0.##");

            afterThetax = Math.Round(runningNumbers.investment(datafrominput[36], datafrominput[2] - datafrominput[0], datafrominput[6] / 100), 0);// running after tax
            label40.Text = afterThetax.ToString("0.##");

            

            // Future GRowth Savings!!=====================================================================

            double preTax = Math.Round(runningNumbers.futuresaving(datafrominput[45] * 12, datafrominput[5] / 100, datafrominput[17] - datafrominput[15]),0); // this is using spoce Age! 
            label49.Text = preTax.ToString("0.##");                                                                                                         /// Why does this use spouce age, should it also use client age??

            double afterTax = Math.Round(runningNumbers.futuresaving(datafrominput[46] * 12, datafrominput[6] / 100, datafrominput[2] - datafrominput[0]),0); /// Client or Spouce why??
            label68.Text = afterTax.ToString("0.##");


            //Totaling Area
            double[] totalSpace = new double[24];
            for (int y = 0; y < 24; y++)
            {
                totalSpace[y] = datafrominput[47]*12 + cs1[y] + ss1[y] + penc[y] + pens[y] + Math.Round((preT * (datafrominput[20] / 100)), 2) + Math.Round((afterThetax * (datafrominput[20] / 100)), 2) + Math.Round((preTax * (datafrominput[20] / 100)), 2) + Math.Round((afterTax * (datafrominput[20] / 100)), 2);
            }           /// Remeber this 10236

            // Net Income
            double[] totalAfterTax = new double[24];

            for (int y = 0; y < 24; y++)
            {
                totalAfterTax[y] = Math.Round(totalSpace[y] - (totalSpace[y] * (datafrominput[23] / 100)),0);
            }

            //Budget
            double[] spending = new double[24];
            spending[0] = runningNumbers.investment(datafrominput[30] * 12, datafrominput[2] - datafrominput[0], datafrominput[22] / 100);
            for (int y = 1; y < 24; y++)
            {
                spending[y] = Math.Round(spending[y - 1] + (spending[y - 1] * (datafrominput[22] / 100)),0);
            }


            //Differntial
            double[] different = new double[24];
            for (int y = 0; y < 24; y++)
            {
                different[y] = Math.Round(totalAfterTax[y] - spending[y],0);
            }

            //Withdarwal Rate and projected value

            double totalINV1, totlaINV2;
            totalINV1 = preT + afterThetax + preTax + afterTax;
            totlaINV2 = (preT * (datafrominput[20] / 100)) + (afterThetax * (datafrominput[21] / 100)) + (preTax * (datafrominput[20] / 100)) + (afterTax * (datafrominput[21] / 100));
            double[] withdrawRate = new double[24];
            double[] projectedVale = new double[24];

            int z = 0;

            withdrawRate[z] = ((totlaINV2 + (-different[z])) / totalINV1); // First line of Wtihdaral rate
            projectedVale[z] = (totalINV1 - (totalINV1 * withdrawRate[z])) + (totalINV1 * (datafrominput[20] / 100));

            for (z = 1; z <= 23; z++)
            {
                withdrawRate[z] = -Math.Round((different[z] +(-totlaINV2)) / projectedVale[z-1],4);
                projectedVale[z] = Math.Round((projectedVale[z-1] - (projectedVale[z-1] * withdrawRate[z])) + (projectedVale[z-1] * (datafrominput[20] / 100)),0);
            }
           

            //  dataGridView1.ColumnHeadersHeight = 300;


            double cage = Math.Floor(datafrominput[2]);// cleint age
            double srcage = Math.Floor(datafrominput[17]);// spouce age

            for (int b = 0; b <= 23; b++)
            {
                dataGridView1.Rows.Add(cage, srcage, datafrominput[47] * 12,Math.Round(penc[b], 1), Math.Round(pens[b], 1), Math.Round(cs1[b], 1), Math.Round(ss1[b], 1), Math.Round(preT * (datafrominput[20] / 100), 1), Math.Round(afterThetax * (datafrominput[20] / 100), 1), Math.Round(preTax * (datafrominput[20] / 100), 1), Math.Round(afterTax * (datafrominput[20] / 100), 1), Math.Round(totalSpace[b], 1), Math.Round(totalAfterTax[b], 1), Math.Round(spending[b], 1), Math.Round(different[b], 1), Math.Round(100 * withdrawRate[b], 1), Math.Round(projectedVale[b], 1)); ;
                cage += 1;              // 
                srcage += 1;
            }


        displayNum();
        }

        public void displayNum()
        {
            label1.Text = datafrominput[0].ToString(); // client age
            label2.Text = datafrominput[1].ToString();// cleint ss
            label3.Text = datafrominput[2].ToString(); // cleint desiter rt age
            label4.Text = datafrominput[3].ToString();
            label5.Text = datafrominput[4].ToString(); //cleint pension triger age
            label6.Text = datafrominput[5].ToString();// rate for pre tax
            label7.Text = datafrominput[6].ToString();// tax for after tax
            label8.Text = datafrominput[7].ToString();
            label9.Text = datafrominput[8].ToString();



            //client pen =====================================================================
            label10.Text = datafrominput[9].ToString(); // age 1
            label11.Text = datafrominput[10].ToString();// pen 1
            label12.Text = datafrominput[11].ToString();
            label13.Text = datafrominput[12].ToString();
            label14.Text = datafrominput[13].ToString();
            label15.Text = datafrominput[14].ToString();


            // Spouce pen=====================================================================
            label24.Text = datafrominput[23].ToString();// after tax rate
            label25.Text = datafrominput[24].ToString();
            label26.Text = datafrominput[25].ToString();
            label27.Text = datafrominput[26].ToString();
            label28.Text = datafrominput[27].ToString();
            label29.Text = datafrominput[28].ToString();


            // spouce =====================================================================

            label16.Text = datafrominput[15].ToString();// spouce age
            label17.Text = datafrominput[16].ToString();// spouce ss            
            label18.Text = datafrominput[17].ToString(); // spuce Retierment age       
            label19.Text = datafrominput[18].ToString(); // spouce ss
            label20.Text = datafrominput[19].ToString(); // spouce pention
            
         //   label21.Text = datafrominput[20].ToString();//blank
            //label22.Text = datafrominput[21].ToString();
            label23.Text = datafrominput[22].ToString();
            
           
            label30.Text = datafrominput[29].ToString();
            label31.Text = datafrominput[30].ToString();
            label32.Text = datafrominput[31].ToString();
            label33.Text = datafrominput[32].ToString();
            label34.Text = datafrominput[33].ToString();
            label35.Text = datafrominput[34].ToString();
            label36.Text = datafrominput[35].ToString("0.##");// pre tax
            label38.Text = datafrominput[36].ToString("0.##"); // after taxe


            label39.Text = datafrominput[37].ToString("0.##");
            label41.Text = datafrominput[38].ToString("0.##");// client savings
            label42.Text = datafrominput[39].ToString("0.##");// spouce savings
            label21.Text = datafrominput[40].ToString("0.##");
            label22.Text = datafrominput[41].ToString("0.##");
            label81.Text = datafrominput[42].ToString("0.##");



            //label27.Text = namedata[0];
            //label28.Text = namedata[1];
            //label29.Text = namedata[2];

            label73.Text = namedata[3];
            label74.Text = namedata[4];
            label75.Text = namedata[5];
            label76.Text = namedata[6];
            label77.Text = namedata[7];
            label78.Text = namedata[8];
                        
           
            pi();
        }
        public void pi()
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void thisgrid1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ClientAgeS.Checked)
                masterInput[0] =Convert.ToDouble(runningcleintage.Text);


            



            TabPage tp = new TabPage("Model");
            tabControl1.TabPages.Add(tp);
            //  tabControl1.TabPages.Remove(tabControl1.SelectedTab); removing tabs

            DataGridView sg = new DataGridView();
            DataTable dt1 = new DataTable();
            sg.Size = new Size(1649, 690);

            dt1.Columns.Add("Client Age");
            dt1.Columns.Add("Spouce Age");
            dt1.Columns.Add("Annuity");
            dt1.Columns.Add("Pension ");
            dt1.Columns.Add("Client SS ");
            dt1.Columns.Add("Spouce SS");
            dt1.Columns.Add("Income From Current Pre-Tax");
            dt1.Columns.Add("Income From Current After-Tax");
            dt1.Columns.Add("Income From Futre Savings Pre-Tax");
            dt1.Columns.Add("Income From Futre Savings After-Tax");
            dt1.Columns.Add("Total Income");
            dt1.Columns.Add("Net Income");
            dt1.Columns.Add("Income Goal");
            dt1.Columns.Add("Differential");

            for(int i =0; 0 <23;i++)
                dt1.Rows.Add(masterInput[0]+=1);


            sg.DataSource = dt1;
            tp.Controls.Add(sg);

        }

        private void roleAdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roleA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clienttextage_Click(object sender, EventArgs e)
        {

        }
        Bitmap b;
        private void metroSetButton1_Click(object sender, EventArgs e) // Print  Box 
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          //  e.Graphics.Drawp
        }

        private void ClientAgeS_CheckedChanged(object sender)
        {

        }

        private void metroSetCheckBox2_CheckedChanged(object sender)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void metroSetTextBox1_Click(object sender, EventArgs e)
        {

        }

        /*DataGridViewTextBoxColumn summaryColumn =
   new DataGridViewTextBoxColumn();
summaryColumn.HeaderText = "Summary";
summaryColumn.MinimumWidth = 50;
summaryColumn.FillWeight = 200;
*/




        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
