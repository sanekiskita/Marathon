namespace schevelev_illarionov_beta_v1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back_r = new System.Windows.Forms.Button();
            this.btn_uch_ranee = new System.Windows.Forms.Button();
            this.btn_uch_new = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "MARATHON SKILLS 2017";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_back_r
            // 
            this.btn_back_r.Location = new System.Drawing.Point(12, 12);
            this.btn_back_r.Name = "btn_back_r";
            this.btn_back_r.Size = new System.Drawing.Size(73, 25);
            this.btn_back_r.TabIndex = 7;
            this.btn_back_r.Text = "Назад";
            this.btn_back_r.UseVisualStyleBackColor = true;
            this.btn_back_r.Click += new System.EventHandler(this.btn_back_r_Click);
            // 
            // btn_uch_ranee
            // 
            this.btn_uch_ranee.Location = new System.Drawing.Point(175, 111);
            this.btn_uch_ranee.Name = "btn_uch_ranee";
            this.btn_uch_ranee.Size = new System.Drawing.Size(333, 65);
            this.btn_uch_ranee.TabIndex = 8;
            this.btn_uch_ranee.Text = "Я участвовал ранее";
            this.btn_uch_ranee.UseVisualStyleBackColor = true;
            this.btn_uch_ranee.Click += new System.EventHandler(this.btn_uch_ranee_Click);
            // 
            // btn_uch_new
            // 
            this.btn_uch_new.Location = new System.Drawing.Point(175, 207);
            this.btn_uch_new.Name = "btn_uch_new";
            this.btn_uch_new.Size = new System.Drawing.Size(333, 65);
            this.btn_uch_new.TabIndex = 9;
            this.btn_uch_new.Text = "Я новый участник";
            this.btn_uch_new.UseVisualStyleBackColor = true;
            this.btn_uch_new.Click += new System.EventHandler(this.btn_uch_new_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "-- дней -- часов и -- минут до старта марафона!";
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(597, 324);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(73, 25);
            this.bt_login.TabIndex = 11;
            this.bt_login.Text = "login";
            this.bt_login.UseVisualStyleBackColor = false;
            // 
            // t
            // 
            this.t.Enabled = true;
            this.t.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 379);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_uch_new);
            this.Controls.Add(this.btn_uch_ranee);
            this.Controls.Add(this.btn_back_r);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация бегуна";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back_r;
        private System.Windows.Forms.Button btn_uch_ranee;
        private System.Windows.Forms.Button btn_uch_new;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Timer t;
    }
}