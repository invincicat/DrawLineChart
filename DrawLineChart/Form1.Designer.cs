namespace DrawLineChart
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chtLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoadPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentLine = new System.Windows.Forms.TextBox();
            this.btnLastLine = new System.Windows.Forms.Button();
            this.btnNextLine = new System.Windows.Forms.Button();
            this.btnToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtLine)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chtLine
            // 
            chartArea1.Name = "ChartArea1";
            this.chtLine.ChartAreas.Add(chartArea1);
            this.chtLine.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chtLine.Legends.Add(legend1);
            this.chtLine.Location = new System.Drawing.Point(0, 0);
            this.chtLine.Name = "chtLine";
            this.chtLine.Size = new System.Drawing.Size(872, 580);
            this.chtLine.TabIndex = 1;
            this.chtLine.Text = "LineChart";
            this.chtLine.Click += new System.EventHandler(this.chtLine_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chtLine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(374, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 580);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.70376F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.29623F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1249, 586);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnToExcel);
            this.panel2.Controls.Add(this.btnLoadPath);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCurrentLine);
            this.panel2.Controls.Add(this.btnLastLine);
            this.panel2.Controls.Add(this.btnNextLine);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 580);
            this.panel2.TabIndex = 3;
            // 
            // btnLoadPath
            // 
            this.btnLoadPath.Location = new System.Drawing.Point(3, 371);
            this.btnLoadPath.Name = "btnLoadPath";
            this.btnLoadPath.Size = new System.Drawing.Size(116, 37);
            this.btnLoadPath.TabIndex = 4;
            this.btnLoadPath.Text = "加载文件路径";
            this.btnLoadPath.UseVisualStyleBackColor = true;
            this.btnLoadPath.Click += new System.EventHandler(this.btnLoadPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "当前行：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCurrentLine
            // 
            this.txtCurrentLine.Location = new System.Drawing.Point(7, 231);
            this.txtCurrentLine.Name = "txtCurrentLine";
            this.txtCurrentLine.Size = new System.Drawing.Size(100, 25);
            this.txtCurrentLine.TabIndex = 2;
            this.txtCurrentLine.Text = "1";
            this.txtCurrentLine.TextChanged += new System.EventHandler(this.txtCurrentLine_TextChanged);
            // 
            // btnLastLine
            // 
            this.btnLastLine.Location = new System.Drawing.Point(0, 82);
            this.btnLastLine.Name = "btnLastLine";
            this.btnLastLine.Size = new System.Drawing.Size(80, 54);
            this.btnLastLine.TabIndex = 1;
            this.btnLastLine.Text = "上一行";
            this.btnLastLine.UseVisualStyleBackColor = true;
            this.btnLastLine.Click += new System.EventHandler(this.btnLastLine_Click);
            // 
            // btnNextLine
            // 
            this.btnNextLine.Location = new System.Drawing.Point(0, 0);
            this.btnNextLine.Name = "btnNextLine";
            this.btnNextLine.Size = new System.Drawing.Size(80, 54);
            this.btnNextLine.TabIndex = 0;
            this.btnNextLine.Text = "下一行";
            this.btnNextLine.UseVisualStyleBackColor = true;
            this.btnNextLine.Click += new System.EventHandler(this.btnNextLine_Click);
            // 
            // btnToExcel
            // 
            this.btnToExcel.Location = new System.Drawing.Point(7, 448);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(100, 37);
            this.btnToExcel.TabIndex = 4;
            this.btnToExcel.Text = "导入excel";
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 586);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtLine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chtLine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentLine;
        private System.Windows.Forms.Button btnLastLine;
        private System.Windows.Forms.Button btnNextLine;
        private System.Windows.Forms.Button btnLoadPath;
        private System.Windows.Forms.Button btnToExcel;
    }
}

