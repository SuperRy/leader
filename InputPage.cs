using System;
using System.Collections.Generic;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;


namespace Leadersoftware
{
    public partial class inputP : UserControl
    {
        static List<String> input1 = new List<string>();
        static bool bClicked = false;
        static ExcelPackage excel;
        static OpenFileDialog openFile = new OpenFileDialog();
        static SaveFileDialog savingFile = new SaveFileDialog();
        static string key = "iethjp586578";

        List<double> numdata = new List<double>();

        List<String> stringdata = new List<string>();
       // List<double>[] numdata = new List<double>[125];
        double splitss=0, splitcheck =0;

        DateTime todayT = DateTime.Today;


        public inputP()
        {
            InitializeComponent();
            Cursor.Current = Cursors.Hand;


        }
        public List<double> callingForm// sending data
        {
            get { return numdata; }
        }
        public List<String> callingForm2
        {
            get { return stringdata;  }
        }



        bool focus = false, f =false;
        private void tabPage2_Paint(object sender, PaintEventArgs e) 
        {
            Pen p = new Pen(Color.Red);
            Graphics g = e.Graphics;
            int variance = 1, v = 1;
            if (focus)
                g.DrawRectangle(p, new Rectangle(lastname.Location.X - v, lastname.Location.Y - v, lastname.Width + variance, lastname.Height + variance));
            if (f)
                g.DrawRectangle(p, new Rectangle(clientname.Location.X - v, clientname.Location.Y - v, clientname.Width + variance, clientname.Height + variance));


        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }
        public int datamoving()
        {
            numdata.Clear();                                          
            if (string.IsNullOrEmpty(lastname.Text)|| string.IsNullOrEmpty(clientAnnualS.Text) || string.IsNullOrEmpty(clientname.Text) || string.IsNullOrEmpty(clientage.Text) || string.IsNullOrEmpty(clientMI.Text) || string.IsNullOrEmpty(ClientSS.Text) || string.IsNullOrEmpty(clientDRage.Text) || string.IsNullOrEmpty(clientDSSAge.Text) || string.IsNullOrEmpty(clientDPAge.Text) || string.IsNullOrEmpty(totalExp.Text) || string.IsNullOrEmpty(totalCurrentMS.Text) || string.IsNullOrEmpty(pAtotal.Text) || string.IsNullOrEmpty(preTaxTotal.Text) || string.IsNullOrEmpty(afterTInTotal.Text) || string.IsNullOrEmpty(theDebts.Text) || string.IsNullOrEmpty(cash.Text))
            {
                  //MessageBox.Show("Missing varables");
                lastname.BackColor = Color.Red;
                clientname.BackColor = Color.Red;
                clientage.BackColor = Color.Red;
                clientMI.BackColor = Color.Red;
                ClientSS.BackColor = Color.Red;
                clientDRage.BackColor = Color.Red;
                clientDSSAge.BackColor = Color.Red;
                clientDPAge.BackColor = Color.Red;
                totalExp.BackColor = Color.Red;
                totalCurrentMS.BackColor = Color.Red;
                pAtotal.BackColor = Color.Red;
                preTaxTotal.BackColor = Color.Red;
                afterTInTotal.BackColor = Color.Red;
                theDebts.BackColor = Color.Red;
                clientAnnualS.BackColor = Color.DarkRed;
                cash.BackColor = Color.MediumVioletRed;
                return 0;
            }
            else
            {
                lastname.BackColor = Color.White;
                clientname.BackColor = Color.White;
                clientage.BackColor = Color.White;
                clientMI.BackColor = Color.White;
                ClientSS.BackColor = Color.White;
                clientDRage.BackColor = Color.White;
                clientDSSAge.BackColor = Color.White;
                clientDPAge.BackColor = Color.White;
                totalExp.BackColor = Color.White;
                totalCurrentMS.BackColor = Color.White;
                pAtotal.BackColor = Color.White;
                preTaxTotal.BackColor = Color.White;
                afterTInTotal.BackColor = Color.White;
                theDebts.BackColor = Color.White;
                clientAnnualS.BackColor = Color.White;
                cash.BackColor = Color.White;

                // ====================================================================================

                if (String.IsNullOrEmpty(spouceName.Text))
                    spouceName.Text = "No spouce";
                if (String.IsNullOrEmpty(spouceAge.Text))
                    spouceAge.Text = "0";
                if (String.IsNullOrEmpty(spouceAnnualS.Text))
                    spouceAnnualS.Text = "0";
                //
                if (String.IsNullOrEmpty(spouceMI.Text))
                    spouceMI.Text = "0";
                if (String.IsNullOrEmpty(spouceSS.Text))
                    spouceSS.Text = "0";
                //
                if (String.IsNullOrEmpty(spouceDRage.Text))
                    spouceDRage.Text = "0";
                if (String.IsNullOrEmpty(spouceDSSAge.Text))
                    spouceDSSAge.Text = "0";
                if (String.IsNullOrEmpty(spouceDPAge.Text))
                    spouceDPAge.Text = "0";

                // Pen ====================================================================================

                if (String.IsNullOrEmpty(pensionName1.Text))
                    pensionName1.Text = "No Info";
                if (String.IsNullOrEmpty(pensionName2.Text))
                    pensionName2.Text = "No Info";
                if (String.IsNullOrEmpty(pensionName3.Text))
                    pensionName3.Text = "No Info";
                if (String.IsNullOrEmpty(pensionName4.Text))
                    pensionName4.Text = "No Info";
                if (String.IsNullOrEmpty(pensionName5.Text))
                    pensionName5.Text = "No Info";
                if (String.IsNullOrEmpty(pensionName6.Text))
                    pensionName6.Text = "No Info";



                if (String.IsNullOrEmpty(pensionAge1.Text))
                    pensionAge1.Text = "0";
                if (String.IsNullOrEmpty(pensionAge2.Text))
                    pensionAge2.Text = "0";
                if (String.IsNullOrEmpty(pensionAge3.Text))
                    pensionAge3.Text = "0";
                if (String.IsNullOrEmpty(pensionAge4.Text))
                    pensionAge4.Text = "0";
                if (String.IsNullOrEmpty(pensionAge5.Text))
                    pensionAge5.Text = "0";
                if (String.IsNullOrEmpty(pensionAge6.Text))
                    pensionAge6.Text = "0";

                if (String.IsNullOrEmpty(pensionPValue1.Text))
                    pensionPValue1.Text = "0";
                if (String.IsNullOrEmpty(pensionPValue2.Text))
                    pensionPValue2.Text = "0";
                if (String.IsNullOrEmpty(pensionPValue3.Text))
                    pensionPValue3.Text = "0";
                if (String.IsNullOrEmpty(pensionPValue4.Text))
                    pensionPValue4.Text = "0";
                if (String.IsNullOrEmpty(pensionPValue5.Text))
                    pensionPValue5.Text = "0";
                if (String.IsNullOrEmpty(pensionPValue6.Text))
                    pensionPValue6.Text = "0";
                if (String.IsNullOrEmpty(Anuity.Text))
                    Anuity.Text = "0";





                numdata.Add(Convert.ToDouble(clientage.Text));

                //cleint ====================================================================================
                if (checkBox10.Checked == true && checkBox9.Checked == false)
                {
                    numdata.Add(Convert.ToDouble(ClientSS.Text.Trim('$').Trim(',')));
                    splitss = Convert.ToDouble(spouceDSSAge.Text);
                    splitcheck = 2;
                }
                else
                    numdata.Add(Convert.ToDouble(ClientSS.Text.Trim('$').Trim(',')));

                numdata.Add(Convert.ToDouble(clientDRage.Text));
               
                numdata.Add(Convert.ToDouble(clientDSSAge.Text));


                numdata.Add(Convert.ToDouble(clientDPAge.Text));

                numdata.Add(Convert.ToDouble(clientPTR.Text));
                numdata.Add(Convert.ToDouble(clientATR.Text));
                numdata.Add(Convert.ToDouble(clientIR.Text));
                numdata.Add(Convert.ToDouble(beforeTaxRate.Text));


                //pension ====================================================================================

                numdata.Add(Convert.ToDouble(pensionAge1.Text));
                numdata.Add(Convert.ToDouble(pensionPValue1.Text.Trim('$').Trim(',')));
                numdata.Add(Convert.ToDouble(pensionAge2.Text));
                numdata.Add(Convert.ToDouble(pensionPValue2.Text.Trim('$').Trim(',')));
                numdata.Add(Convert.ToDouble(pensionAge3.Text));
                numdata.Add(Convert.ToDouble(pensionPValue3.Text.Trim('$').Trim(',')));
                
                // 15 ^ ====================================================================================


                if (string.IsNullOrEmpty(spouceAge.Text))
                    numdata.Add(0);
                else
                    numdata.Add(double.Parse(spouceAge.Text, CultureInfo.InvariantCulture));

                    //Spouce retierment age
                    //doing the check boxs for half age 
                if (checkBox9.Checked == true && checkBox10.Checked == false)
                    {
                        numdata.Add(double.Parse(spouceSS.Text.Trim('$').Trim(','), CultureInfo.InvariantCulture));
                        splitss = Convert.ToDouble(spouceDSSAge.Text);
                        splitcheck = 1;
                    }
                else
                {
                    if (spouceSS.Text == null)
                        numdata.Add(0);
                    else
                       numdata.Add(double.Parse(spouceSS.Text.Trim('$').Trim(','), CultureInfo.InvariantCulture));
                 }
                if (spouceDRage.Text == null)
                    numdata.Add(0);
                else
                   numdata.Add(double.Parse(spouceDRage.Text, CultureInfo.InvariantCulture));

                if (spouceDRage.Text == null) //19
                    numdata.Add(0);
                else
                    numdata.Add(double.Parse(spouceDSSAge.Text, CultureInfo.InvariantCulture));

                if (spouceDPAge.Text == null) //20
                    numdata.Add(0);
                else
                    numdata.Add(double.Parse(spouceDPAge.Text, CultureInfo.InvariantCulture));

                if (spoucePTR.Text == null)//21
                    numdata.Add(0);
                else
                    numdata.Add(double.Parse(spoucePTR.Text, CultureInfo.InvariantCulture));

                if (spouceATR.Text == null)
                    numdata.Add(0);
                else
                    numdata.Add(double.Parse(spouceATR.Text, CultureInfo.InvariantCulture));

               numdata.Add(double.Parse(afterlongtermINF.Text, CultureInfo.InvariantCulture));

                
               numdata.Add(double.Parse(afterRtTax.Text, CultureInfo.InvariantCulture));
                //Spouce Pension 
                numdata.Add(Convert.ToDouble(pensionAge4.Text));
                numdata.Add(Convert.ToDouble(pensionPValue4.Text.Trim('$').Trim(',')));
                numdata.Add(Convert.ToDouble(pensionAge5.Text));
                numdata.Add(Convert.ToDouble(pensionPValue5.Text.Trim('$').Trim(',')));
                numdata.Add(Convert.ToDouble(pensionAge6.Text));
                numdata.Add(Convert.ToDouble(pensionPValue6.Text.Trim('$').Trim(',')));
                //////


                numdata.Add(Convert.ToDouble(totalExp.Text.Trim('$').Trim(',')));
                numdata.Add(Convert.ToDouble(totalCurrentMS.Text.Trim('$').Trim(',')));
                numdata.Add(Convert.ToDouble(cash.Text.Trim('$').Trim(',')));
                numdata.Add(Convert.ToDouble(pAtotal.Text.Trim('$').Trim(',')));
                numdata.Add(Convert.ToDouble(collegeTotal.Text.Trim('$').Trim(',')));
                numdata.Add(Convert.ToDouble(preTaxTotal.Text.Trim('$').Trim(','))); //35
                numdata.Add(Convert.ToDouble(afterTInTotal.Text.Trim('$').Trim(',')));
                numdata.Add(Convert.ToDouble(theDebts.Text.Trim('$').Trim(',')));
                // Cools

                numdata.Add(Convert.ToDouble(clientPreTaxSavings.Text.Trim('$').Trim(',')));
                numdata.Add(Convert.ToDouble(spoucePreTaxSaving.Text.Trim('$').Trim(',')));

                numdata.Add(Convert.ToDouble(spoucePTR.Text));
                numdata.Add(Convert.ToDouble(spouceATR.Text));


                numdata.Add(Convert.ToDouble(otherExpen.Text.Trim('$').Trim(',')));


                
                numdata.Add(splitss);         // 43      
                numdata.Add(splitcheck); // 44

                numdata.Add(Convert.ToDouble(clientPreTaxSavings.Text.Trim('$').Trim(',')) + Convert.ToDouble(spoucePreTaxSaving.Text.Trim('$').Trim(',')) + Convert.ToDouble(empMatch.Text.Trim('$').Trim(',')) + Convert.ToDouble(spouceEMP.Text.Trim('$').Trim(',')) + Convert.ToDouble(roth.Text.Trim('$').Trim(',')));
                numdata.Add(Convert.ToDouble(otherInvestmentSaving.Text.Trim('$').Trim(',')));
                if (Anuity.Text == null)
                    numdata.Add(0);
                else
                    numdata.Add(Convert.ToDouble(Anuity.Text.Trim('$').Trim(',')));

                // names to be moved!  ====================================================================================


                stringdata.Add(lastname.Text.ToString());
                stringdata.Add(clientname.Text.ToString());
                stringdata.Add(spouceName.Text.ToString());


             
                stringdata.Add(pensionName1.Text.ToString());
                stringdata.Add(pensionName2.Text.ToString());
                stringdata.Add(pensionName3.Text.ToString());
               

                stringdata.Add(pensionName4.Text.ToString());
                stringdata.Add(pensionName5.Text.ToString());
                stringdata.Add(pensionName6.Text.ToString());

               // MessageBox.Show("ConGrats NO ERROS! :D Good Job!!");

                callmove();// calling to the next page
                return 1;
            }
            
        }
      
