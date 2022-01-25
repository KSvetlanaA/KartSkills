
namespace KartSkills
{
    partial class MenuKoord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuKoord));
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gonButton = new System.Windows.Forms.Button();
            this.sponsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(415, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 32);
            this.label6.TabIndex = 36;
            this.label6.Text = "Меню координатора";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F);
            this.button1.Location = new System.Drawing.Point(907, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 46);
            this.button1.TabIndex = 35;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(19, 679);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(964, 27);
            this.label5.TabIndex = 34;
            this.label5.Text = "До начала событий осталось 0 лет, 8 месяцев, 5 дней, 5 часов, 13 минут и 18 секун" +
    "д.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(367, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "Москва, Россия 20 июня 2017";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label3.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(388, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 45);
            this.label3.TabIndex = 32;
            this.label3.Text = "Kart Skills 2017";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(-6, 636);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1071, 104);
            this.label2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(-6, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1071, 104);
            this.label1.TabIndex = 30;
            // 
            // gonButton
            // 
            this.gonButton.Font = new System.Drawing.Font("Arial", 12F);
            this.gonButton.Location = new System.Drawing.Point(96, 242);
            this.gonButton.Name = "gonButton";
            this.gonButton.Size = new System.Drawing.Size(294, 70);
            this.gonButton.TabIndex = 38;
            this.gonButton.Text = "Гонщики";
            this.gonButton.UseVisualStyleBackColor = true;
            // 
            // sponsButton
            // 
            this.sponsButton.Font = new System.Drawing.Font("Arial", 12F);
            this.sponsButton.Location = new System.Drawing.Point(668, 242);
            this.sponsButton.Name = "sponsButton";
            this.sponsButton.Size = new System.Drawing.Size(290, 70);
            this.sponsButton.TabIndex = 37;
            this.sponsButton.Text = "Спонсоры";
            this.sponsButton.UseVisualStyleBackColor = true;
            // 
            // MenuKoord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 740);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gonButton);
            this.Controls.Add(this.sponsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuKoord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "          Kart Skills 2017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gonButton;
        private System.Windows.Forms.Button sponsButton;
    }
}