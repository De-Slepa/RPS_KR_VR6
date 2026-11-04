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
            this.dgvResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
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
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(20, 140);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(1148, 432);
            this.dgvResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 635);
            this.Controls.Add(this.dgvResult);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvResult;
    }
}