        public void callmove() //sending data
        {
            var mainmove = this.Parent as Home;
            mainmove.inputcontrol = callingForm;

            var strmove = this.Parent as Home;
            strmove.inputcontrol2 = callingForm2;
        }
    
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void InputPage_Load(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void lastname_TextChanged(object sender, EventArgs e)
        {
           // lastname.BorderColor

        }

        //Saving AS!!!
        private void savingBut_Click(object sender, EventArgs e)
        {
            List<string> textboxList = new List<string>();

            //====================================================================================

            textboxList.Add(lastname.Text);
            textboxList.Add(clientname.Text);
            textboxList.Add(clientBithday.Text);
            textboxList.Add(clientage.Text);
            textboxList.Add(spouceName.Text);
            textboxList.Add(spouceBirthday.Text);
            textboxList.Add(spouceAge.Text);

            //depedent ====================================================================================

            textboxList.Add(dependantName1.Text);
            textboxList.Add(depedentBday1.Text);
            textboxList.Add(dependentAge1.Text);
            textboxList.Add(dependentOther1.Text);

            textboxList.Add(dependantName2.Text);
            textboxList.Add(depedentBday2.Text);
            textboxList.Add(dependentAge2.Text);
            textboxList.Add(dependentOther2.Text);

            textboxList.Add(dependantName3.Text);
            textboxList.Add(depedentBday3.Text);
            textboxList.Add(dependentAge3.Text);
            textboxList.Add(dependentOther3.Text);

            textboxList.Add(dependantName4.Text);
            textboxList.Add(depedentBday4.Text);
            textboxList.Add(dependentAge4.Text);
            textboxList.Add(dependentOther4.Text);

            //Anual Salary ====================================================================================

            textboxList.Add(clientAnnualS.Text);
            textboxList.Add(spouceAnnualS.Text);
            textboxList.Add(clientMI.Text);
            textboxList.Add(spouceMI.Text);
            textboxList.Add(ClientSS.Text);
            textboxList.Add(spouceSS.Text);

            //Penstion setection ====================================================================================

            textboxList.Add(pensionName1.Text);
            textboxList.Add(pensionAge1.Text);
            textboxList.Add(pensionPValue1.Text);

            textboxList.Add(pensionName2.Text);
            textboxList.Add(pensionAge2.Text);
            textboxList.Add(pensionPValue2.Text);

            textboxList.Add(pensionName3.Text);
            textboxList.Add(pensionAge3.Text);
            textboxList.Add(pensionPValue3.Text);

            textboxList.Add(pensionName4.Text);
            textboxList.Add(pensionAge4.Text);
            textboxList.Add(pensionPValue4.Text);

            textboxList.Add(pensionName5.Text);
            textboxList.Add(pensionAge5.Text);
            textboxList.Add(pensionPValue5.Text);

            textboxList.Add(pensionName6.Text);
            textboxList.Add(pensionAge6.Text);
            textboxList.Add(pensionPValue6.Text);

            //SS actiivation range  ====================================================================================

            textboxList.Add(clientDRage.Text);
            textboxList.Add(spouceDRage.Text);
            textboxList.Add(clientDSSAge.Text);
            textboxList.Add(spouceDSSAge.Text);
            textboxList.Add(clientDPAge.Text);
            textboxList.Add(spouceDPAge.Text);

            // Range Ativation ====================================================================================

            textboxList.Add(clientPTR.Text);
            textboxList.Add(spoucePTR.Text);
            textboxList.Add(clientATR.Text);
            textboxList.Add(spouceATR.Text);
            textboxList.Add(clientIR.Text);
            textboxList.Add(afterlongtermINF.Text);
            textboxList.Add(beforeTaxRate.Text);
            textboxList.Add(afterRtTax.Text);

            // ====================================================================================

            textboxList.Add(rentMortage.Text);
            textboxList.Add(realEstateT.Text);

            textboxList.Add(healthINSUR.Text);
            textboxList.Add(denDoc.Text);
            textboxList.Add(perscript.Text);

            textboxList.Add(vactionSavings.Text);

            textboxList.Add(livingExp.Text);

            //general ====================================================================================

            textboxList.Add(clientPreTaxSavings.Text);
            textboxList.Add(spoucePreTaxSaving.Text);
            textboxList.Add(empMatch.Text);
            textboxList.Add(roth.Text);
            textboxList.Add(otherInvestmentSaving.Text);

            // Current Monthley Saving ====================================================================================

            textboxList.Add(cash.Text);
            textboxList.Add(checkingSaving.Text);
            textboxList.Add(moneyMark.Text);

            // College saving ====================================================================================

            textboxList.Add(collegeName1.Text);
            textboxList.Add(collegeSaving1.Text);
            textboxList.Add(collegeName2.Text);
            textboxList.Add(collegeSaving2.Text);
            textboxList.Add(collegeName3.Text);
            textboxList.Add(collegeSaving3.Text);
            textboxList.Add(collegeName4.Text);
            textboxList.Add(collegeSaving4.Text);

            // after Tax ====================================================================================

            textboxList.Add(afterTName1.Text);
            textboxList.Add(afterTNum1.Text);
            textboxList.Add(afterTName2.Text);
            textboxList.Add(afterTNum2.Text);
            textboxList.Add(afterTName3.Text);
            textboxList.Add(afterTNum3.Text);
            textboxList.Add(afterTName4.Text);
            textboxList.Add(afterTNum4.Text);
            textboxList.Add(afterTName5.Text);
            textboxList.Add(afterTNum5.Text);
            textboxList.Add(afterTName6.Text);
            textboxList.Add(afterTNum6.Text);

            // Pre tax invermsnet ====================================================================================

            textboxList.Add(preTInvName1.Text);
            textboxList.Add(preTNum1.Text);
            textboxList.Add(preTInvName2.Text);
            textboxList.Add(preTNum2.Text);
            textboxList.Add(preTInvName3.Text);
            textboxList.Add(preTNum3.Text);
            textboxList.Add(preTInvName4.Text);
            textboxList.Add(preTNum4.Text);
            textboxList.Add(preTInvName5.Text);
            textboxList.Add(preTNum5.Text);
            textboxList.Add(preTInvName6.Text);
            textboxList.Add(preTNum6.Text);

            // personal assests ====================================================================================

            textboxList.Add(phome.Text);
            textboxList.Add(vHome.Text);
            textboxList.Add(pAssest1.Text);
            textboxList.Add(pAssestNum1.Text);
            textboxList.Add(pAssest2.Text);
            textboxList.Add(pAssestNum2.Text);

            // Debts ====================================================================================

            textboxList.Add(mortga.Text);
            textboxList.Add(homeEq.Text);
            textboxList.Add(carLoan.Text);
            textboxList.Add(personalLoan.Text);
            textboxList.Add(cC.Text);
            textboxList.Add(otherDebts.Text);
            textboxList.Add(otherExpen.Text);
            textboxList.Add(spouceEMP.Text);
            textboxList.Add(Anuity.Text);


            savingFiles(textboxList,bClicked);
            bClicked = false;
        }
        //Saved
        public static void savingFiles(List<string> texboxlist, bool butclick)
        {
            if (butclick == true)
            {

                excel.Save();
            }
            else
            {
                excel = new ExcelPackage();
                var dataWorkSheet = excel.Workbook.Worksheets.Add("page1");

                savingFile.Filter = "Excel files (*.xlsx)|*.xlsx";
                savingFile.FilterIndex = 0;
                savingFile.RestoreDirectory = true;
                savingFile.Title = "Export Excel File To";
                dataWorkSheet.Cells["R21"].Value = key;
                dataWorkSheet.Cells["A1"].LoadFromCollection(texboxlist);

                if (savingFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FileInfo nameOfPath = new FileInfo(savingFile.FileName);
                    excel.SaveAs(nameOfPath);
                }
            }

            //https://riptutorial.com/epplus/example/26425/fill-from-collection

        }


        //Opening the file! ====================================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Excel files (*.xlsx)|*.xlsx";
            openFile.Title = "Loading Client Data";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var filePath = openFile.FileName;
                FileInfo fileInfo = new FileInfo(filePath);
                excel = new ExcelPackage(fileInfo);
                var dataWorkSheet = excel.Workbook.Worksheets[1];
                
              

               try
                {
                    if (dataWorkSheet.Cells["R21"].Value.ToString() == "NULL" || dataWorkSheet.Cells["R21"].Value.ToString() == key)
                    {
                        bClicked = true;
                   

                        var start = dataWorkSheet.Dimension.Start;
                        var end = dataWorkSheet.Dimension.End;
                        for (int col = start.Column; col <= 123; col++)
                        {
                            input1.Add(dataWorkSheet.Cells["A" + col].Value.ToString());
                           
                        }
                        lastname.Text = input1[0];

                        clientname.Text = input1[1];
                        clientBithday.Text = input1[2];
                        clientage.Text = input1[3];
                        spouceName.Text = input1[4];
                        spouceBirthday.Text = input1[5];
                        spouceAge.Text = input1[6];

                        //depedent ====================================================================================

                        dependantName1.Text = input1[7];
                        depedentBday1.Text = input1[8];
                        dependentAge1.Text = input1[9];
                        dependentOther1.Text = input1[10];

                        dependantName2.Text = input1[11];
                        depedentBday2.Text = input1[12];
                        dependentAge2.Text = input1[13];
                        dependentOther2.Text = input1[14];

                        dependantName3.Text = input1[15];
                        depedentBday3.Text = input1[16];
                        dependentAge3.Text = input1[17];
                        dependentOther3.Text = input1[18];

                        dependantName4.Text = input1[19];
                        depedentBday4.Text = input1[20];
                        dependentAge4.Text = input1[21];
                        dependentOther4.Text = input1[22];

                        //Anual Salary ====================================================================================

                        clientAnnualS.Text = input1[23];
                        spouceAnnualS.Text = input1[24];
                        clientMI.Text = input1[25];
                        spouceMI.Text = input1[26];
                        ClientSS.Text = input1[27];
                        spouceSS.Text = input1[28];

                        //Penstion setection ====================================================================================

                        pensionName1.Text = input1[29];
                        pensionAge1.Text = input1[30];
                        pensionPValue1.Text = input1[31];

                        pensionName2.Text = input1[32];
                        pensionAge2.Text = input1[33];
                        pensionPValue2.Text = input1[34];

                        pensionName3.Text = input1[35];
                        pensionAge3.Text = input1[36];
                        pensionPValue3.Text = input1[37];

                        pensionName4.Text = input1[38];
                        pensionAge4.Text = input1[39];
                        pensionPValue4.Text = input1[40];

                        pensionName5.Text = input1[41];
                        pensionAge5.Text = input1[42];
                        pensionPValue5.Text = input1[43];

                        pensionName6.Text = input1[44];
                        pensionAge6.Text = input1[45];
                        pensionPValue6.Text = input1[46];

                        //SS actiivation range ====================================================================================

                        clientDRage.Text = input1[47];
                        spouceDRage.Text = input1[48];
                        clientDSSAge.Text = input1[49];
                        spouceDSSAge.Text = input1[50];
                        clientDPAge.Text = input1[51];
                        spouceDPAge.Text = input1[52];

                        // Range Ativation ====================================================================================

                        clientPTR.Text = input1[53];
                        spoucePTR.Text = input1[54];
                        clientATR.Text = input1[55];
                        spouceATR.Text = input1[56];
                        clientIR.Text = input1[57];
                        afterlongtermINF.Text = input1[58];
                        beforeTaxRate.Text = input1[59];
                        afterRtTax.Text = input1[60];

                        // ====================================================================================

                        rentMortage.Text = input1[61];
                        realEstateT.Text = input1[62];

                        healthINSUR.Text = input1[63];
                        denDoc.Text = input1[64];
                        perscript.Text = input1[65];

                        vactionSavings.Text = input1[66];

                        livingExp.Text = input1[67];

                        //general ====================================================================================

                        clientPreTaxSavings.Text = input1[68];
                        spoucePreTaxSaving.Text = input1[69];
                        empMatch.Text = input1[70];
                        roth.Text = input1[71];
                        otherInvestmentSaving.Text = input1[72];

                        // Current Monthley Saving ====================================================================================

                        cash.Text = input1[73];
                        checkingSaving.Text = input1[74];
                        moneyMark.Text = input1[75];

                        // College saving ====================================================================================

                        collegeName1.Text = input1[76];
                        collegeSaving1.Text = input1[77];
                        collegeName2.Text = input1[78];
                        collegeSaving2.Text = input1[79];
                        collegeName3.Text = input1[80];
                        collegeSaving3.Text = input1[81];
                        collegeName4.Text = input1[82];
                        collegeSaving4.Text = input1[83];

                        // after Tax ====================================================================================

                        afterTName1.Text = input1[84];
                        afterTNum1.Text = input1[85];
                        afterTName2.Text = input1[86];
                        afterTNum2.Text = input1[87];
                        afterTName3.Text = input1[88];
                        afterTNum3.Text = input1[89];
                        afterTName4.Text = input1[90];
                        afterTNum4.Text = input1[91];
                        afterTName5.Text = input1[92];
                        afterTNum5.Text = input1[93];
                        afterTName6.Text = input1[94];
                        afterTNum6.Text = input1[95];

                        // Pre tax invermsnet ====================================================================================

                        preTInvName1.Text = input1[96];
                        preTNum1.Text = input1[97];
                        preTInvName2.Text = input1[98];
                        preTNum2.Text = input1[99];
                        preTInvName3.Text = input1[100];
                        preTNum3.Text = input1[101];
                        preTInvName4.Text = input1[102];
                        preTNum4.Text = input1[103];
                        preTInvName5.Text = input1[104];
                        preTNum5.Text = input1[105];
                        preTInvName6.Text = input1[106];
                        preTNum6.Text = input1[107];

                        // personal assests ====================================================================================

                        phome.Text = input1[108];
                        vHome.Text = input1[109];
                        pAssest1.Text = input1[110];
                        pAssestNum1.Text = input1[111];
                        pAssest2.Text = input1[112];
                        pAssestNum2.Text = input1[113];

                        // Debts ====================================================================================

                        mortga.Text = input1[114];
                        homeEq.Text = input1[115];
                        carLoan.Text = input1[116];
                        personalLoan.Text = input1[117];
                        cC.Text = input1[118];

                        otherDebts.Text = input1[119];

                        otherExpen.Text = input1[120];
                        spouceEMP.Text = input1[121];
                        Anuity.Text = input1[122];
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("This is the wrong File!! Please try another File with corret Key");
                    }
                }
                  catch (Exception eb)
               {
                   System.Windows.Forms.MessageBox.Show(eb.ToString());
                }
                
               

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

       

        }

