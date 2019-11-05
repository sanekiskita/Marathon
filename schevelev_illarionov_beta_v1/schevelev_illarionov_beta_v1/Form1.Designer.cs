namespace schevelev_illarionov_beta_v1
{
    partial class Form1
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
            this.btn_begun = new System.Windows.Forms.Button();
            this.btn_spn_beguna = new System.Windows.Forms.Button();
            this.btn_inf = new System.Windows.Forms.Button();
            this.btn_zritel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_begun
            // 
            this.btn_begun.Location = new System.Drawing.Point(12, 114);
            this.btn_begun.Name = "btn_begun";
            this.btn_begun.Size = new System.Drawing.Size(333, 65);
            this.btn_begun.TabIndex = 0;
            this.btn_begun.Text = "Я хочу стать бегуном";
            this.btn_begun.UseVisualStyleBackColor = true;
            this.btn_begun.Click += new System.EventHandler(this.btn_begun_Click);
            // 
            // btn_spn_beguna
            // 
            this.btn_spn_beguna.Location = new System.Drawing.Point(12, 202);
            this.btn_spn_beguna.Name = "btn_spn_beguna";
            this.btn_spn_beguna.Size = new System.Drawing.Size(333, 65);
            this.btn_spn_beguna.TabIndex = 1;
            this.btn_spn_beguna.Text = "Я хочу стать спонсором бегуна";
            this.btn_spn_beguna.UseVisualStyleBackColor = true;
            this.btn_spn_beguna.Click += new System.EventHandler(this.btn_spn_beguna_Click);
            // 
            // btn_inf
            // 
            this.btn_inf.Location = new System.Drawing.Point(360, 202);
            this.btn_inf.Name = "btn_inf";
            this.btn_inf.Size = new System.Drawing.Size(333, 65);
            this.btn_inf.TabIndex = 3;
            this.btn_inf.Text = "Я хочу узнать больше о событии";
            this.btn_inf.UseVisualStyleBackColor = true;
            this.btn_inf.Click += new System.EventHandler(this.btn_inf_Click);
            // 
            // btn_zritel
            // 
            this.btn_zritel.Location = new System.Drawing.Point(360, 114);
            this.btn_zritel.Name = "btn_zritel";
            this.btn_zritel.Size = new System.Drawing.Size(333, 65);
            this.btn_zritel.TabIndex = 2;
            this.btn_zritel.Text = "Я хочу стать зрителем";
            this.btn_zritel.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(574, 313);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(119, 36);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "MARATHON SKILLS 2017";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Москва, Россия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "среда 21 октября 2016";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "-- дней -- часов и -- минут до старта марафона!";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // t
            // 
            this.t.Enabled = true;
            this.t.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_inf);
            this.Controls.Add(this.btn_zritel);
            this.Controls.Add(this.btn_spn_beguna);
            this.Controls.Add(this.btn_begun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Марафон";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_begun;
        private System.Windows.Forms.Button btn_spn_beguna;
        private System.Windows.Forms.Button btn_inf;
        private System.Windows.Forms.Button btn_zritel;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer t;
    }
}

