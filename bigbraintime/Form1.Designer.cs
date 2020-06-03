namespace bigbraintime
{
    partial class BIGBRAINTIME
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_fromfile = new System.Windows.Forms.Button();
            this.button_tofile = new System.Windows.Forms.Button();
            this.randomizer = new System.Windows.Forms.Button();
            this.button_creategyst = new System.Windows.Forms.Button();
            this.button_changeform = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_objective = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ErrorText = "RWERR";
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(685, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_fromfile
            // 
            this.button_fromfile.Location = new System.Drawing.Point(12, 346);
            this.button_fromfile.Name = "button_fromfile";
            this.button_fromfile.Size = new System.Drawing.Size(99, 23);
            this.button_fromfile.TabIndex = 1;
            this.button_fromfile.Text = "ИЗ ФАЙЛА";
            this.button_fromfile.UseVisualStyleBackColor = true;
            this.button_fromfile.Click += new System.EventHandler(this.button_fromfile_Click);
            // 
            // button_tofile
            // 
            this.button_tofile.Location = new System.Drawing.Point(582, 346);
            this.button_tofile.Name = "button_tofile";
            this.button_tofile.Size = new System.Drawing.Size(115, 23);
            this.button_tofile.TabIndex = 1;
            this.button_tofile.Text = "В ФАЙЛ";
            this.button_tofile.UseVisualStyleBackColor = true;
            this.button_tofile.Click += new System.EventHandler(this.button_tofile_Click);
            // 
            // randomizer
            // 
            this.randomizer.Location = new System.Drawing.Point(117, 346);
            this.randomizer.Name = "randomizer";
            this.randomizer.Size = new System.Drawing.Size(104, 23);
            this.randomizer.TabIndex = 1;
            this.randomizer.Text = "РАНДОМАЙЗЕР";
            this.randomizer.UseVisualStyleBackColor = true;
            this.randomizer.Click += new System.EventHandler(this.randomizer_Click);
            // 
            // button_creategyst
            // 
            this.button_creategyst.Location = new System.Drawing.Point(340, 346);
            this.button_creategyst.Name = "button_creategyst";
            this.button_creategyst.Size = new System.Drawing.Size(115, 23);
            this.button_creategyst.TabIndex = 1;
            this.button_creategyst.Text = "ГИСТОГРАММА";
            this.button_creategyst.UseVisualStyleBackColor = true;
            this.button_creategyst.Click += new System.EventHandler(this.button_creategyst_Click);
            // 
            // button_changeform
            // 
            this.button_changeform.Location = new System.Drawing.Point(461, 346);
            this.button_changeform.Name = "button_changeform";
            this.button_changeform.Size = new System.Drawing.Size(115, 23);
            this.button_changeform.TabIndex = 1;
            this.button_changeform.Text = "СМЕНА ФОРМЫ";
            this.button_changeform.UseVisualStyleBackColor = true;
            this.button_changeform.Click += new System.EventHandler(this.button_changeform_Click);
            // 
            // chart
            // 
            this.chart.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(30, 98);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Элементы";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(650, 225);
            this.chart.TabIndex = 2;
            this.chart.Text = "Chart";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // button_objective
            // 
            this.button_objective.Location = new System.Drawing.Point(227, 346);
            this.button_objective.Name = "button_objective";
            this.button_objective.Size = new System.Drawing.Size(107, 23);
            this.button_objective.TabIndex = 3;
            this.button_objective.Text = "ЗАДАНИЕ";
            this.button_objective.UseVisualStyleBackColor = true;
            this.button_objective.Click += new System.EventHandler(this.button_objective_Click);
            // 
            // BIGBRAINTIME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(709, 378);
            this.Controls.Add(this.button_objective);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.button_changeform);
            this.Controls.Add(this.button_creategyst);
            this.Controls.Add(this.randomizer);
            this.Controls.Add(this.button_tofile);
            this.Controls.Add(this.button_fromfile);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "BIGBRAINTIME";
            this.Text = "BIGBRAINTIME";
            this.Load += new System.EventHandler(this.BIGBRAINTIME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_fromfile;
        private System.Windows.Forms.Button button_tofile;
        private System.Windows.Forms.Button randomizer;
        private System.Windows.Forms.Button button_creategyst;
        private System.Windows.Forms.Button button_changeform;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button button_objective;
    }
}

