using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace DrawLineChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStrat_Click(object sender, EventArgs e)
        {





        }

        private void chtLine_Click(object sender, EventArgs e)
        {

        }


        public static int Line = 1;
        public static string strPath = @"C:\123.txt";


        private void Form1_Load(object sender, EventArgs e)
        {

            chtLine.Series.Add("X坐标");
            chtLine.Series.Add("Y坐标");

            ShowLine();

            //string[] strs2 = File.ReadAllLines(strPath);
            //// 也可以指定编码方式 
            ////string[] strs2 = File.ReadAllLines(@"C:\Users\SK-ED\Desktop\123.txt", Encoding.ASCII);

            //int n = strs2.Length;

            //////清空表格中的数据
            ////foreach (var series in chtLine.Series)
            ////{
            ////    series.Points.Clear();
            ////    //series.DeleteCustomProperty("0-Xa");
            ////    //series.;

            ////}


            //for (int i = 0; i < 1; i++)
            //{
            //    string tempA = strs2[i + Form1.Line - 1];

            //    string[] vs = tempA.Split('T');
            //    string tempD = vs[1];

            //    string tempB = tempD.Remove(0, 8);
            //    string[] tempC = tempB.Split(';');

            //    double[] tempNumD = new double[72];

            //    //字符串类型数组转double类型数组
            //    for (int m = 0; m < tempC.Length - 1; m++)
            //    {
            //        tempNumD[m] = double.Parse(tempC[m]);

            //    }

            //    double[] X = new double[36];
            //    double[] Y = new double[36];
            //    for (int q = 0; q < 36; q++)
            //    {

            //        X[q] = tempNumD[2 * q];
            //        Y[q] = tempNumD[2 * q + 1];
            //    }



            //    double[] diffXa = new double[36];
            //    double[] diffXb = new double[18];

            //    double[] diffYa = new double[36];
            //    double[] diffYb = new double[18];

            //    for (int k = 0; k < 18; k++)
            //    {
            //        diffXa[k] = X[k] - X[0] + k * 32.2;
            //        diffXa[k+18] = X[k + 18] - X[18] + k * 32.2;

            //        diffYa[k] = Y[k] - Y[0];
            //        diffYa[k+18] = Y[k + 18] - Y[18];


            //    }






            //    double[] xData = {  1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36 };


            //    chtLine.ChartAreas[0].AxisX.Interval = 1;

            //    chtLine.Series.Add(i.ToString() + "-Xa");
            //    chtLine.Series[4 * i].ChartType = SeriesChartType.Line;//设置为折线
            //    chtLine.Series[4 * i].Points.DataBindXY(xData, diffXa);
            //    chtLine.Series[4 * i].BorderWidth = 1; //折线粗细
            //    chtLine.Series[4 * i].Color = System.Drawing.Color.Red;//设置折线颜色                                         

            //    //chtLine.Series.Add(i.ToString() + "-Xb");
            //    //chtLine.Series[4 * i + 1].ChartType = SeriesChartType.Line;
            //    //chtLine.Series[4 * i + 1].Points.DataBindXY(xData, diffXb);
            //    //chtLine.Series[4 * i + 1].BorderWidth = 1;
            //    //chtLine.Series[4 * i + 1].Color = System.Drawing.Color.Black;//设置折线颜色                                         



            //    chtLine.Series.Add(i.ToString() + "-Ya");
            //    chtLine.Series[4 * i + 1].ChartType = SeriesChartType.Line;
            //    chtLine.Series[4 * i + 1].Points.DataBindXY(xData, diffYa);
            //    chtLine.Series[4 * i + 1].BorderWidth = 1;
            //    chtLine.Series[4 * i + 1].Color = System.Drawing.Color.Blue;//设置折线颜色                                         



            //    //chtLine.Series.Add(i.ToString() + "-Yb");
            //    //chtLine.Series[4 * i + 3].ChartType = SeriesChartType.Line;
            //    //chtLine.Series[4 * i + 3].Points.DataBindXY(xData, diffYb);
            //    //chtLine.Series[4 * i + 3].BorderWidth = 1;
            //    //chtLine.Series[4 * i + 3].Color = System.Drawing.Color.Green;//设置折线颜色                                         





        }

        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLastLine_Click(object sender, EventArgs e)
        {
            Form1.Line--;
            ShowLine();
            txtCurrentLine.Text = ((Form1.Line)).ToString();
        }

        private void btnNextLine_Click(object sender, EventArgs e)
        {
            Form1.Line++;
            ShowLine();
            txtCurrentLine.Text = ((Form1.Line)).ToString();
        }

        private void txtCurrentLine_TextChanged(object sender, EventArgs e)
        {

        }



        //double[] X = ;
        public static double[] X = new double[36];
        public static double[] Y = new double[36];
        public static double[] diffXa = new double[36];
        //double[] diffXb = new double[36];

        public static double[] diffYa = new double[36];
        //double[] diffYb = new double[36];

        public void ShowLine()
        {
            string[] strs2 = File.ReadAllLines(strPath);
            // 也可以指定编码方式 
            //string[] strs2 = File.ReadAllLines(@"C:\Users\SK-ED\Desktop\123.txt", Encoding.ASCII);

            int n = strs2.Length;

            //清空表格中的数据
            foreach (var series in chtLine.Series)
            {
                series.Points.Clear();

            }

            if (Form1.Line > n)
            {
                Form1.Line = 1;
            }


            int i = 0;
            string tempA = strs2[i + Form1.Line - 1];

            string[] vs = tempA.Split('T');
            string tempD = vs[1];

            string tempB = tempD.Remove(0, 8);
            string[] tempC = tempB.Split(';');

            double[] tempNumD = new double[72];

            //字符串类型数组转double类型数组
            for (int m = 0; m < tempC.Length - 1; m++)
            {
                tempNumD[m] = double.Parse(tempC[m]);

            }

            //double[] X = new double[36];
            //double[] Y = new double[36];
            for (int q = 0; q < 36; q++)
            {

                X[q] = tempNumD[2 * q];
                Y[q] = tempNumD[2 * q + 1];
            }



            //double[] diffXa = new double[36];
            //double[] diffXb = new double[36];

            //double[] diffYa = new double[36];
            //double[] diffYb = new double[36];

            for (int k = 0; k < 18; k++)
            {
                diffXa[k] = X[k] - X[0] + k * 32.2;
                diffXa[k + 18] = X[k + 18] - X[18] + k * 32.2;

                diffYa[k] = Y[k] - Y[0];
                diffYa[k + 18] = Y[k + 18] - Y[18];


            }


            double[] xData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };


            chtLine.ChartAreas[0].AxisX.Interval = 1;

            //chtLine.Series.Add(i.ToString() + "-Xa");           
            chtLine.Series[4 * i].ChartType = SeriesChartType.Line;//设置为折线
            chtLine.Series[4 * i].Points.DataBindXY(xData, diffXa);
            chtLine.Series[4 * i].BorderWidth = 1; //折线粗细
            chtLine.Series[4 * i].Color = System.Drawing.Color.Red;//设置折线颜色                                         

            ////chtLine.Series.Add(i.ToString() + "-Xb");
            //chtLine.Series[4 * i + 1].ChartType = SeriesChartType.Line;
            //chtLine.Series[4 * i + 1].Points.DataBindXY(xData, diffXb);
            //chtLine.Series[4 * i + 1].BorderWidth = 1;
            //chtLine.Series[4 * i + 1].Color = System.Drawing.Color.Black;//设置折线颜色                                         



            //chtLine.Series.Add(i.ToString() + "-Ya");
            chtLine.Series[4 * i + 1].ChartType = SeriesChartType.Line;
            chtLine.Series[4 * i + 1].Points.DataBindXY(xData, diffYa);
            chtLine.Series[4 * i + 1].BorderWidth = 1;
            chtLine.Series[4 * i + 1].Color = System.Drawing.Color.Blue;//设置折线颜色                                         



            ////chtLine.Series.Add(i.ToString() + "-Yb");
            //chtLine.Series[4 * i + 3].ChartType = SeriesChartType.Line;
            //chtLine.Series[4 * i + 3].Points.DataBindXY(xData, diffYb);
            //chtLine.Series[4 * i + 3].BorderWidth = 1;
            //chtLine.Series[4 * i + 3].Color = System.Drawing.Color.Green;//设置折线颜色                                         




        }

        private void btnLoadPath_Click(object sender, EventArgs e)
        {
            //SelectedPath
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择*.vpp文件";
            ofd.InitialDirectory = @"C:\Users\SK-ED\Desktop";
            ofd.Multiselect = true;
            ofd.Filter = "|*.txt|所有文件|*.*";
            ofd.ShowDialog();
            //获得我们在文件夹中所选择的全路径
            string[] path = ofd.FileNames;
            Form1.strPath = path[0];
            //for (int i = 0; i < path.Length; i++)
            //{
            //    //将*.vpp文件的文件名加载到listbox中
            //    cbJobName.Items.Add(Path.GetFileName(path[i]));

            //    Program.SelectedPath = Path.GetFullPath(path[i]);
            //    cbJobName.SelectedItem = Path.GetFileName(path[i]);
            //}


        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            {
                //Excel表格存储路径
                string file = @"C:\abc.xls";

                //读取数据源文件，统计行数
                string[] strs2 = File.ReadAllLines(strPath);
                int n = strs2.Length;


                Excel.Application myexcelApplication = new Excel.Application();
                if (myexcelApplication != null)
                {
                    Excel.Workbook myexcelWorkbook = myexcelApplication.Workbooks.Add();
                    //for (int j = 0; j < n; j++)
                    //{

                    Excel.Worksheet myexcelWorksheet = (Excel.Worksheet)myexcelWorkbook.Sheets.Add();


                    //myexcelWorkbook.Sheets.Add();
                    //Excel.Worksheet myexcelWorksheet = (Excel.Worksheet)myexcelWorkbook.Sheets[j+1];

                    //
                    myexcelWorksheet.Cells.Select();




                        for (int i = 1; i <= 36; i++)
                        {
                            //设置列宽为10
                            myexcelWorksheet.Cells[i, 1].ColumnWidth = 10;
                            myexcelWorksheet.Cells[i, 2].ColumnWidth = 10;

                            //设置文本水平居中
                            myexcelWorksheet.Cells[i, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            myexcelWorksheet.Cells[i, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            myexcelWorksheet.Cells[i, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            myexcelWorksheet.Cells[i, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;


                            //设置数据格式为文本形式
                            myexcelWorksheet.Cells[i, 1].NumberFormatLocal = "@";
                            myexcelWorksheet.Cells[i, 2].NumberFormatLocal = "@";
                            myexcelWorksheet.Cells[i, 4].NumberFormatLocal = "@";
                            myexcelWorksheet.Cells[i, 5].NumberFormatLocal = "@";

                            //将数据传入表格，并设置小数点位数
                            myexcelWorksheet.Cells[i, 1] = X[i - 1].ToString("0.0000");
                            myexcelWorksheet.Cells[i, 2] = Y[i - 1].ToString("0.0000");
                            myexcelWorksheet.Cells[i, 4] = diffXa[i - 1].ToString("0.0000");
                            myexcelWorksheet.Cells[i, 5] = diffYa[i - 1].ToString("0.0000");
                        }

                    //}



                    //文件存在则删除
                    if (System.IO.File.Exists(Path.GetFullPath(file)))
                    {
                        File.Delete(Path.GetFullPath(file));
                    }

                    //保存文件
                    myexcelApplication.ActiveWorkbook.SaveAs(file, Excel.XlFileFormat.xlWorkbookNormal);

                    myexcelWorkbook.Close();
                    myexcelApplication.Quit();
                }
            }
        }
    }
}