        private void clientname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Age_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        // Expense

        private void totalExp_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void rentMortage_TextChanged(object sender, EventArgs e)
        {
            totalExp.Text = totalExp.Text.Trim(','); // removing the , so the update wont though an erro! 
           
            try
            {
                totalExp.Text = string.Format("{0:C2}", Convert.ToDouble(rentMortage.Text.Trim('$')) + Convert.ToDouble(otherExpen.Text.Trim('$')) + Convert.ToDouble(realEstateT.Text.Trim('$')) + Convert.ToDouble(healthINSUR.Text.Trim('$')) + Convert.ToDouble(denDoc.Text.Trim('$')) + Convert.ToDouble(perscript.Text.Trim('$')) + Convert.ToDouble(vactionSavings.Text.Trim('$')) + Convert.ToDouble(livingExp.Text.Trim('$')));
           }
            
            catch (Exception) { }
           
    }
        private void otherExpen_TextChanged(object sender, EventArgs e)
        {
            otherExpen.Text = otherExpen.Text.Trim(','); // removing the , so the update wont though an erro! 

            try
            {
                totalExp.Text = string.Format("{0:C2}", Convert.ToDouble(rentMortage.Text.Trim('$')) + Convert.ToDouble(otherExpen.Text.Trim('$')) + Convert.ToDouble(realEstateT.Text.Trim('$')) + Convert.ToDouble(healthINSUR.Text.Trim('$')) + Convert.ToDouble(denDoc.Text.Trim('$')) + Convert.ToDouble(perscript.Text.Trim('$')) + Convert.ToDouble(vactionSavings.Text.Trim('$')) + Convert.ToDouble(livingExp.Text.Trim('$')));
            }

            catch (Exception) { }
        }

