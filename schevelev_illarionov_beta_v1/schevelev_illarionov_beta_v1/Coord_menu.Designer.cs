namespace schevelev_illarionov_beta_v1
{
    partial class Coord_menu
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 84);
            this.button2.TabIndex = 77;
            this.button2.Text = "Спонсоры";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 84);
            this.button1.TabIndex = 76;
            this.button1.Text = "Бегуны";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Меню координатора";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(153, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(394, 20);
            this.label14.TabIndex = 74;
            this.label14.Text = "-- дней -- часов и -- минут до старта марафона!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 26);
            this.label1.TabIndex = 73;
            this.label1.Text = "MARATHON SKILLS 2017";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(9, 14);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 72;
            this.exit.Text = "Назад";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(612, 14);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 78;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // t
            // 
            this.t.Enabled = true;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // Coord_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 349);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btn_logout);
            this.Name = "Coord_menu";
            this.Text = "Coord_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Timer t;
    }
}