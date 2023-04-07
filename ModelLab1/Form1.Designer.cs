namespace ModelLab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.firstChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.secondChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.distributionFirst = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.distributionSecond = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.distribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.density = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.firstChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondChart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distributionFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributionSecond)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.density)).BeginInit();
            this.SuspendLayout();
            // 
            // firstChart
            // 
            chartArea1.Name = "ChartArea1";
            this.firstChart.ChartAreas.Add(chartArea1);
            legend1.ItemColumnSpacing = 90;
            legend1.Name = "Legend1";
            this.firstChart.Legends.Add(legend1);
            this.firstChart.Location = new System.Drawing.Point(0, 394);
            this.firstChart.Name = "firstChart";
            this.firstChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Метод преобразования";
            this.firstChart.Series.Add(series1);
            this.firstChart.Size = new System.Drawing.Size(999, 395);
            this.firstChart.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Функция плотности";
            this.firstChart.Titles.Add(title1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1015, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // secondChart
            // 
            chartArea2.Name = "ChartArea1";
            this.secondChart.ChartAreas.Add(chartArea2);
            legend2.ItemColumnSpacing = 90;
            legend2.Name = "Legend1";
            this.secondChart.Legends.Add(legend2);
            this.secondChart.Location = new System.Drawing.Point(-4, 6);
            this.secondChart.Name = "secondChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Legend = "Legend1";
            series2.MarkerSize = 2;
            series2.Name = "ЦПТ";
            this.secondChart.Series.Add(series2);
            this.secondChart.Size = new System.Drawing.Size(999, 395);
            this.secondChart.TabIndex = 3;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "Функция плотности";
            this.secondChart.Titles.Add(title2);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1230, 826);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.firstChart);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.secondChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1222, 797);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "функции плотности";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1026, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.distributionFirst);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.distributionSecond);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1222, 797);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "функции распределения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // distributionFirst
            // 
            chartArea3.Name = "ChartArea1";
            this.distributionFirst.ChartAreas.Add(chartArea3);
            legend3.ItemColumnSpacing = 90;
            legend3.Name = "Legend1";
            this.distributionFirst.Legends.Add(legend3);
            this.distributionFirst.Location = new System.Drawing.Point(-4, 406);
            this.distributionFirst.Name = "distributionFirst";
            this.distributionFirst.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Legend = "Legend1";
            series3.Name = "Метод преобразования";
            this.distributionFirst.Series.Add(series3);
            this.distributionFirst.Size = new System.Drawing.Size(999, 395);
            this.distributionFirst.TabIndex = 4;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "Title1";
            title3.Text = "Функция распределения";
            this.distributionFirst.Titles.Add(title3);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1026, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 73);
            this.button2.TabIndex = 5;
            this.button2.Text = "restart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // distributionSecond
            // 
            chartArea4.Name = "ChartArea1";
            this.distributionSecond.ChartAreas.Add(chartArea4);
            legend4.ItemColumnSpacing = 90;
            legend4.Name = "Legend1";
            this.distributionSecond.Legends.Add(legend4);
            this.distributionSecond.Location = new System.Drawing.Point(7, 20);
            this.distributionSecond.Name = "distributionSecond";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Legend = "Legend1";
            series4.MarkerSize = 2;
            series4.Name = "ЦПТ";
            this.distributionSecond.Series.Add(series4);
            this.distributionSecond.Size = new System.Drawing.Size(999, 395);
            this.distributionSecond.TabIndex = 6;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title1";
            title4.Text = "Функция распределения";
            this.distributionSecond.Titles.Add(title4);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.distribution);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.density);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1222, 797);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Общие гистограммы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // distribution
            // 
            chartArea5.Name = "ChartArea1";
            this.distribution.ChartAreas.Add(chartArea5);
            legend5.ItemColumnSpacing = 90;
            legend5.Name = "Legend1";
            this.distribution.Legends.Add(legend5);
            this.distribution.Location = new System.Drawing.Point(11, 382);
            this.distribution.Name = "distribution";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "ЦПТ";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series6.Legend = "Legend1";
            series6.Name = "Метод преобразования";
            this.distribution.Series.Add(series5);
            this.distribution.Series.Add(series6);
            this.distribution.Size = new System.Drawing.Size(999, 395);
            this.distribution.TabIndex = 7;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title5.Name = "Title1";
            title5.Text = "Функция распределения";
            this.distribution.Titles.Add(title5);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1026, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 73);
            this.button3.TabIndex = 8;
            this.button3.Text = "restart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // density
            // 
            chartArea6.Name = "ChartArea1";
            this.density.ChartAreas.Add(chartArea6);
            legend6.ItemColumnSpacing = 90;
            legend6.Name = "Legend1";
            this.density.Legends.Add(legend6);
            this.density.Location = new System.Drawing.Point(0, 3);
            this.density.Name = "density";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series7.Legend = "Legend1";
            series7.MarkerSize = 2;
            series7.Name = "ЦПТ";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Метод преобразования";
            this.density.Series.Add(series7);
            this.density.Series.Add(series8);
            this.density.Size = new System.Drawing.Size(999, 395);
            this.density.TabIndex = 9;
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title6.Name = "Title1";
            title6.Text = "Функция плотности";
            this.density.Titles.Add(title6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 826);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.firstChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondChart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.distributionFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributionSecond)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.distribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.density)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart firstChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart secondChart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart distributionFirst;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart distributionSecond;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart distribution;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart density;
        private System.Windows.Forms.Label label1;
    }
}

