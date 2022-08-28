namespace ЛР08
{
    partial class Task1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Coord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ind1 = new System.Windows.Forms.TextBox();
            this.NewE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Coord1B = new System.Windows.Forms.Button();
            this.panelSet = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ResSet = new System.Windows.Forms.Label();
            this.panelGet = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.GetCoord = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Coord2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.Label();
            this.panelNorm = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.Norm = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.VectorB = new System.Windows.Forms.Button();
            this.panelSet.SuspendLayout();
            this.panelGet.SuspendLayout();
            this.panelNorm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(15, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(108, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Завершить";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Класс \"ArrayVector\"";
            // 
            // Coord
            // 
            this.Coord.Location = new System.Drawing.Point(15, 103);
            this.Coord.Name = "Coord";
            this.Coord.Size = new System.Drawing.Size(255, 20);
            this.Coord.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Координаты  вектора(дробную часть отделяйте точкой):";
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(15, 55);
            this.N.MaximumSize = new System.Drawing.Size(150, 4);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(26, 20);
            this.N.TabIndex = 1;
            this.N.TextChanged += new System.EventHandler(this.N_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Размер вектора:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Введите индекс новой координаты(индексация c 0):";
            // 
            // ind1
            // 
            this.ind1.Location = new System.Drawing.Point(15, 209);
            this.ind1.Name = "ind1";
            this.ind1.Size = new System.Drawing.Size(26, 20);
            this.ind1.TabIndex = 4;
            // 
            // NewE
            // 
            this.NewE.Location = new System.Drawing.Point(15, 257);
            this.NewE.Name = "NewE";
            this.NewE.Size = new System.Drawing.Size(37, 20);
            this.NewE.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Введите значение новой координаты:";
            // 
            // Coord1B
            // 
            this.Coord1B.Location = new System.Drawing.Point(15, 284);
            this.Coord1B.Name = "Coord1B";
            this.Coord1B.Size = new System.Drawing.Size(75, 23);
            this.Coord1B.TabIndex = 6;
            this.Coord1B.Text = "Изменить";
            this.Coord1B.UseVisualStyleBackColor = true;
            this.Coord1B.Click += new System.EventHandler(this.Coord1B_Click);
            // 
            // panelSet
            // 
            this.panelSet.Controls.Add(this.label9);
            this.panelSet.Controls.Add(this.ResSet);
            this.panelSet.Location = new System.Drawing.Point(120, 284);
            this.panelSet.Name = "panelSet";
            this.panelSet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelSet.Size = new System.Drawing.Size(286, 44);
            this.panelSet.TabIndex = 44;
            this.panelSet.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Результат:";
            // 
            // ResSet
            // 
            this.ResSet.AutoSize = true;
            this.ResSet.Location = new System.Drawing.Point(3, 13);
            this.ResSet.MaximumSize = new System.Drawing.Size(280, 0);
            this.ResSet.Name = "ResSet";
            this.ResSet.Size = new System.Drawing.Size(35, 13);
            this.ResSet.TabIndex = 20;
            this.ResSet.Text = "label9";
            // 
            // panelGet
            // 
            this.panelGet.Controls.Add(this.label4);
            this.panelGet.Controls.Add(this.GetCoord);
            this.panelGet.Location = new System.Drawing.Point(536, 284);
            this.panelGet.Name = "panelGet";
            this.panelGet.Size = new System.Drawing.Size(261, 44);
            this.panelGet.TabIndex = 50;
            this.panelGet.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Результат:";
            // 
            // GetCoord
            // 
            this.GetCoord.AutoSize = true;
            this.GetCoord.Location = new System.Drawing.Point(7, 13);
            this.GetCoord.Name = "GetCoord";
            this.GetCoord.Size = new System.Drawing.Size(41, 13);
            this.GetCoord.TabIndex = 20;
            this.GetCoord.Text = "label11";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Прочитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Coord2
            // 
            this.Coord2.Location = new System.Drawing.Point(432, 257);
            this.Coord2.Name = "Coord2";
            this.Coord2.Size = new System.Drawing.Size(26, 20);
            this.Coord2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Введите индекс координаты:";
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Location = new System.Drawing.Point(12, 164);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(14, 13);
            this.V.TabIndex = 51;
            this.V.Text = "V";
            this.V.Visible = false;
            // 
            // panelNorm
            // 
            this.panelNorm.Controls.Add(this.label14);
            this.panelNorm.Controls.Add(this.Norm);
            this.panelNorm.Location = new System.Drawing.Point(120, 350);
            this.panelNorm.Name = "panelNorm";
            this.panelNorm.Size = new System.Drawing.Size(286, 47);
            this.panelNorm.TabIndex = 53;
            this.panelNorm.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Результат:";
            // 
            // Norm
            // 
            this.Norm.AutoSize = true;
            this.Norm.Location = new System.Drawing.Point(3, 13);
            this.Norm.Name = "Norm";
            this.Norm.Size = new System.Drawing.Size(41, 13);
            this.Norm.TabIndex = 20;
            this.Norm.Text = "label10";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Найти длину";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // VectorB
            // 
            this.VectorB.Location = new System.Drawing.Point(15, 129);
            this.VectorB.Name = "VectorB";
            this.VectorB.Size = new System.Drawing.Size(75, 23);
            this.VectorB.TabIndex = 3;
            this.VectorB.Text = "Создать";
            this.VectorB.UseVisualStyleBackColor = true;
            this.VectorB.Click += new System.EventHandler(this.VectorB_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.VectorB);
            this.Controls.Add(this.panelNorm);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.V);
            this.Controls.Add(this.panelGet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Coord2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelSet);
            this.Controls.Add(this.Coord1B);
            this.Controls.Add(this.NewE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ind1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Coord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.N);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Exit);
            this.Name = "Task1";
            this.Text = "Задание 1";
            this.panelSet.ResumeLayout(false);
            this.panelSet.PerformLayout();
            this.panelGet.ResumeLayout(false);
            this.panelGet.PerformLayout();
            this.panelNorm.ResumeLayout(false);
            this.panelNorm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Coord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ind1;
        private System.Windows.Forms.TextBox NewE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Coord1B;
        private System.Windows.Forms.Panel panelSet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ResSet;
        private System.Windows.Forms.Panel panelGet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GetCoord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Coord2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label V;
        private System.Windows.Forms.Panel panelNorm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Norm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button VectorB;
    }
}