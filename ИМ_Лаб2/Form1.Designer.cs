namespace ИМ_Лаб2
{
    partial class Form_Сurrency
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Start = new System.Windows.Forms.Button();
            this.l_Euro = new System.Windows.Forms.Label();
            this.l_Dollar = new System.Windows.Forms.Label();
            this.el_Euro = new System.Windows.Forms.NumericUpDown();
            this.el_Dollar = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.el_Euro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Dollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Clear);
            this.panel1.Controls.Add(this.bt_Start);
            this.panel1.Controls.Add(this.l_Euro);
            this.panel1.Controls.Add(this.l_Dollar);
            this.panel1.Controls.Add(this.el_Euro);
            this.panel1.Controls.Add(this.el_Dollar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 85);
            this.panel1.TabIndex = 0;
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(671, 12);
            this.bt_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(170, 57);
            this.bt_Clear.TabIndex = 6;
            this.bt_Clear.Text = "Очистить";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(442, 12);
            this.bt_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(170, 57);
            this.bt_Start.TabIndex = 2;
            this.bt_Start.Text = "Старт";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // l_Euro
            // 
            this.l_Euro.AutoSize = true;
            this.l_Euro.Location = new System.Drawing.Point(156, 29);
            this.l_Euro.Name = "l_Euro";
            this.l_Euro.Size = new System.Drawing.Size(40, 17);
            this.l_Euro.TabIndex = 5;
            this.l_Euro.Text = "Евро";
            // 
            // l_Dollar
            // 
            this.l_Dollar.AutoSize = true;
            this.l_Dollar.Location = new System.Drawing.Point(19, 29);
            this.l_Dollar.Name = "l_Dollar";
            this.l_Dollar.Size = new System.Drawing.Size(59, 17);
            this.l_Dollar.TabIndex = 4;
            this.l_Dollar.Text = "Доллар";
            // 
            // el_Euro
            // 
            this.el_Euro.DecimalPlaces = 2;
            this.el_Euro.Location = new System.Drawing.Point(159, 47);
            this.el_Euro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.el_Euro.Name = "el_Euro";
            this.el_Euro.Size = new System.Drawing.Size(107, 22);
            this.el_Euro.TabIndex = 3;
            this.el_Euro.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // el_Dollar
            // 
            this.el_Dollar.DecimalPlaces = 2;
            this.el_Dollar.Location = new System.Drawing.Point(22, 47);
            this.el_Dollar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.el_Dollar.Name = "el_Dollar";
            this.el_Dollar.Size = new System.Drawing.Size(107, 22);
            this.el_Dollar.TabIndex = 2;
            this.el_Dollar.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 90);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Green;
            series5.IsValueShownAsLabel = true;
            series5.LabelFormat = "f4";
            series5.Legend = "Legend1";
            series5.Name = "Доллар";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Red;
            series6.IsValueShownAsLabel = true;
            series6.LabelFormat = "f4";
            series6.Legend = "Legend1";
            series6.Name = "Евро";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(900, 401);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form_Сurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 491);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Сurrency";
            this.Text = "Моделирование двух валют в реальном времени";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.el_Euro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Dollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_Euro;
        private System.Windows.Forms.Label l_Dollar;
        private System.Windows.Forms.NumericUpDown el_Euro;
        private System.Windows.Forms.NumericUpDown el_Dollar;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_Clear;
    }
}

