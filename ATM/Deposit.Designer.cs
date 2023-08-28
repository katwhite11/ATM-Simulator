namespace ATM
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menubtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amtBox = new System.Windows.Forms.TextBox();
            this.firstLast = new System.Windows.Forms.Label();
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.gobtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(56, 382);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(492, 82);
            this.flowLayoutPanel1.TabIndex = 28;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "ATM - ZZZ BANK - Deposit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 56);
            this.pictureBox1.TabIndex = 22;
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
            this.label3.TabIndex = 21;
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
            this.exitbtn.TabIndex = 19;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(199, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "AMOUNT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(183, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "ACCOUNT #:";
            // 
            // amtBox
            // 
            this.amtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.amtBox.Location = new System.Drawing.Point(304, 285);
            this.amtBox.Multiline = true;
            this.amtBox.Name = "amtBox";
            this.amtBox.Size = new System.Drawing.Size(156, 31);
            this.amtBox.TabIndex = 32;
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
            this.firstLast.TabIndex = 33;
            this.firstLast.Text = "First Last";
            this.firstLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropDown
            // 
            this.dropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropDown.DropDownHeight = 120;
            this.dropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDown.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dropDown.FormattingEnabled = true;
            this.dropDown.IntegralHeight = false;
            this.dropDown.Location = new System.Drawing.Point(304, 228);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(156, 36);
            this.dropDown.TabIndex = 44;
            this.dropDown.SelectedIndexChanged += new System.EventHandler(this.dropDown_SelectedIndexChanged);
            // 
            // gobtn
            // 
            this.gobtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.gobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gobtn.FlatAppearance.BorderSize = 0;
            this.gobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gobtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gobtn.Location = new System.Drawing.Point(484, 249);
            this.gobtn.Name = "gobtn";
            this.gobtn.Size = new System.Drawing.Size(59, 44);
            this.gobtn.TabIndex = 45;
            this.gobtn.Text = "GO";
            this.gobtn.UseVisualStyleBackColor = false;
            this.gobtn.Click += new System.EventHandler(this.gobtn_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(604, 497);
            this.Controls.Add(this.gobtn);
            this.Controls.Add(this.dropDown);
            this.Controls.Add(this.firstLast);
            this.Controls.Add(this.amtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button menubtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amtBox;
        private System.Windows.Forms.Label firstLast;
        private System.Windows.Forms.ComboBox dropDown;
        private System.Windows.Forms.Button gobtn;
    }
}