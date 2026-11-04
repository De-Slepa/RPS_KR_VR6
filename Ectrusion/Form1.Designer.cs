namespace Ectrusion
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.txtMu0 = new System.Windows.Forms.TextBox();
            this.txtGStep = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtT0 = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtTMin = new System.Windows.Forms.TextBox();
            this.txtTMax = new System.Windows.Forms.TextBox();
            this.txtTStep = new System.Windows.Forms.TextBox();
            this.txtGMin = new System.Windows.Forms.TextBox();
            this.txtGMax = new System.Windows.Forms.TextBox();
            this.tabResults = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbAxis = new System.Windows.Forms.ComboBox();
            this.tabResults.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(20, 28);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterial.TabIndex = 1;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // txtMu0
            // 
            this.txtMu0.Location = new System.Drawing.Point(147, 29);
            this.txtMu0.Name = "txtMu0";
            this.txtMu0.Size = new System.Drawing.Size(100, 20);
            this.txtMu0.TabIndex = 2;
            // 
            // txtGStep
            // 
            this.txtGStep.Location = new System.Drawing.Point(1068, 114);
            this.txtGStep.Name = "txtGStep";
            this.txtGStep.Size = new System.Drawing.Size(100, 20);
            this.txtGStep.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(253, 29);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 4;
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(359, 29);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(100, 20);
            this.txtT0.TabIndex = 5;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(465, 29);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 6;
            // 
            // txtTMin
            // 
            this.txtTMin.Location = new System.Drawing.Point(962, 29);
            this.txtTMin.Name = "txtTMin";
            this.txtTMin.Size = new System.Drawing.Size(100, 20);
            this.txtTMin.TabIndex = 7;
            // 
            // txtTMax
            // 
            this.txtTMax.Location = new System.Drawing.Point(1068, 29);
            this.txtTMax.Name = "txtTMax";
            this.txtTMax.Size = new System.Drawing.Size(100, 20);
            this.txtTMax.TabIndex = 8;
            // 
            // txtTStep
            // 
            this.txtTStep.Location = new System.Drawing.Point(1068, 55);
            this.txtTStep.Name = "txtTStep";
            this.txtTStep.Size = new System.Drawing.Size(100, 20);
            this.txtTStep.TabIndex = 9;
            // 
            // txtGMin
            // 
            this.txtGMin.Location = new System.Drawing.Point(962, 88);
            this.txtGMin.Name = "txtGMin";
            this.txtGMin.Size = new System.Drawing.Size(100, 20);
            this.txtGMin.TabIndex = 10;
            // 
            // txtGMax
            // 
            this.txtGMax.Location = new System.Drawing.Point(1068, 88);
            this.txtGMax.Name = "txtGMax";
            this.txtGMax.Size = new System.Drawing.Size(100, 20);
            this.txtGMax.TabIndex = 11;
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.tabPage1);
            this.tabResults.Controls.Add(this.tabPage2);
            this.tabResults.Location = new System.Drawing.Point(20, 140);
            this.tabResults.Name = "tabResults";
            this.tabResults.SelectedIndex = 0;
            this.tabResults.Size = new System.Drawing.Size(1148, 444);
            this.tabResults.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1140, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1140, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "График";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(3, 3);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(1134, 412);
            this.dgvResult.TabIndex = 13;
            // 
            // chartResult
            // 
            this.chartResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResult.Legends.Add(legend2);
            this.chartResult.Location = new System.Drawing.Point(0, 21);
            this.chartResult.Name = "chartResult";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResult.Series.Add(series2);
            this.chartResult.Size = new System.Drawing.Size(1140, 397);
            this.chartResult.TabIndex = 0;
            this.chartResult.Text = "chart1";
            // 
            // cmbAxis
            // 
            this.cmbAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAxis.FormattingEnabled = true;
            this.cmbAxis.Location = new System.Drawing.Point(126, 113);
            this.cmbAxis.Name = "cmbAxis";
            this.cmbAxis.Size = new System.Drawing.Size(121, 21);
            this.cmbAxis.TabIndex = 14;
            this.cmbAxis.SelectedIndexChanged += new System.EventHandler(this.cmbAxis_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 635);
            this.Controls.Add(this.cmbAxis);
            this.Controls.Add(this.tabResults);
            this.Controls.Add(this.txtGMax);
            this.Controls.Add(this.txtGMin);
            this.Controls.Add(this.txtTStep);
            this.Controls.Add(this.txtTMax);
            this.Controls.Add(this.txtTMin);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtT0);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtGStep);
            this.Controls.Add(this.txtMu0);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabResults.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.TextBox txtMu0;
        private System.Windows.Forms.TextBox txtGStep;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtT0;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtTMin;
        private System.Windows.Forms.TextBox txtTMax;
        private System.Windows.Forms.TextBox txtTStep;
        private System.Windows.Forms.TextBox txtGMin;
        private System.Windows.Forms.TextBox txtGMax;
        private System.Windows.Forms.TabControl tabResults;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private System.Windows.Forms.ComboBox cmbAxis;
    }
}

