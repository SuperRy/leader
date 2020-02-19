using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;

namespace Leadersoftware
{
    class excelhandlings
    {
        static List<String> input1 = new List<string>();
        static List<String> input2 = new List<string>();
        static bool button1WasClicked = false;
        static ExcelPackage excel;
        static OpenFileDialog openFile = new OpenFileDialog();
        static SaveFileDialog savingFile = new SaveFileDialog();
        static string key = "iethjp586578";


        public static void backUpInportMethod()
        {
            openFile.Filter = "Excel files (*.xlsx)|*.xlsx";
            openFile.Title = "Loading Client Data";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var filePath = openFile.FileName;
                FileInfo fileInfo = new FileInfo(filePath);
                excel = new ExcelPackage(fileInfo);
                var dataWorkSheet = excel.Workbook.Worksheets[1];
      //          try
    //            {
                    if (dataWorkSheet.Cells["R21"].Value.ToString() == "NULL" || dataWorkSheet.Cells["R21"].Value.ToString() == key)
                    {
                        button1WasClicked = true;
                        input1 = new List<string>();
                        int u = 1; 
                    /*
                        for (int i = dataWorkSheet.Dimension.Start.Column; i <= dataWorkSheet.Dimension.End.Column; i++)
                        {

                            input1[u] = dataWorkSheet.Cells["A"+y].Value.ToString();
                            y++;
                            u++;
                        }
                      */
                    //Leadersoftware.pass(input1);
                   // input1[y].Add(dataWorkSheet.Cells["A"+u].Value.ToString());
                    input1.Add(dataWorkSheet.Cells["A" + u].Value.ToString());
                    inputP ld = new inputP();

                    
                }
                else
                    {
                        System.Windows.Forms.MessageBox.Show("This is the wrong File!! Please try another File with corret Key");
                    }
  //              }
                //catch (Exception e)
                //{
                  //  System.Windows.Forms.MessageBox.Show(e.ToString());

//                }
            }
        }
        

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
    }
}
