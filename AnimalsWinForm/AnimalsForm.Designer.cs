namespace AnimalsWinForm
{
    partial class AnimalsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAvWeightDefault = new System.Windows.Forms.TextBox();
            this.textBoxClNameDefault = new System.Windows.Forms.TextBox();
            this.textBoxNameDefault = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.butDeleteAnimal = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAverageCreated = new System.Windows.Forms.TextBox();
            this.textBoxClassCreated = new System.Windows.Forms.TextBox();
            this.textBoxNameCreated = new System.Windows.Forms.TextBox();
            this.dataGridViewAnimals = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxAvWeightDefault);
            this.panel1.Controls.Add(this.textBoxClNameDefault);
            this.panel1.Controls.Add(this.textBoxNameDefault);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 161);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Использование конструктора по умолчанию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Средний вес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Класс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // textBoxAvWeightDefault
            // 
            this.textBoxAvWeightDefault.Location = new System.Drawing.Point(91, 119);
            this.textBoxAvWeightDefault.Name = "textBoxAvWeightDefault";
            this.textBoxAvWeightDefault.Size = new System.Drawing.Size(185, 20);
            this.textBoxAvWeightDefault.TabIndex = 2;
            // 
            // textBoxClNameDefault
            // 
            this.textBoxClNameDefault.Location = new System.Drawing.Point(91, 83);
            this.textBoxClNameDefault.Name = "textBoxClNameDefault";
            this.textBoxClNameDefault.Size = new System.Drawing.Size(185, 20);
            this.textBoxClNameDefault.TabIndex = 1;
            // 
            // textBoxNameDefault
            // 
            this.textBoxNameDefault.Location = new System.Drawing.Point(91, 44);
            this.textBoxNameDefault.Name = "textBoxNameDefault";
            this.textBoxNameDefault.Size = new System.Drawing.Size(185, 20);
            this.textBoxNameDefault.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.butDeleteAnimal);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxAverageCreated);
            this.panel2.Controls.Add(this.textBoxClassCreated);
            this.panel2.Controls.Add(this.textBoxNameCreated);
            this.panel2.Location = new System.Drawing.Point(328, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 158);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Использование конструктора с параметрами";
            // 
            // butDeleteAnimal
            // 
            this.butDeleteAnimal.Location = new System.Drawing.Point(268, 131);
            this.butDeleteAnimal.Name = "butDeleteAnimal";
            this.butDeleteAnimal.Size = new System.Drawing.Size(109, 23);
            this.butDeleteAnimal.TabIndex = 14;
            this.butDeleteAnimal.Text = "Удалить";
            this.butDeleteAnimal.UseVisualStyleBackColor = true;
            this.butDeleteAnimal.Click += new System.EventHandler(this.butDeleteAnimal_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(134, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Скопировать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.butCopyAnimal_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Записать в DataGrid";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButAddAnimal_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(282, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButChangeName_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Средний вес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Класс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Название";
            // 
            // textBoxAverageCreated
            // 
            this.textBoxAverageCreated.Location = new System.Drawing.Point(90, 105);
            this.textBoxAverageCreated.Name = "textBoxAverageCreated";
            this.textBoxAverageCreated.Size = new System.Drawing.Size(185, 20);
            this.textBoxAverageCreated.TabIndex = 5;
            // 
            // textBoxClassCreated
            // 
            this.textBoxClassCreated.Location = new System.Drawing.Point(90, 70);
            this.textBoxClassCreated.Name = "textBoxClassCreated";
            this.textBoxClassCreated.Size = new System.Drawing.Size(185, 20);
            this.textBoxClassCreated.TabIndex = 4;
            // 
            // textBoxNameCreated
            // 
            this.textBoxNameCreated.Location = new System.Drawing.Point(90, 39);
            this.textBoxNameCreated.Name = "textBoxNameCreated";
            this.textBoxNameCreated.Size = new System.Drawing.Size(185, 20);
            this.textBoxNameCreated.TabIndex = 3;
            // 
            // dataGridViewAnimals
            // 
            this.dataGridViewAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimals.Location = new System.Drawing.Point(12, 179);
            this.dataGridViewAnimals.Name = "dataGridViewAnimals";
            this.dataGridViewAnimals.Size = new System.Drawing.Size(709, 259);
            this.dataGridViewAnimals.TabIndex = 2;
            this.dataGridViewAnimals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAnimals_CellClick);
            // 
            // AnimalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.dataGridViewAnimals);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AnimalsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма добавления животного";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAvWeightDefault;
        private System.Windows.Forms.TextBox textBoxClNameDefault;
        private System.Windows.Forms.TextBox textBoxNameDefault;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAverageCreated;
        private System.Windows.Forms.TextBox textBoxClassCreated;
        private System.Windows.Forms.TextBox textBoxNameCreated;
        private System.Windows.Forms.DataGridView dataGridViewAnimals;
        private System.Windows.Forms.Button butDeleteAnimal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

