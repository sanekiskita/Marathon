namespace schevelev_illarionov_beta_v1
{
    partial class adm_menu
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(389, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 84);
            this.button3.TabIndex = 70;
            this.button3.Text = "Инвентарь";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(115, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 84);
            this.button4.TabIndex = 69;
            this.button4.Text = "Благотворительные организации";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 84);
            this.button2.TabIndex = 68;
            this.button2.Text = "Волонтеры";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 84);
            this.button1.TabIndex = 67;
            this.button1.Text = "Пользователи";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Меню администратора";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(181, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(394, 20);
            this.label14.TabIndex = 65;
            this.label14.Text = "-- дней -- часов и -- минут до старта марафона!";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "MARATHON SKILLS 2017";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(27, 19);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 63;
            this.exit.Text = "Назад";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // t
            // 
            this.t.Enabled = true;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(630, 19);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 71;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // adm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 386);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btn_logout);
            this.Name = "adm_menu";
            this.Text = "adm_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Timer t;
        private System.Windows.Forms.Button btn_logout;
    }
}