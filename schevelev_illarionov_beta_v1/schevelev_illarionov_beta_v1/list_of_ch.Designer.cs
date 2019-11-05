namespace schevelev_illarionov_beta_v1
{
    partial class list_of_ch
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
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(182, 427);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(394, 20);
            this.label14.TabIndex = 44;
            this.label14.Text = "-- дней -- часов и -- минут до старта марафона!";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(107, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(553, 44);
            this.label3.TabIndex = 43;
            this.label3.Text = "Это - список всех благотворительных учреждений, которые поддерживаются в Marathon" +
    " Skills 2017. Спасибо за помощь вы поддерживаете их, спонсируя бегунов!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Список благотворительных организаций";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "MARATHON SKILLS 2017";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(40, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 40;
            this.exit.Text = "Назад";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // t
            // 
            this.t.Enabled = true;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 160);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(677, 264);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // list_of_ch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 451);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "list_of_ch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список организаций";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.list_of_ch_FormClosed);
            this.Load += new System.EventHandler(this.list_of_ch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Timer t;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}