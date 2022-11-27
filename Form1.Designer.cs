namespace teorVer_2
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btn_modelling = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Count = new System.Windows.Forms.TextBox();
            this.DistributionParametr = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelParametr = new System.Windows.Forms.Label();
            this.ChartDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modelling
            // 
            this.btn_modelling.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_modelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_modelling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modelling.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_modelling.FlatAppearance.BorderSize = 0;
            this.btn_modelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modelling.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_modelling.Location = new System.Drawing.Point(447, 80);
            this.btn_modelling.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modelling.Name = "btn_modelling";
            this.btn_modelling.Size = new System.Drawing.Size(165, 38);
            this.btn_modelling.TabIndex = 0;
            this.btn_modelling.Text = "Моделировать";
            this.btn_modelling.UseVisualStyleBackColor = false;
            this.btn_modelling.Click += new System.EventHandler(this.btn_modelling_Click);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(173, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(347, 22);
            this.Title.TabIndex = 1;
            this.Title.Text = "Экспоненциальное распределение";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.Count);
            this.panel1.Controls.Add(this.DistributionParametr);
            this.panel1.Controls.Add(this.labelCount);
            this.panel1.Controls.Add(this.labelParametr);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(26, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 88);
            this.panel1.TabIndex = 2;
            // 
            // Count
            // 
            this.Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.Count.Location = new System.Drawing.Point(244, 50);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(100, 26);
            this.Count.TabIndex = 3;
            this.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Count_KeyPress);
            // 
            // DistributionParametr
            // 
            this.DistributionParametr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.DistributionParametr.Location = new System.Drawing.Point(244, 12);
            this.DistributionParametr.Name = "DistributionParametr";
            this.DistributionParametr.Size = new System.Drawing.Size(100, 26);
            this.DistributionParametr.TabIndex = 2;
            this.DistributionParametr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DistributionParametr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DistributionParametr_KeyPress);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCount.Location = new System.Drawing.Point(17, 53);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(204, 19);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "Количество испытаний:";
            // 
            // labelParametr
            // 
            this.labelParametr.AutoSize = true;
            this.labelParametr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelParametr.Location = new System.Drawing.Point(17, 15);
            this.labelParametr.Name = "labelParametr";
            this.labelParametr.Size = new System.Drawing.Size(221, 19);
            this.labelParametr.TabIndex = 0;
            this.labelParametr.Text = "Параметр распределения:\r\n";
            // 
            // ChartDistribution
            // 
            this.ChartDistribution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartDistribution.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ChartDistribution.BorderlineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.ChartDistribution.ChartAreas.Add(chartArea1);
            this.ChartDistribution.Location = new System.Drawing.Point(27, 165);
            this.ChartDistribution.Name = "ChartDistribution";
            this.ChartDistribution.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            series1.Name = "DistributionDensity";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Name = "IntegralFunction";
            this.ChartDistribution.Series.Add(series1);
            this.ChartDistribution.Series.Add(series2);
            this.ChartDistribution.Size = new System.Drawing.Size(626, 430);
            this.ChartDistribution.TabIndex = 3;
            this.ChartDistribution.Text = "Диаграмма распределения";
            title1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title";
            title1.Text = "График экспоненциального распеределения";
            this.ChartDistribution.Titles.Add(title1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(679, 620);
            this.Controls.Add(this.ChartDistribution);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btn_modelling);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2. Экспоненциальное распределение";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDistribution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modelling;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelParametr;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDistribution;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.TextBox DistributionParametr;
    }
}

