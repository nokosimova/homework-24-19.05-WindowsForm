namespace Calculator
{
    partial class Calculator
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
            this.calcWindow = new System.Windows.Forms.RichTextBox();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.plmn = new System.Windows.Forms.Button();
            this.coma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcWindow
            // 
            this.calcWindow.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcWindow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.calcWindow.Location = new System.Drawing.Point(31, 24);
            this.calcWindow.Name = "calcWindow";
            this.calcWindow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.calcWindow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.calcWindow.Size = new System.Drawing.Size(273, 85);
            this.calcWindow.TabIndex = 0;
            this.calcWindow.Text = "0";
            this.calcWindow.TextChanged += new System.EventHandler(this.calcWindow_TextChanged);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.num1.Location = new System.Drawing.Point(31, 293);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(50, 48);
            this.num1.TabIndex = 1;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.num2.Location = new System.Drawing.Point(87, 293);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(50, 48);
            this.num2.TabIndex = 4;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.num3.Location = new System.Drawing.Point(143, 293);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(50, 48);
            this.num3.TabIndex = 6;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.num6.Location = new System.Drawing.Point(143, 239);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(50, 48);
            this.num6.TabIndex = 9;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.num5.Location = new System.Drawing.Point(87, 239);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(50, 48);
            this.num5.TabIndex = 8;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.num4.Location = new System.Drawing.Point(31, 239);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(50, 48);
            this.num4.TabIndex = 7;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.num9.Location = new System.Drawing.Point(143, 185);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(50, 48);
            this.num9.TabIndex = 12;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.num8.Location = new System.Drawing.Point(87, 185);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(50, 48);
            this.num8.TabIndex = 11;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.num7.Location = new System.Drawing.Point(31, 185);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(50, 48);
            this.num7.TabIndex = 10;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num0.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.num0.Location = new System.Drawing.Point(87, 349);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(50, 48);
            this.num0.TabIndex = 13;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // plmn
            // 
            this.plmn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plmn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.plmn.Location = new System.Drawing.Point(31, 349);
            this.plmn.Name = "plmn";
            this.plmn.Size = new System.Drawing.Size(50, 48);
            this.plmn.TabIndex = 14;
            this.plmn.Text = "+/-";
            this.plmn.UseVisualStyleBackColor = true;
            // 
            // coma
            // 
            this.coma.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coma.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.coma.Location = new System.Drawing.Point(143, 349);
            this.coma.Name = "coma";
            this.coma.Size = new System.Drawing.Size(50, 48);
            this.coma.TabIndex = 15;
            this.coma.Text = ",";
            this.coma.UseVisualStyleBackColor = true;
            this.coma.Click += new System.EventHandler(this.coma_Click);
            // 
            // Calculator
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(343, 409);
            this.Controls.Add(this.coma);
            this.Controls.Add(this.plmn);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.calcWindow);
            this.Name = "Calculator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Калькулятор";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox calcWindow;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button plmn;
        private System.Windows.Forms.Button coma;
    }
}

