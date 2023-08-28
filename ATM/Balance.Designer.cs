namespace ATM
{
    partial class Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.accBalance = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menubtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstLast = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ATM - ZZZ BANK - Balance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 56);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(198, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "WELCOME,";
            // 
            // exitbtn
            // 
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.exitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitbtn.Location = new System.Drawing.Point(491, 12);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(101, 35);
            this.exitbtn.TabIndex = 8;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(183, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "ACCOUNT #:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(199, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "BALANCE:";
            // 
            // accBalance
            // 
            this.accBalance.AutoSize = true;
            this.accBalance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accBalance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.accBalance.Location = new System.Drawing.Point(328, 268);
            this.accBalance.Name = "accBalance";
            this.accBalance.Size = new System.Drawing.Size(126, 41);
            this.accBalance.TabIndex = 17;
            this.accBalance.Text = "Balance";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(56, 382);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(492, 82);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.menubtn);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 73);
            this.panel4.TabIndex = 2;
            // 
            // menubtn
            // 
            this.menubtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menubtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menubtn.FlatAppearance.BorderSize = 0;
            this.menubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menubtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menubtn.Location = new System.Drawing.Point(0, 0);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(239, 73);
            this.menubtn.TabIndex = 5;
            this.menubtn.Text = "MAIN MENU";
            this.menubtn.UseVisualStyleBackColor = false;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.logoutbtn);
            this.panel6.Location = new System.Drawing.Point(248, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 73);
            this.panel6.TabIndex = 4;
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logoutbtn.Location = new System.Drawing.Point(0, 0);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(239, 73);
            this.logoutbtn.TabIndex = 6;
            this.logoutbtn.Text = "LOGOUT";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // dropDown
            // 
            this.dropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropDown.DropDownHeight = 120;
            this.dropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDown.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dropDown.FormattingEnabled = true;
            this.dropDown.IntegralHeight = false;
            this.dropDown.Location = new System.Drawing.Point(304, 222);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(156, 36);
            this.dropDown.TabIndex = 20;
            this.dropDown.SelectedIndexChanged += new System.EventHandler(this.dropDown_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(287, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 41);
            this.label4.TabIndex = 21;
            this.label4.Text = "$";
            // 
            // firstLast
            // 
            this.firstLast.AutoSize = true;
            this.firstLast.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLast.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.firstLast.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.firstLast.Location = new System.Drawing.Point(243, 113);
            this.firstLast.Name = "firstLast";
            this.firstLast.Size = new System.Drawing.Size(110, 31);
            this.firstLast.TabIndex = 22;
            this.firstLast.Text = "First Last";
            this.firstLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(604, 497);
            this.Controls.Add(this.firstLast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dropDown);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.accBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label accBalance;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button menubtn;
        private System.Windows.Forms.ComboBox dropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label firstLast;
    }
}