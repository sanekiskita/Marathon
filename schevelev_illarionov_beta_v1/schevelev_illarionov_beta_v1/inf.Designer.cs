namespace schevelev_illarionov_beta_v1
{
    partial class inf
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Спасибо за вашу спонсорскую поддержку!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(187, 430);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(394, 20);
            this.label14.TabIndex = 46;
            this.label14.Text = "-- дней -- часов и -- минут до старта марафона!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 26);
            this.label1.TabIndex = 45;
            this.label1.Text = "MARATHON SKILLS 2017";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(23, 14);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 44;
            this.exit.Text = "Назад";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 84);
            this.button1.TabIndex = 48;
            this.button1.Text = "Marathon Skills 2017";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 84);
            this.button2.TabIndex = 49;
            this.button2.Text = "Насколько долгий марафон";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(385, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 84);
            this.button3.TabIndex = 51;
            this.button3.Text = "Список Благотворительных организаций";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(111, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 84);
            this.button4.TabIndex = 50;
            this.button4.Text = "Предыдущие результаты";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(111, 286);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(222, 84);
            this.button5.TabIndex = 52;
            this.button5.Text = "BMI калькулятор";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // t
            // 
            this.t.Enabled = true;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // inf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 459);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.MaximizeBox = false;
            this.Name = "inf";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация спонсорам";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.inf_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer t;
    }
}