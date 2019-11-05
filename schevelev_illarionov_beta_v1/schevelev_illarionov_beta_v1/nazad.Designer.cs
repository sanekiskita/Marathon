namespace schevelev_illarionov_beta_v1
{
    partial class nazad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nazad));
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(21, 31);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 41;
            this.exit.Text = "Назад";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // nazad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 419);
            this.Controls.Add(this.exit);
            this.Name = "nazad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "nazad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.nazad_FormClosed);
            this.Load += new System.EventHandler(this.nazad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
    }
}