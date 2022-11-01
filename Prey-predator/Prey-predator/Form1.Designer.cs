namespace Prey_predator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea33 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend33 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series49 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series50 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea34 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend34 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series51 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.population_graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Calculate = new System.Windows.Forms.Button();
            this.label_c = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_d = new System.Windows.Forms.Label();
            this.label_y1 = new System.Windows.Forms.Label();
            this.label_y2 = new System.Windows.Forms.Label();
            this.label_h = new System.Windows.Forms.Label();
            this.label_T = new System.Windows.Forms.Label();
            this.text_a = new System.Windows.Forms.TextBox();
            this.text_c = new System.Windows.Forms.TextBox();
            this.text_b = new System.Windows.Forms.TextBox();
            this.text_d = new System.Windows.Forms.TextBox();
            this.text_y1 = new System.Windows.Forms.TextBox();
            this.text_T = new System.Windows.Forms.TextBox();
            this.text_h = new System.Windows.Forms.TextBox();
            this.text_y2 = new System.Windows.Forms.TextBox();
            this.dependency_graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_a = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.population_graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependency_graph)).BeginInit();
            this.SuspendLayout();
            // 
            // population_graph
            // 
            this.population_graph.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke;
            chartArea33.Name = "ChartArea1";
            this.population_graph.ChartAreas.Add(chartArea33);
            legend33.Name = "Legend1";
            this.population_graph.Legends.Add(legend33);
            this.population_graph.Location = new System.Drawing.Point(12, 12);
            this.population_graph.Name = "population_graph";
            series49.ChartArea = "ChartArea1";
            series49.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series49.Legend = "Legend1";
            series49.Name = "Жертвы";
            series50.ChartArea = "ChartArea1";
            series50.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series50.Legend = "Legend1";
            series50.Name = "Хищники";
            this.population_graph.Series.Add(series49);
            this.population_graph.Series.Add(series50);
            this.population_graph.Size = new System.Drawing.Size(528, 320);
            this.population_graph.TabIndex = 0;
            this.population_graph.Text = "chart1";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(700, 295);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(112, 37);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Расчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Location = new System.Drawing.Point(589, 41);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(223, 13);
            this.label_c.TabIndex = 4;
            this.label_c.Text = "Коэффициент увеличения числа хищников";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(573, 67);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(239, 13);
            this.label_b.TabIndex = 5;
            this.label_b.Text = "Коэффициент естественного прироста жертв";
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Location = new System.Drawing.Point(638, 93);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(174, 13);
            this.label_d.TabIndex = 6;
            this.label_d.Text = "Коэффициент смертности жертв";
            // 
            // label_y1
            // 
            this.label_y1.AutoSize = true;
            this.label_y1.Location = new System.Drawing.Point(649, 119);
            this.label_y1.Name = "label_y1";
            this.label_y1.Size = new System.Drawing.Size(163, 13);
            this.label_y1.TabIndex = 10;
            this.label_y1.Text = "Начальное колличество жертв";
            // 
            // label_y2
            // 
            this.label_y2.AutoSize = true;
            this.label_y2.Location = new System.Drawing.Point(630, 145);
            this.label_y2.Name = "label_y2";
            this.label_y2.Size = new System.Drawing.Size(182, 13);
            this.label_y2.TabIndex = 9;
            this.label_y2.Text = "Начальное колличество хищников";
            // 
            // label_h
            // 
            this.label_h.AutoSize = true;
            this.label_h.Location = new System.Drawing.Point(799, 171);
            this.label_h.Name = "label_h";
            this.label_h.Size = new System.Drawing.Size(13, 13);
            this.label_h.TabIndex = 8;
            this.label_h.Text = "h";
            // 
            // label_T
            // 
            this.label_T.AutoSize = true;
            this.label_T.Location = new System.Drawing.Point(798, 197);
            this.label_T.Name = "label_T";
            this.label_T.Size = new System.Drawing.Size(14, 13);
            this.label_T.TabIndex = 7;
            this.label_T.Text = "T";
            // 
            // text_a
            // 
            this.text_a.Location = new System.Drawing.Point(818, 12);
            this.text_a.Name = "text_a";
            this.text_a.Size = new System.Drawing.Size(112, 20);
            this.text_a.TabIndex = 11;
            this.text_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_a_KeyPress);
            // 
            // text_c
            // 
            this.text_c.Location = new System.Drawing.Point(818, 38);
            this.text_c.Name = "text_c";
            this.text_c.Size = new System.Drawing.Size(112, 20);
            this.text_c.TabIndex = 12;
            this.text_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_a_KeyPress);
            // 
            // text_b
            // 
            this.text_b.Location = new System.Drawing.Point(818, 64);
            this.text_b.Name = "text_b";
            this.text_b.Size = new System.Drawing.Size(112, 20);
            this.text_b.TabIndex = 13;
            this.text_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_a_KeyPress);
            // 
            // text_d
            // 
            this.text_d.Location = new System.Drawing.Point(818, 90);
            this.text_d.Name = "text_d";
            this.text_d.Size = new System.Drawing.Size(112, 20);
            this.text_d.TabIndex = 14;
            this.text_d.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_a_KeyPress);
            // 
            // text_y1
            // 
            this.text_y1.Location = new System.Drawing.Point(818, 116);
            this.text_y1.Name = "text_y1";
            this.text_y1.Size = new System.Drawing.Size(112, 20);
            this.text_y1.TabIndex = 15;
            this.text_y1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_a_KeyPress);
            // 
            // text_T
            // 
            this.text_T.Location = new System.Drawing.Point(818, 194);
            this.text_T.Name = "text_T";
            this.text_T.Size = new System.Drawing.Size(112, 20);
            this.text_T.TabIndex = 18;
            this.text_T.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_a_KeyPress);
            // 
            // text_h
            // 
            this.text_h.Location = new System.Drawing.Point(818, 168);
            this.text_h.Name = "text_h";
            this.text_h.Size = new System.Drawing.Size(112, 20);
            this.text_h.TabIndex = 17;
            this.text_h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_a_KeyPress);
            // 
            // text_y2
            // 
            this.text_y2.Location = new System.Drawing.Point(818, 142);
            this.text_y2.Name = "text_y2";
            this.text_y2.Size = new System.Drawing.Size(112, 20);
            this.text_y2.TabIndex = 16;
            this.text_y2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_a_KeyPress);
            // 
            // dependency_graph
            // 
            chartArea34.AxisX.Title = "Количество жертв";
            chartArea34.AxisY.Title = "Количество хищников";
            chartArea34.Name = "ChartArea2";
            this.dependency_graph.ChartAreas.Add(chartArea34);
            legend34.Name = "Legend1";
            this.dependency_graph.Legends.Add(legend34);
            this.dependency_graph.Location = new System.Drawing.Point(953, 12);
            this.dependency_graph.Name = "dependency_graph";
            series51.ChartArea = "ChartArea2";
            series51.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series51.Legend = "Legend1";
            series51.Name = "Хищник-Жертва";
            this.dependency_graph.Series.Add(series51);
            this.dependency_graph.Size = new System.Drawing.Size(528, 320);
            this.dependency_graph.TabIndex = 19;
            this.dependency_graph.Text = "chart2";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(546, 15);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(266, 13);
            this.label_a.TabIndex = 3;
            this.label_a.Text = "Коэффициент естественной смертности хищников";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1490, 346);
            this.Controls.Add(this.dependency_graph);
            this.Controls.Add(this.text_T);
            this.Controls.Add(this.text_h);
            this.Controls.Add(this.text_y2);
            this.Controls.Add(this.text_y1);
            this.Controls.Add(this.text_d);
            this.Controls.Add(this.text_b);
            this.Controls.Add(this.text_c);
            this.Controls.Add(this.text_a);
            this.Controls.Add(this.label_y1);
            this.Controls.Add(this.label_y2);
            this.Controls.Add(this.label_h);
            this.Controls.Add(this.label_T);
            this.Controls.Add(this.label_d);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.population_graph);
            this.MaximumSize = new System.Drawing.Size(1506, 385);
            this.MinimumSize = new System.Drawing.Size(1506, 385);
            this.Name = "Form1";
            this.Text = "Хищник-жертва";
            ((System.ComponentModel.ISupportInitialize)(this.population_graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependency_graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart population_graph;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.Label label_y1;
        private System.Windows.Forms.Label label_y2;
        private System.Windows.Forms.Label label_h;
        private System.Windows.Forms.Label label_T;
        private System.Windows.Forms.TextBox text_a;
        private System.Windows.Forms.TextBox text_c;
        private System.Windows.Forms.TextBox text_b;
        private System.Windows.Forms.TextBox text_d;
        private System.Windows.Forms.TextBox text_y1;
        private System.Windows.Forms.TextBox text_T;
        private System.Windows.Forms.TextBox text_h;
        private System.Windows.Forms.TextBox text_y2;
        private System.Windows.Forms.DataVisualization.Charting.Chart dependency_graph;
        private System.Windows.Forms.Label label_a;
    }
}

