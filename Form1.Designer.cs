namespace My_RSA
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.КнопкаЗашифровать = new System.Windows.Forms.Button();
            this.КнопкаРасшифровать = new System.Windows.Forms.Button();
            this.ЯрлыкP = new System.Windows.Forms.Label();
            this.ПолеP = new System.Windows.Forms.TextBox();
            this.ЯрлыкQ = new System.Windows.Forms.Label();
            this.ПолеQ = new System.Windows.Forms.TextBox();
            this.ЯрлыкПростые = new System.Windows.Forms.Label();
            this.ЯрлыкD = new System.Windows.Forms.Label();
            this.ЯрлыкN = new System.Windows.Forms.Label();
            this.ЯрлыкСекретный = new System.Windows.Forms.Label();
            this.ПолеD = new System.Windows.Forms.TextBox();
            this.ПолеN = new System.Windows.Forms.TextBox();
            this.КнопкаСгенерировать = new System.Windows.Forms.Button();
            this.Text1 = new System.Windows.Forms.RichTextBox();
            this.Text2 = new System.Windows.Forms.RichTextBox();
            this.Text3 = new System.Windows.Forms.RichTextBox();
            this.УдалитьДанныеText1 = new System.Windows.Forms.Button();
            this.УдалитьДанныеText2 = new System.Windows.Forms.Button();
            this.УдалитьДанныеText3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // КнопкаЗашифровать
            // 
            this.КнопкаЗашифровать.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.КнопкаЗашифровать.Location = new System.Drawing.Point(18, 72);
            this.КнопкаЗашифровать.Margin = new System.Windows.Forms.Padding(4);
            this.КнопкаЗашифровать.Name = "КнопкаЗашифровать";
            this.КнопкаЗашифровать.Size = new System.Drawing.Size(474, 27);
            this.КнопкаЗашифровать.TabIndex = 1;
            this.КнопкаЗашифровать.Text = "Зашифровать";
            this.КнопкаЗашифровать.UseVisualStyleBackColor = true;
            this.КнопкаЗашифровать.Click += new System.EventHandler(this.КнопкаЗашифровать_Click);
            // 
            // КнопкаРасшифровать
            // 
            this.КнопкаРасшифровать.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.КнопкаРасшифровать.Location = new System.Drawing.Point(18, 273);
            this.КнопкаРасшифровать.Margin = new System.Windows.Forms.Padding(4);
            this.КнопкаРасшифровать.Name = "КнопкаРасшифровать";
            this.КнопкаРасшифровать.Size = new System.Drawing.Size(474, 29);
            this.КнопкаРасшифровать.TabIndex = 2;
            this.КнопкаРасшифровать.Text = "Расшифровать";
            this.КнопкаРасшифровать.UseVisualStyleBackColor = true;
            this.КнопкаРасшифровать.Click += new System.EventHandler(this.КнопкаРасшифровать_Click);
            // 
            // ЯрлыкP
            // 
            this.ЯрлыкP.AutoSize = true;
            this.ЯрлыкP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ЯрлыкP.Location = new System.Drawing.Point(14, 43);
            this.ЯрлыкP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ЯрлыкP.Name = "ЯрлыкP";
            this.ЯрлыкP.Size = new System.Drawing.Size(31, 20);
            this.ЯрлыкP.TabIndex = 3;
            this.ЯрлыкP.Text = "p =";
            // 
            // ПолеP
            // 
            this.ПолеP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ПолеP.Location = new System.Drawing.Point(52, 38);
            this.ПолеP.Margin = new System.Windows.Forms.Padding(4);
            this.ПолеP.Name = "ПолеP";
            this.ПолеP.Size = new System.Drawing.Size(91, 26);
            this.ПолеP.TabIndex = 4;
            this.ПолеP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ЯрлыкQ
            // 
            this.ЯрлыкQ.AutoSize = true;
            this.ЯрлыкQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ЯрлыкQ.Location = new System.Drawing.Point(180, 43);
            this.ЯрлыкQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ЯрлыкQ.Name = "ЯрлыкQ";
            this.ЯрлыкQ.Size = new System.Drawing.Size(31, 20);
            this.ЯрлыкQ.TabIndex = 5;
            this.ЯрлыкQ.Text = "q =";
            // 
            // ПолеQ
            // 
            this.ПолеQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ПолеQ.Location = new System.Drawing.Point(219, 36);
            this.ПолеQ.Margin = new System.Windows.Forms.Padding(4);
            this.ПолеQ.Name = "ПолеQ";
            this.ПолеQ.Size = new System.Drawing.Size(91, 26);
            this.ПолеQ.TabIndex = 6;
            this.ПолеQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ЯрлыкПростые
            // 
            this.ЯрлыкПростые.AutoSize = true;
            this.ЯрлыкПростые.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ЯрлыкПростые.Location = new System.Drawing.Point(14, 9);
            this.ЯрлыкПростые.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ЯрлыкПростые.Name = "ЯрлыкПростые";
            this.ЯрлыкПростые.Size = new System.Drawing.Size(188, 29);
            this.ЯрлыкПростые.TabIndex = 7;
            this.ЯрлыкПростые.Text = "Простые числа";
            // 
            // ЯрлыкD
            // 
            this.ЯрлыкD.AutoSize = true;
            this.ЯрлыкD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ЯрлыкD.Location = new System.Drawing.Point(14, 239);
            this.ЯрлыкD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ЯрлыкD.Name = "ЯрлыкD";
            this.ЯрлыкD.Size = new System.Drawing.Size(31, 20);
            this.ЯрлыкD.TabIndex = 8;
            this.ЯрлыкD.Text = "d =";
            // 
            // ЯрлыкN
            // 
            this.ЯрлыкN.AutoSize = true;
            this.ЯрлыкN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ЯрлыкN.Location = new System.Drawing.Point(180, 239);
            this.ЯрлыкN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ЯрлыкN.Name = "ЯрлыкN";
            this.ЯрлыкN.Size = new System.Drawing.Size(31, 20);
            this.ЯрлыкN.TabIndex = 9;
            this.ЯрлыкN.Text = "n =";
            // 
            // ЯрлыкСекретный
            // 
            this.ЯрлыкСекретный.AutoSize = true;
            this.ЯрлыкСекретный.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ЯрлыкСекретный.Location = new System.Drawing.Point(14, 193);
            this.ЯрлыкСекретный.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ЯрлыкСекретный.Name = "ЯрлыкСекретный";
            this.ЯрлыкСекретный.Size = new System.Drawing.Size(76, 29);
            this.ЯрлыкСекретный.TabIndex = 10;
            this.ЯрлыкСекретный.Text = "Ключ";
            // 
            // ПолеD
            // 
            this.ПолеD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ПолеD.Location = new System.Drawing.Point(52, 236);
            this.ПолеD.Margin = new System.Windows.Forms.Padding(4);
            this.ПолеD.Name = "ПолеD";
            this.ПолеD.Size = new System.Drawing.Size(91, 26);
            this.ПолеD.TabIndex = 11;
            this.ПолеD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ПолеN
            // 
            this.ПолеN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ПолеN.Location = new System.Drawing.Point(219, 239);
            this.ПолеN.Margin = new System.Windows.Forms.Padding(4);
            this.ПолеN.Name = "ПолеN";
            this.ПолеN.Size = new System.Drawing.Size(91, 26);
            this.ПолеN.TabIndex = 12;
            this.ПолеN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // КнопкаСгенерировать
            // 
            this.КнопкаСгенерировать.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.КнопкаСгенерировать.Location = new System.Drawing.Point(332, 36);
            this.КнопкаСгенерировать.Margin = new System.Windows.Forms.Padding(4);
            this.КнопкаСгенерировать.Name = "КнопкаСгенерировать";
            this.КнопкаСгенерировать.Size = new System.Drawing.Size(160, 26);
            this.КнопкаСгенерировать.TabIndex = 13;
            this.КнопкаСгенерировать.Text = "Сгенерировать";
            this.КнопкаСгенерировать.UseVisualStyleBackColor = true;
            this.КнопкаСгенерировать.Click += new System.EventHandler(this.КнопкаСгенерировать_Click);
            // 
            // Text1
            // 
            this.Text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(18, 107);
            this.Text1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(344, 34);
            this.Text1.TabIndex = 14;
            this.Text1.Text = "";
            // 
            // Text2
            // 
            this.Text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text2.Location = new System.Drawing.Point(18, 148);
            this.Text2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(344, 34);
            this.Text2.TabIndex = 15;
            this.Text2.Text = "";
            // 
            // Text3
            // 
            this.Text3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text3.Location = new System.Drawing.Point(18, 310);
            this.Text3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(344, 43);
            this.Text3.TabIndex = 16;
            this.Text3.Text = "";
            // 
            // УдалитьДанныеText1
            // 
            this.УдалитьДанныеText1.Location = new System.Drawing.Point(368, 107);
            this.УдалитьДанныеText1.Name = "УдалитьДанныеText1";
            this.УдалитьДанныеText1.Size = new System.Drawing.Size(127, 34);
            this.УдалитьДанныеText1.TabIndex = 17;
            this.УдалитьДанныеText1.Text = "Удалить данные";
            this.УдалитьДанныеText1.UseVisualStyleBackColor = true;
            this.УдалитьДанныеText1.Click += new System.EventHandler(this.УдалитьДанныеText1_Click);
            // 
            // УдалитьДанныеText2
            // 
            this.УдалитьДанныеText2.Location = new System.Drawing.Point(368, 148);
            this.УдалитьДанныеText2.Name = "УдалитьДанныеText2";
            this.УдалитьДанныеText2.Size = new System.Drawing.Size(127, 34);
            this.УдалитьДанныеText2.TabIndex = 18;
            this.УдалитьДанныеText2.Text = "Удалить данные";
            this.УдалитьДанныеText2.UseVisualStyleBackColor = true;
            this.УдалитьДанныеText2.Click += new System.EventHandler(this.УдалитьДанныеText2_Click);
            // 
            // УдалитьДанныеText3
            // 
            this.УдалитьДанныеText3.Location = new System.Drawing.Point(368, 310);
            this.УдалитьДанныеText3.Name = "УдалитьДанныеText3";
            this.УдалитьДанныеText3.Size = new System.Drawing.Size(123, 42);
            this.УдалитьДанныеText3.TabIndex = 19;
            this.УдалитьДанныеText3.Text = "Удалить данные";
            this.УдалитьДанныеText3.UseVisualStyleBackColor = true;
            this.УдалитьДанныеText3.Click += new System.EventHandler(this.УдалитьДанныеText3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 364);
            this.Controls.Add(this.УдалитьДанныеText3);
            this.Controls.Add(this.УдалитьДанныеText2);
            this.Controls.Add(this.УдалитьДанныеText1);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.КнопкаСгенерировать);
            this.Controls.Add(this.ПолеN);
            this.Controls.Add(this.ПолеD);
            this.Controls.Add(this.ЯрлыкСекретный);
            this.Controls.Add(this.ЯрлыкN);
            this.Controls.Add(this.ЯрлыкD);
            this.Controls.Add(this.ЯрлыкПростые);
            this.Controls.Add(this.ПолеQ);
            this.Controls.Add(this.ЯрлыкQ);
            this.Controls.Add(this.ПолеP);
            this.Controls.Add(this.ЯрлыкP);
            this.Controls.Add(this.КнопкаРасшифровать);
            this.Controls.Add(this.КнопкаЗашифровать);
            this.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Алгоритм RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button КнопкаЗашифровать;
        private System.Windows.Forms.Button КнопкаРасшифровать;
        private System.Windows.Forms.Label ЯрлыкP;
        private System.Windows.Forms.TextBox ПолеP;
        private System.Windows.Forms.Label ЯрлыкQ;
        private System.Windows.Forms.TextBox ПолеQ;
        private System.Windows.Forms.Label ЯрлыкПростые;
        private System.Windows.Forms.Label ЯрлыкD;
        private System.Windows.Forms.Label ЯрлыкN;
        private System.Windows.Forms.Label ЯрлыкСекретный;
        private System.Windows.Forms.TextBox ПолеD;
        private System.Windows.Forms.TextBox ПолеN;
        private System.Windows.Forms.Button КнопкаСгенерировать;
        private System.Windows.Forms.RichTextBox Text1;
        private System.Windows.Forms.RichTextBox Text2;
        private System.Windows.Forms.RichTextBox Text3;
        private System.Windows.Forms.Button УдалитьДанныеText1;
        private System.Windows.Forms.Button УдалитьДанныеText2;
        private System.Windows.Forms.Button УдалитьДанныеText3;
    }
}

