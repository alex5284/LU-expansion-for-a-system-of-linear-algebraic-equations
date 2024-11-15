namespace lab3
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
            this.dgMatrix = new System.Windows.Forms.DataGridView();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnMatrix = new System.Windows.Forms.Button();
            this.btnLU = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnU = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMatrix
            // 
            this.dgMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatrix.Location = new System.Drawing.Point(25, 12);
            this.dgMatrix.Name = "dgMatrix";
            this.dgMatrix.RowHeadersWidth = 51;
            this.dgMatrix.RowTemplate.Height = 24;
            this.dgMatrix.Size = new System.Drawing.Size(776, 262);
            this.dgMatrix.TabIndex = 0;
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(851, 23);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(100, 22);
            this.tbSize.TabIndex = 1;
            this.tbSize.Text = "4";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(921, 64);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(84, 30);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnMatrix
            // 
            this.btnMatrix.Location = new System.Drawing.Point(822, 64);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(84, 30);
            this.btnMatrix.TabIndex = 3;
            this.btnMatrix.Text = "Create";
            this.btnMatrix.UseVisualStyleBackColor = true;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // btnLU
            // 
            this.btnLU.Location = new System.Drawing.Point(851, 191);
            this.btnLU.Name = "btnLU";
            this.btnLU.Size = new System.Drawing.Size(84, 30);
            this.btnLU.TabIndex = 4;
            this.btnLU.Text = "LU";
            this.btnLU.UseVisualStyleBackColor = true;
            this.btnLU.Click += new System.EventHandler(this.btnLU_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(994, 208);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 276);
            this.listBox1.TabIndex = 5;
            // 
            // btnU
            // 
            this.btnU.Location = new System.Drawing.Point(908, 244);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(53, 30);
            this.btnU.TabIndex = 6;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(831, 244);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(58, 30);
            this.btnL.TabIndex = 7;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 535);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLU);
            this.Controls.Add(this.btnMatrix);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.dgMatrix);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMatrix;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnMatrix;
        private System.Windows.Forms.Button btnLU;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnL;
    }
}