        private void otherExpen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 

        }

        private void otherExpen_Leave(object sender, EventArgs e)
        {
            otherExpen.Text = otherExpen.Text.Trim(',');
            try
            {
                otherExpen.Text = string.Format("{0:C2}", double.Parse(otherExpen.Text.Trim('$'))); // upding after leaving the textbox
            }
            catch { }
        }
        private void realEstateT_TextChanged(object sender, EventArgs e)
        {
            realEstateT.Text = realEstateT.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                totalExp.Text = string.Format("{0:C2}", Convert.ToDouble(rentMortage.Text.Trim('$')) + Convert.ToDouble(otherExpen.Text.Trim('$')) + Convert.ToDouble(realEstateT.Text.Trim('$')) + Convert.ToDouble(healthINSUR.Text.Trim('$')) + Convert.ToDouble(denDoc.Text.Trim('$')) + Convert.ToDouble(perscript.Text.Trim('$')) + Convert.ToDouble(vactionSavings.Text.Trim('$')) + Convert.ToDouble(livingExp.Text.Trim('$')));
            }
            catch (Exception) { }
        }
        private void healthINSUR_TextChanged(object sender, EventArgs e)
        {
            healthINSUR.Text = healthINSUR.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                totalExp.Text = string.Format("{0:C2}", Convert.ToDouble(rentMortage.Text.Trim('$')) + Convert.ToDouble(otherExpen.Text.Trim('$')) + Convert.ToDouble(realEstateT.Text.Trim('$')) + Convert.ToDouble(healthINSUR.Text.Trim('$')) + Convert.ToDouble(denDoc.Text.Trim('$')) + Convert.ToDouble(perscript.Text.Trim('$')) + Convert.ToDouble(vactionSavings.Text.Trim('$')) + Convert.ToDouble(livingExp.Text.Trim('$')));
            }
            catch (Exception) { }
        }
        private void denDoc_TextChanged(object sender, EventArgs e)
        {
            denDoc.Text = denDoc.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                totalExp.Text = string.Format("{0:C2}", Convert.ToDouble(rentMortage.Text.Trim('$')) + Convert.ToDouble(otherExpen.Text.Trim('$')) + Convert.ToDouble(realEstateT.Text.Trim('$')) + Convert.ToDouble(healthINSUR.Text.Trim('$')) + Convert.ToDouble(denDoc.Text.Trim('$')) + Convert.ToDouble(perscript.Text.Trim('$')) + Convert.ToDouble(vactionSavings.Text.Trim('$')) + Convert.ToDouble(livingExp.Text.Trim('$')));
            }
            catch (Exception) { }
        }
        private void perscript_TextChanged(object sender, EventArgs e)
        {
            perscript.Text = perscript.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                totalExp.Text = string.Format("{0:C2}", Convert.ToDouble(rentMortage.Text.Trim('$')) + Convert.ToDouble(otherExpen.Text.Trim('$')) + Convert.ToDouble(realEstateT.Text.Trim('$')) + Convert.ToDouble(healthINSUR.Text.Trim('$')) + Convert.ToDouble(denDoc.Text.Trim('$')) + Convert.ToDouble(perscript.Text.Trim('$')) + Convert.ToDouble(vactionSavings.Text.Trim('$')) + Convert.ToDouble(livingExp.Text.Trim('$')));
            }
            catch (Exception) { }
        }
        private void giving_TextChanged(object sender, EventArgs e)
        {
            vactionSavings.Text = vactionSavings.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                totalExp.Text = string.Format("{0:C2}", Convert.ToDouble(rentMortage.Text.Trim('$')) + Convert.ToDouble(otherExpen.Text.Trim('$')) + Convert.ToDouble(realEstateT.Text.Trim('$')) + Convert.ToDouble(healthINSUR.Text.Trim('$')) + Convert.ToDouble(denDoc.Text.Trim('$')) + Convert.ToDouble(perscript.Text.Trim('$')) + Convert.ToDouble(vactionSavings.Text.Trim('$')) + Convert.ToDouble(livingExp.Text.Trim('$')));
            }
            catch (Exception) { }
        }
        private void livingExp_TextChanged(object sender, EventArgs e)
        {
            livingExp.Text = livingExp.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                totalExp.Text = string.Format("{0:C2}", Convert.ToDouble(rentMortage.Text.Trim('$')) + Convert.ToDouble(otherExpen.Text.Trim('$')) + Convert.ToDouble(realEstateT.Text.Trim('$')) + Convert.ToDouble(healthINSUR.Text.Trim('$')) + Convert.ToDouble(denDoc.Text.Trim('$')) + Convert.ToDouble(perscript.Text.Trim('$')) + Convert.ToDouble(vactionSavings.Text.Trim('$')) + Convert.ToDouble(livingExp.Text.Trim('$')));
            }
            catch (Exception) { }
        }

        // Currnet Mothly Savings

        private void clientPreTaxSavings_TextChanged(object sender, EventArgs e)
        {
            clientPreTaxSavings.Text = clientPreTaxSavings.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                totalCurrentMS.Text = string.Format("{0:C2}", Convert.ToDouble(spouceEMP.Text.Trim('$')) + Convert.ToDouble(clientPreTaxSavings.Text.Trim('$')) + Convert.ToDouble(spoucePreTaxSaving.Text.Trim('$')) + Convert.ToDouble(empMatch.Text.Trim('$')) + Convert.ToDouble(roth.Text.Trim('$')) + Convert.ToDouble(otherInvestmentSaving.Text.Trim('$')));
            }
            catch (Exception) { }
        }
        private void spoucePreTaxSaving_TextChanged(object sender, EventArgs e)
        {
            spoucePreTaxSaving.Text = spoucePreTaxSaving.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                totalCurrentMS.Text = string.Format("{0:C2}", Convert.ToDouble(spouceEMP.Text.Trim('$')) + Convert.ToDouble(clientPreTaxSavings.Text.Trim('$')) + Convert.ToDouble(spoucePreTaxSaving.Text.Trim('$')) + Convert.ToDouble(empMatch.Text.Trim('$')) + Convert.ToDouble(roth.Text.Trim('$')) + Convert.ToDouble(otherInvestmentSaving.Text.Trim('$')));
            }
            catch (Exception) { }
        }
        private void empMatch_TextChanged(object sender, EventArgs e)
        {
            empMatch.Text = empMatch.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                totalCurrentMS.Text = string.Format("{0:C2}", Convert.ToDouble(spouceEMP.Text.Trim('$')) + Convert.ToDouble(clientPreTaxSavings.Text.Trim('$')) + Convert.ToDouble(spoucePreTaxSaving.Text.Trim('$')) + Convert.ToDouble(empMatch.Text.Trim('$')) + Convert.ToDouble(roth.Text.Trim('$')) + Convert.ToDouble(otherInvestmentSaving.Text.Trim('$')));
            }
            catch (Exception) { }

        }
        private void spouceEMP_TextChanged(object sender, EventArgs e)
        {
            spouceEMP.Text = spouceEMP.Text.Trim(',');
            try
            {
                totalCurrentMS.Text = string.Format("{0:C2}", Convert.ToDouble(spouceEMP.Text.Trim('$')) + Convert.ToDouble(clientPreTaxSavings.Text.Trim('$')) + Convert.ToDouble(spoucePreTaxSaving.Text.Trim('$')) + Convert.ToDouble(empMatch.Text.Trim('$')) + Convert.ToDouble(roth.Text.Trim('$')) + Convert.ToDouble(otherInvestmentSaving.Text.Trim('$')));
            }
            catch (Exception) { }

        }
        private void roth_TextChanged(object sender, EventArgs e)
        {
            roth.Text = roth.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                totalCurrentMS.Text = string.Format("{0:C2}", Convert.ToDouble(spouceEMP.Text.Trim('$')) + Convert.ToDouble(clientPreTaxSavings.Text.Trim('$')) + Convert.ToDouble(spoucePreTaxSaving.Text.Trim('$')) + Convert.ToDouble(empMatch.Text.Trim('$')) + Convert.ToDouble(roth.Text.Trim('$')) + Convert.ToDouble(otherInvestmentSaving.Text.Trim('$')));
            }
            catch (Exception) { }

        }
        private void otherInvestmentSaving_TextChanged(object sender, EventArgs e)
        {
            otherInvestmentSaving.Text = otherInvestmentSaving.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                totalCurrentMS.Text = string.Format("{0:C2}", Convert.ToDouble(spouceEMP.Text.Trim('$')) + Convert.ToDouble(clientPreTaxSavings.Text.Trim('$')) + Convert.ToDouble(spoucePreTaxSaving.Text.Trim('$')) + Convert.ToDouble(empMatch.Text.Trim('$')) + Convert.ToDouble(roth.Text.Trim('$')) + Convert.ToDouble(otherInvestmentSaving.Text.Trim('$')));
            }
            catch (Exception) { }
        }

        //Cash Assests

        private void cash_TextChanged(object sender, EventArgs e)
        {
            


        }
        private void checkingSaving_TextChanged(object sender, EventArgs e)
        {
            checkingSaving.Text = checkingSaving.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                cash.Text = string.Format("{0:C2}", double.Parse(checkingSaving.Text.Trim('$')) + double.Parse(moneyMark.Text.Trim('$')));
            }
            catch (Exception) { }
            
        }
        
        private void moneyMark_TextChanged(object sender, EventArgs e)
        {
            moneyMark.Text = moneyMark.Text.Trim(',' ); // removing the , so the update wont though an erro! 
            try
            {
                cash.Text = string.Format("{0:C2}", double.Parse(checkingSaving.Text.Trim('$')) + double.Parse(moneyMark.Text.Trim('$')));
            }
            catch (Exception) { }
        }
        
        // Personal assets
        private void phome_TextChanged(object sender, EventArgs e)
        {
            phome.Text = phome.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                pAtotal.Text = string.Format("{0:C2}", Convert.ToDouble(phome.Text.Trim('$')) + Convert.ToDouble(vHome.Text.Trim('$')) + Convert.ToDouble(pAssestNum1.Text.Trim('$')) + Convert.ToDouble(pAssestNum2.Text.Trim('$')));
            }
            catch (Exception) { }
        }
        private void vHome_TextChanged(object sender, EventArgs e)
        {
            vHome.Text = vHome.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                pAtotal.Text = string.Format("{0:C2}", Convert.ToDouble(phome.Text.Trim('$')) + Convert.ToDouble(vHome.Text.Trim('$')) + Convert.ToDouble(pAssestNum1.Text.Trim('$')) + Convert.ToDouble(pAssestNum2.Text.Trim('$')));
            }
            catch (Exception) { }
        }
        private void pAssestNum1_TextChanged(object sender, EventArgs e)
        {
            pAssestNum1.Text = pAssestNum1.Text.Trim( ','); // removing the , so the update wont though an erro! 
            try
            {
                pAtotal.Text = string.Format("{0:C2}", Convert.ToDouble(phome.Text.Trim('$')) + Convert.ToDouble(vHome.Text.Trim('$')) + Convert.ToDouble(pAssestNum1.Text.Trim('$')) + Convert.ToDouble(pAssestNum2.Text.Trim('$')));
            }
            catch (Exception) { }
        }
        private void pAssestNum2_TextChanged(object sender, EventArgs e)
        {
            pAssestNum2.Text = pAssestNum2.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                pAtotal.Text = string.Format("{0:C2}", Convert.ToDouble(phome.Text.Trim('$')) + Convert.ToDouble(vHome.Text.Trim('$')) + Convert.ToDouble(pAssestNum1.Text.Trim('$')) + Convert.ToDouble(pAssestNum2.Text.Trim('$')));
            }
            catch (Exception) { }
        }

    

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        // Keeping the $ in the text box
        private void checkingSaving_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
            
        }

        private void moneyMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 

        }

        private void phome_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void vHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void pAssestNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void pAssestNum2_KeyUp(object sender, KeyEventArgs e)
        {
            
        }// no Good

        private void collegeSaving1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void collegeSaving2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 

        }

        private void collegeSaving3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 

        }

        private void collegeSaving4_KeyUp(object sender, KeyEventArgs e)
        {
          

        }
        // do not use
        private void preTNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void preTNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void preTNum3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void preTNum4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void preTNum5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void preTNum6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void mortga_KeyUp(object sender, KeyEventArgs e)
        {
           
        }// DO not use

        private void homeEq_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void carLoan_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void personalLoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void cC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void otherDebts_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void pAssestNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void collegeSaving4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void mortga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void homeEq_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void carLoan_TextChanged(object sender, EventArgs e)
        {
            carLoan.Text = carLoan.Text.Trim(','); // removing the , so the update wont though an erro! 
        }

        private void carLoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void moneyMark_HideSelectionChanged(object sender, EventArgs e)
        {
            
        }



        double p1, p2, p3, p4, p5, p6;

        private void afterTNum1_TextChanged(object sender, EventArgs e)
        {
            afterTNum1.Text = afterTNum1.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                if (checkBox11.Checked == true)
                    p1 = Convert.ToDouble(afterTNum1.Text.Trim('$'));
                else
                    p1 = 0;
                afterTInTotal.Text = string.Format("{0:C2}", p1 + p2 + p3 + p4 + p5 + p6);
            }
            catch (Exception) { }
        }

        private void afterTNum2_TextChanged(object sender, EventArgs e)
        {
            afterTNum2.Text = afterTNum2.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                if (checkBox12.Checked == true)
                    p2 = Convert.ToDouble(afterTNum2.Text.Trim('$'));
                else
                    p2 = 0;
                afterTInTotal.Text = string.Format("{0:C2}", p1 + p2 + p3 + p4 + p5 + p6);
            }
            catch (Exception) { }

        }

        private void afterTNum3_TextChanged(object sender, EventArgs e)
        {
            afterTNum3.Text = afterTNum3.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                if (checkBox13.Checked == true)
                    p3 = Convert.ToDouble(afterTNum3.Text.Trim('$'));
                else
                    p3 = 0;
                afterTInTotal.Text = string.Format("{0:C2}", p1 + p2 + p3 + p4 + p5 + p6);
            }
            catch (Exception) { }

        }

        private void afterTNum4_TextChanged(object sender, EventArgs e)
        {
            afterTNum4.Text = afterTNum4.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                if (checkBox14.Checked == true)
                    p4 = Convert.ToDouble(afterTNum4.Text.Trim('$'));
                else
                    p4 = 0;
                afterTInTotal.Text = string.Format("{0:C2}", p1 + p2 + p3 + p4 + p5 + p6);
            }
            catch (Exception) { }

        }

        private void afterTNum5_TextChanged(object sender, EventArgs e)
        {
            afterTNum5.Text = afterTNum5.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                if (checkBox15.Checked == true)
                    p5 = Convert.ToDouble(afterTNum5.Text.Trim('$'));
                else
                    p5 = 0;
                afterTInTotal.Text = string.Format("{0:C2}", p1 + p2 + p3 + p4 + p5 + p6);
            }
            catch (Exception) { }

        }

        private void afterTNum6_TextChanged(object sender, EventArgs e)
        {
            afterTNum6.Text = afterTNum6.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                if (checkBox16.Checked == true)
                    p6 = Convert.ToDouble(afterTNum6.Text.Trim('$'));
                else
                    p6 = 0;
                afterTInTotal.Text = string.Format("{0:C2}", p1 + p2 + p3 + p4 + p5 + p6);
            }
            catch (Exception) { }
        }

        private void afterTNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void afterTNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void afterTNum3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void afterTNum4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void afterTNum5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 

        }

        private void afterTNum6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 

        }

        private void collegeSaving1_TextChanged(object sender, EventArgs e)
        {
            collegeSaving1.Text = collegeSaving1.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                collegeTotal.Text = string.Format("{0:C2}",Convert.ToDouble(collegeSaving1.Text.Trim('$')) + Convert.ToDouble(collegeSaving2.Text.Trim('$')) + Convert.ToDouble(collegeSaving3.Text.Trim('$')) + Convert.ToDouble(collegeSaving4.Text.Trim('$')));
            }
            catch (Exception) { }
        }

        private void collegeSaving2_TextChanged(object sender, EventArgs e)
        {
            collegeSaving2.Text = collegeSaving2.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                collegeTotal.Text = string.Format("{0:C2}",Convert.ToDouble(collegeSaving1.Text.Trim('$')) + Convert.ToDouble(collegeSaving2.Text.Trim('$')) + Convert.ToDouble(collegeSaving3.Text.Trim('$')) + Convert.ToDouble(collegeSaving4.Text.Trim('$')));
            }
            catch (Exception) { }
        }

        private void collegeSaving3_TextChanged(object sender, EventArgs e)
        {
            collegeSaving3.Text = collegeSaving3.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                collegeTotal.Text = string.Format("{0:C2}",Convert.ToDouble(collegeSaving1.Text.Trim('$')) + Convert.ToDouble(collegeSaving2.Text.Trim('$')) + Convert.ToDouble(collegeSaving3.Text.Trim('$')) + Convert.ToDouble(collegeSaving4.Text.Trim('$')));
            }
            catch (Exception) { }

        }

        private void collegeSaving4_TextChanged(object sender, EventArgs e)
        {
            collegeSaving4.Text = collegeSaving4.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                collegeTotal.Text = string.Format("{0:C2}",Convert.ToDouble(collegeSaving1.Text.Trim('$')) + Convert.ToDouble(collegeSaving2.Text.Trim('$')) + Convert.ToDouble(collegeSaving3.Text.Trim('$')) + Convert.ToDouble(collegeSaving4.Text.Trim('$')));
            }
            catch (Exception) { }
        }
        private void preTNum1_TextChanged(object sender, EventArgs e)
        {
            preTNum1.Text = preTNum1.Text.Trim(','); // removing the , so the update wont though an erro! 

            try
            {
                preTaxTotal.Text = string.Format("{0:C2}", Convert.ToDouble(preTNum1.Text.Trim('$')) + Convert.ToDouble(preTNum2.Text.Trim('$'))+ Convert.ToDouble(preTNum3.Text.Trim('$'))+ Convert.ToDouble(preTNum4.Text.Trim('$'))+ Convert.ToDouble(preTNum5.Text.Trim('$'))+ Convert.ToDouble(preTNum6.Text.Trim('$')));
            }
            catch (Exception) { }

        }

        private void preTNum2_TextChanged(object sender, EventArgs e)
        {
            preTNum2.Text = preTNum2.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                preTaxTotal.Text = string.Format("{0:C2}", Convert.ToDouble(preTNum1.Text.Trim('$')) + Convert.ToDouble(preTNum2.Text.Trim('$')) + Convert.ToDouble(preTNum3.Text.Trim('$')) + Convert.ToDouble(preTNum4.Text.Trim('$')) + Convert.ToDouble(preTNum5.Text.Trim('$')) + Convert.ToDouble(preTNum6.Text.Trim('$')));

            }
            catch (Exception) { }
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void preTNum3_TextChanged(object sender, EventArgs e)
        {
            preTNum3.Text = preTNum3.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                preTaxTotal.Text = string.Format("{0:C2}", Convert.ToDouble(preTNum1.Text.Trim('$')) + Convert.ToDouble(preTNum2.Text.Trim('$')) + Convert.ToDouble(preTNum3.Text.Trim('$')) + Convert.ToDouble(preTNum4.Text.Trim('$')) + Convert.ToDouble(preTNum5.Text.Trim('$')) + Convert.ToDouble(preTNum6.Text.Trim('$')));

            }
            catch (Exception) { }

        }

        private void preTNum4_TextChanged(object sender, EventArgs e)
        {
            preTNum4.Text = preTNum4.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                preTaxTotal.Text = string.Format("{0:C2}", Convert.ToDouble(preTNum1.Text.Trim('$')) + Convert.ToDouble(preTNum2.Text.Trim('$')) + Convert.ToDouble(preTNum3.Text.Trim('$')) + Convert.ToDouble(preTNum4.Text.Trim('$')) + Convert.ToDouble(preTNum5.Text.Trim('$')) + Convert.ToDouble(preTNum6.Text.Trim('$')));

            }
            catch (Exception) { }
        }

        private void preTNum5_TextChanged(object sender, EventArgs e)
        {
            preTNum5.Text = preTNum5.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                preTaxTotal.Text = string.Format("{0:C2}", Convert.ToDouble(preTNum1.Text.Trim('$')) + Convert.ToDouble(preTNum2.Text.Trim('$')) + Convert.ToDouble(preTNum3.Text.Trim('$')) + Convert.ToDouble(preTNum4.Text.Trim('$')) + Convert.ToDouble(preTNum5.Text.Trim('$')) + Convert.ToDouble(preTNum6.Text.Trim('$')));

            }
            catch (Exception) { }
        }

        private void preTNum6_TextChanged(object sender, EventArgs e)
        {
            preTNum6.Text = preTNum6.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                preTaxTotal.Text = string.Format("{0:C2}", Convert.ToDouble(preTNum1.Text.Trim('$')) + Convert.ToDouble(preTNum2.Text.Trim('$')) + Convert.ToDouble(preTNum3.Text.Trim('$')) + Convert.ToDouble(preTNum4.Text.Trim('$')) + Convert.ToDouble(preTNum5.Text.Trim('$')) + Convert.ToDouble(preTNum6.Text.Trim('$')));

            }
            catch (Exception) { }
        }

        private void mortga_TextChanged(object sender, EventArgs e)
        {
            mortga.Text = mortga.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                theDebts.Text = string.Format("{0:C2}",Convert.ToDouble(mortga.Text.Trim('$')) + Convert.ToDouble(homeEq.Text.Trim('$')) + Convert.ToDouble(carLoan.Text.Trim('$')) + Convert.ToDouble(personalLoan.Text.Trim('$')) + Convert.ToDouble(cC.Text.Trim('$')) + Convert.ToDouble(otherDebts.Text.Trim('$')));
            }
            catch (Exception) { }

        }

        private void homeEq_TextChanged(object sender, EventArgs e)
        {
            homeEq.Text = homeEq.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                theDebts.Text = string.Format("{0:C2}",Convert.ToDouble(mortga.Text.Trim('$')) + Convert.ToDouble(homeEq.Text.Trim('$')) + Convert.ToDouble(carLoan.Text.Trim('$')) + Convert.ToDouble(personalLoan.Text.Trim('$')) + Convert.ToDouble(cC.Text.Trim('$')) + Convert.ToDouble(otherDebts.Text.Trim('$')));
            }
            catch (Exception) { }
        }

        private void personalLoan_TextChanged(object sender, EventArgs e)
        {
            personalLoan.Text = personalLoan.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                theDebts.Text = string.Format("{0:C2}",Convert.ToDouble(mortga.Text.Trim('$')) + Convert.ToDouble(homeEq.Text.Trim('$')) + Convert.ToDouble(carLoan.Text.Trim('$')) + Convert.ToDouble(personalLoan.Text.Trim('$')) + Convert.ToDouble(cC.Text.Trim('$')) + Convert.ToDouble(otherDebts.Text.Trim('$')));
            }
            catch (Exception) { }
        }

        private void cC_TextChanged(object sender, EventArgs e)
        {
            cC.Text = cC.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                theDebts.Text = string.Format("{0:C2}",Convert.ToDouble(mortga.Text.Trim('$')) + Convert.ToDouble(homeEq.Text.Trim('$')) + Convert.ToDouble(carLoan.Text.Trim('$')) + Convert.ToDouble(personalLoan.Text.Trim('$')) + Convert.ToDouble(cC.Text.Trim('$')) + Convert.ToDouble(otherDebts.Text.Trim('$')));
            }
            catch (Exception) { }
        }

        private void otherDebts_TextChanged(object sender, EventArgs e)
        {
            otherDebts.Text = otherDebts.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                theDebts.Text = string.Format("{0:C2}",Convert.ToDouble(mortga.Text.Trim('$')) + Convert.ToDouble(homeEq.Text.Trim('$')) + Convert.ToDouble(carLoan.Text.Trim('$')) + Convert.ToDouble(personalLoan.Text.Trim('$')) + Convert.ToDouble(cC.Text.Trim('$')) + Convert.ToDouble(otherDebts.Text.Trim('$')));
            }
            catch (Exception) { }
        }

        private void rentMortage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void realEstateT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void healthINSUR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 

        }

        private void denDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void perscript_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals ;
        }

        private void giving_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void livingExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void clientPreTaxSavings_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void spoucePreTaxSaving_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

            private void empMatch_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void roth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void otherInvestmentSaving_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

        private void empMatch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void otherInvestmentSaving_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void pAtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void pAtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void preTaxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void pensionPValue6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pensionAge6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pensionPValue6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         //   textBox2.Text = textBox2.Text.Trim(','); // removing the , so the update wont though an erro! 

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {/*
            try
            {
                textBox2.Text = string.Format("{0:C2}", double.Parse(textBox2.Text.Trim('$'))); // upding after leaving the textbox
                
            }
            catch
            {
               
            }
            */
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
         
        }

        private void pensionName2_TextChanged(object sender, EventArgs e)
        {

        }
       

       

        private void clientDRage_TextChanged(object sender, EventArgs e)
        {
            
        }




        private void rentMortage_Leave(object sender, EventArgs e)
        {
           try
            {
                rentMortage.Text = string.Format("{0:C2}", double.Parse(rentMortage.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void healthINSUR_Leave(object sender, EventArgs e)
        {
            try
            {
                healthINSUR.Text = string.Format("{0:C2}", double.Parse(healthINSUR.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void realEstateT_Leave(object sender, EventArgs e)
        {
            try
            {
                realEstateT.Text = string.Format("{0:C2}", double.Parse(realEstateT.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void denDoc_Leave(object sender, EventArgs e)
        {
            try
            {
                denDoc.Text = string.Format("{0:C2}", double.Parse(denDoc.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void perscript_Leave(object sender, EventArgs e)
        {
            try
            {
                perscript.Text = string.Format("{0:C2}", double.Parse(perscript.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void giving_Leave(object sender, EventArgs e)
        {
            try
            {
                vactionSavings.Text = string.Format("{0:C2}", double.Parse(vactionSavings.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void livingExp_Leave(object sender, EventArgs e)
        {
            try
            {
                livingExp.Text = string.Format("{0:C2}", double.Parse(livingExp.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void clientPreTaxSavings_Leave(object sender, EventArgs e)
        {
            try
            {
                clientPreTaxSavings.Text = string.Format("{0:C2}", double.Parse(clientPreTaxSavings.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void spoucePreTaxSaving_Leave(object sender, EventArgs e)
        {
            try
            {
                spoucePreTaxSaving.Text = string.Format("{0:C2}", double.Parse(spoucePreTaxSaving.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void empMatch_Leave(object sender, EventArgs e)
        {
            try
            {
                empMatch.Text = string.Format("{0:C2}", double.Parse(empMatch.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void roth_Leave(object sender, EventArgs e)
        {
            try
            {
                roth.Text = string.Format("{0:C2}", double.Parse(roth.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void otherInvestmentSaving_Leave(object sender, EventArgs e)
        {
            try
            {
                otherInvestmentSaving.Text = string.Format("{0:C2}", double.Parse(otherInvestmentSaving.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void checkingSaving_Leave(object sender, EventArgs e)
        {
            try
            {
                checkingSaving.Text = string.Format("{0:C2}", double.Parse(checkingSaving.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void moneyMark_Leave(object sender, EventArgs e)
        {
            try
            {
                moneyMark.Text = string.Format("{0:C2}", double.Parse(moneyMark.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void phome_Leave(object sender, EventArgs e)
        {
            try
            {
                phome.Text = string.Format("{0:C2}", double.Parse(phome.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void vHome_Leave(object sender, EventArgs e)
        {
            try
            {
                vHome.Text = string.Format("{0:C2}", double.Parse(vHome.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void pAssestNum1_Leave(object sender, EventArgs e)
        {
            try
            {
                pAssestNum1.Text = string.Format("{0:C2}", double.Parse(pAssestNum1.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void pAssestNum2_Leave(object sender, EventArgs e)
        {
            try
            {
                pAssestNum2.Text = string.Format("{0:C2}", double.Parse(pAssestNum2.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void preTNum1_Leave(object sender, EventArgs e)
        {
            try
            {
                preTNum1.Text = string.Format("{0:C2}", double.Parse(preTNum1.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void preTNum2_Leave(object sender, EventArgs e)
        {
            try
            {
                preTNum2.Text = string.Format("{0:C2}", double.Parse(preTNum2.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void preTNum3_Leave(object sender, EventArgs e)
        {
            try
            {
                preTNum3.Text = string.Format("{0:C2}", double.Parse(preTNum3.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void preTNum4_Leave(object sender, EventArgs e)
        {
            try
            {
                preTNum4.Text = string.Format("{0:C2}", double.Parse(preTNum4.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void preTNum5_Leave(object sender, EventArgs e)
        {
            try
            {
                preTNum5.Text = string.Format("{0:C2}", double.Parse(preTNum5.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void preTNum6_Leave(object sender, EventArgs e)
        {
            try
            {
                preTNum6.Text = string.Format("{0:C2}", double.Parse(preTNum6.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void afterTNum1_Leave(object sender, EventArgs e)
        {
            try
            {
                afterTNum1.Text = string.Format("{0:C2}", double.Parse(afterTNum1.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void afterTNum2_Leave(object sender, EventArgs e)
        {
            try
            {
                afterTNum2.Text = string.Format("{0:C2}", double.Parse(afterTNum2.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void afterTNum3_Leave(object sender, EventArgs e)
        {
            try
            {
                afterTNum3.Text = string.Format("{0:C2}", double.Parse(afterTNum3.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void afterTNum4_Leave(object sender, EventArgs e)
        {
            try
            {
                afterTNum4.Text = string.Format("{0:C2}", double.Parse(afterTNum4.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void afterTNum5_Leave(object sender, EventArgs e)
        {
            try
            {
                afterTNum5.Text = string.Format("{0:C2}", double.Parse(afterTNum5.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void afterTNum6_Leave(object sender, EventArgs e)
        {
            try
            {
                afterTNum6.Text = string.Format("{0:C2}", double.Parse(afterTNum6.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void mortga_Leave(object sender, EventArgs e)
        {
            try
            {
                mortga.Text = string.Format("{0:C2}", double.Parse(mortga.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void homeEq_Leave(object sender, EventArgs e)
        {
            try
            {
                homeEq.Text = string.Format("{0:C2}", double.Parse(homeEq.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void carLoan_Leave(object sender, EventArgs e)
        {
            try
            {
                carLoan.Text = string.Format("{0:C2}", double.Parse(carLoan.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void personalLoan_Leave(object sender, EventArgs e)
        {
            try
            {
                personalLoan.Text = string.Format("{0:C2}", double.Parse(personalLoan.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void cC_Leave(object sender, EventArgs e)
        {
            try
            {
                cC.Text = string.Format("{0:C2}", double.Parse(cC.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void otherDebts_Leave(object sender, EventArgs e)
        {
            try
            {
                otherDebts.Text = string.Format("{0:C2}", double.Parse(otherDebts.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void collegeSaving1_Leave(object sender, EventArgs e)
        {
            try
            {
                collegeSaving1.Text = string.Format("{0:C2}", double.Parse(otherDebts.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void collegeSaving2_Leave(object sender, EventArgs e)
        {
            try
            {
                collegeSaving2.Text = string.Format("{0:C2}", double.Parse(otherDebts.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void collegeSaving3_Leave(object sender, EventArgs e)
        {
            try
            {
                collegeSaving3.Text = string.Format("{0:C2}", double.Parse(otherDebts.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void collegeSaving4_Leave(object sender, EventArgs e)
        {
            try
            {
                collegeSaving4.Text = string.Format("{0:C2}", double.Parse(otherDebts.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void clientAnnualS_TextChanged(object sender, EventArgs e)
        {
            clientAnnualS.Text = clientAnnualS.Text.Trim(',');
        }

        private void clientAnnualS_Leave(object sender, EventArgs e)
        {
            try
            {
                clientAnnualS.Text = string.Format("{0:C2}", double.Parse(clientAnnualS.Text.Trim('$'))); // upding after leaving the textbox
            }
            catch { }
        }

        private void spouceAnnualS_TextChanged(object sender, EventArgs e)
        {
            spouceAnnualS.Text = spouceAnnualS.Text.Trim(',');

        }

        private void spouceAnnualS_Leave(object sender, EventArgs e)
        {
            try
            {
                spouceAnnualS.Text = string.Format("{0:C2}", double.Parse(spouceAnnualS.Text.Trim('$'))); // upding after leaving the textbox
            }
            catch { }
        }

        private void clientMI_TextChanged(object sender, EventArgs e)
        {
            clientMI.Text = clientMI.Text.Trim(',');

        }

        private void clientMI_Leave(object sender, EventArgs e)
        {
            try
            {
                clientMI.Text = string.Format("{0:C2}", double.Parse(clientMI.Text.Trim('$'))); // upding after leaving the textbox
            }
            catch { }
        }

        private void spouceMI_TextChanged(object sender, EventArgs e)
        {
            spouceMI.Text = spouceMI.Text.Trim(',');

        }

        private void spouceMI_Leave(object sender, EventArgs e)
        {
            try
            {
                spouceMI.Text = string.Format("{0:C2}", double.Parse(spouceMI.Text.Trim('$'))); // upding after leaving the textbox
            }
            catch { }
        }

        private void ClientSS_TextChanged(object sender, EventArgs e)
        {
            ClientSS.Text = ClientSS.Text.Trim(',');

        }

        private void ClientSS_Leave(object sender, EventArgs e)
        {try
            {
                ClientSS.Text = string.Format("{0:C2}", double.Parse(ClientSS.Text.Trim('$'))); // upding after leaving the textbox
            }
            catch { }
        }

        private void spouceSS_TextChanged(object sender, EventArgs e)
        {
            spouceSS.Text = spouceSS.Text.Trim(',');

        }

        private void spouceSS_Leave(object sender, EventArgs e)
        {
            try
            {
                spouceSS.Text = string.Format("{0:C2}", double.Parse(spouceSS.Text.Trim('$'))); // upding after leaving the textbox
            }
            catch { }
        }

        private void clientage_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = !char.IsDigit(e.KeyChar) &&  !char.IsControl(e.KeyChar);// only alowing numbers

        }

        private void spouceAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);// only alowing numbers

        }

        private void clientAnnualS_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void spouceAnnualS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void clientAnnualS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void clientMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void spouceMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void clientDRage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void spouceDRage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void clientDSSAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void spouceDSSAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void clientDPAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void spouceDPAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void pensionAge1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void pensionAge2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void pensionAge4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void pensionAge5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        private void pensionAge6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 
        }

        

        private void spoucePTR_ValueChanged(object sender, EventArgs e)
        {

        }

      

        private void clientBithday_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime cdob = Convert.ToDateTime(clientBithday.Text);

                int years = todayT.Year - cdob.Year;
                int months = todayT.Month - cdob.Month;
                double year, m = 0;

                if ((todayT.Month - cdob.Month >= 0 && todayT.Day - cdob.Day >= 0))
                    year = years;
                else
                    year = years - 1;

                if (todayT.Month - cdob.Month < 0)
                {
                    m = (12 + (todayT.Month - cdob.Month));
                    m = m / 12;
                }
                else if (todayT.Month - cdob.Month > 0)
                {
                    m = -12 + (todayT.Month - cdob.Month);
                    m = m / 12;
                    m = m + 1;
                }
                else if (todayT.Month == cdob.Month && todayT.Day - cdob.Day < 0)
                    m = .98;
                else
                    m = 0;

                clientage.Text = string.Format("{0:0.00}", (year + m));

            }
            catch { }

        }

    

        private void spouceEMP_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 

        }

        private void spouceEMP_Leave(object sender, EventArgs e)
        {
            try
            {
                spouceEMP.Text = string.Format("{0:C2}", double.Parse(spouceEMP.Text.Trim('$'))); // upding after leaving the textbox

            }
            catch
            {

            }
        }

        private void pensionAge1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pensionPValue1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientPTR_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox11_Click(object sender, EventArgs e)
        {
            afterTNum1.Text = afterTNum1.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                if (checkBox11.Checked == true)
                    p1 = Convert.ToDouble(afterTNum1.Text.Trim('$'));
                else
                    p1 = 0;
                afterTInTotal.Text = string.Format("{0:C2}", p1 + p2 + p3 + p4 + p5 + p6);
            }
            catch (Exception) { }
        }

        private void checkBox12_Click(object sender, EventArgs e)
        {
            afterTNum2.Text = afterTNum2.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                if (checkBox12.Checked == true)
                    p2 = Convert.ToDouble(afterTNum2.Text.Trim('$'));
                else
                    p2 = 0;
                afterTInTotal.Text = string.Format("{0:C2}", p1 + p2 + p3 + p4 + p5 + p6);
            }
            catch (Exception) { }
        }

        private void checkBox13_Click(object sender, EventArgs e)
        {
            afterTNum3.Text = afterTNum3.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                if (checkBox13.Checked == true)
                    p3 = Convert.ToDouble(afterTNum3.Text.Trim('$'));
                else
                    p3 = 0;
                afterTInTotal.Text = string.Format("{0:C2}", p1 + p2 + p3 + p4 + p5 + p6);
            }
            catch (Exception) { }
        }

        private void checkBox14_Click(object sender, EventArgs e)
        {
            afterTNum4.Text = afterTNum4.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                if (checkBox14.Checked == true)
                    p4 = Convert.ToDouble(afterTNum4.Text.Trim('$'));
                else
                    p4 = 0;
                afterTInTotal.Text = string.Format("{0:C2}", p1 + p2 + p3 + p4 + p5 + p6);
            }
            catch (Exception) { }
        }

        private void checkBox15_Click(object sender, EventArgs e)
        {
            afterTNum5.Text = afterTNum5.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                if (checkBox15.Checked == true)
                    p5 = Convert.ToDouble(afterTNum5.Text.Trim('$'));
                else
                    p5 = 0;
                afterTInTotal.Text = string.Format("{0:C2}", p1 + p2 + p3 + p4 + p5 + p6);
            }
            catch (Exception) { }
        }

        private void spouceAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Anuity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);// only alowing numbers and decimals 

        }

        private void Anuity_Leave(object sender, EventArgs e)
        {
            try
            {
                Anuity.Text = string.Format("{0:C2}", double.Parse(Anuity.Text.Trim('$'))); // upding after leaving the textbox
            }
            catch { }
        }

        private void metroSetTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void metroSetTabControl1_CursorChanged(object sender, EventArgs e)
        {
            page1ofInputs.Cursor = Cursors.Hand;
            Cursor.Current = Cursors.Hand;

        }

        private void page1ofInputs_Click(object sender, EventArgs e)
        {
            page1ofInputs.Cursor = Cursors.Hand;

            Cursor.Current = Cursors.Hand;

        }

        private void metroSetTabPage3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;

        }

        private void checkBox16_Click(object sender, EventArgs e)
        {
            afterTNum6.Text = afterTNum6.Text.Trim(','); // removing the , so the update wont though an erro! 
            try
            {
                if (checkBox16.Checked == true)
                    p6 = Convert.ToDouble(afterTNum6.Text.Trim('$'));
                else
                    p6 = 0;
                afterTInTotal.Text = string.Format("{0:C2}", p1 + p2 + p3 + p4 + p5 + p6);
            }
            catch (Exception) { }
        }

        private void afterTName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void spouceBirthday_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime cdob = Convert.ToDateTime(spouceBirthday.Text);

                int years = todayT.Year - cdob.Year;
                int months = todayT.Month - cdob.Month;
                double year, m=0;

                if ((todayT.Month - cdob.Month >= 0 && todayT.Day - cdob.Day >= 0))
                    year = years;
                else
                    year = years - 1;

                if (todayT.Month - cdob.Month < 0)
                {
                    m = (12 + (todayT.Month - cdob.Month));
                    m = m / 12;
                }
                else if (todayT.Month - cdob.Month > 0)
                {
                    m = -12 + (todayT.Month - cdob.Month);
                    m =  m / 12;
                    m = m + 1;
                }
                else if (todayT.Month == cdob.Month && todayT.Day - cdob.Day < 0)
                    m = .98;
                else
                    m = 0;

                spouceAge.Text = string.Format("{0:0.00}",(year+m));

            }
            catch { }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void spouceName_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
