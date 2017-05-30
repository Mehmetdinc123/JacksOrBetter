namespace jacksorbetter
{
    partial class Oyun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oyun));
            this.kart1_button = new System.Windows.Forms.Button();
            this.kart2_button = new System.Windows.Forms.Button();
            this.kart3_button = new System.Windows.Forms.Button();
            this.dealDraw_button = new System.Windows.Forms.Button();
            this.betOne_button = new System.Windows.Forms.Button();
            this.betMax_button = new System.Windows.Forms.Button();
            this.hold1_label = new System.Windows.Forms.Label();
            this.hold2_label = new System.Windows.Forms.Label();
            this.hold3_label = new System.Windows.Forms.Label();
            this.sp_label = new System.Windows.Forms.Label();
            this.isim_label = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kombinasyonTablosu = new System.Windows.Forms.ListView();
            this.hold4_label = new System.Windows.Forms.Label();
            this.hold5_label = new System.Windows.Forms.Label();
            this.kart4_button = new System.Windows.Forms.Button();
            this.kart5_button = new System.Windows.Forms.Button();
            this.timer_listview = new System.Windows.Forms.Timer(this.components);
            this.timer_kartlar = new System.Windows.Forms.Timer(this.components);
            this.timer_sp = new System.Windows.Forms.Timer(this.components);
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.holdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kart1_button
            // 
            this.kart1_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kart1_button.BackgroundImage")));
            this.kart1_button.ForeColor = System.Drawing.Color.Black;
            this.kart1_button.Location = new System.Drawing.Point(71, 424);
            this.kart1_button.Name = "kart1_button";
            this.kart1_button.Size = new System.Drawing.Size(74, 98);
            this.kart1_button.TabIndex = 0;
            this.kart1_button.UseVisualStyleBackColor = true;
            this.kart1_button.Visible = false;
            this.kart1_button.Click += new System.EventHandler(this.kart1_Click);
            // 
            // kart2_button
            // 
            this.kart2_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kart2_button.BackgroundImage")));
            this.kart2_button.ForeColor = System.Drawing.Color.Black;
            this.kart2_button.Location = new System.Drawing.Point(151, 424);
            this.kart2_button.Name = "kart2_button";
            this.kart2_button.Size = new System.Drawing.Size(74, 98);
            this.kart2_button.TabIndex = 1;
            this.kart2_button.UseVisualStyleBackColor = true;
            this.kart2_button.Visible = false;
            this.kart2_button.Click += new System.EventHandler(this.kart2_Click);
            // 
            // kart3_button
            // 
            this.kart3_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kart3_button.BackgroundImage")));
            this.kart3_button.ForeColor = System.Drawing.Color.Black;
            this.kart3_button.Location = new System.Drawing.Point(231, 424);
            this.kart3_button.Name = "kart3_button";
            this.kart3_button.Size = new System.Drawing.Size(74, 98);
            this.kart3_button.TabIndex = 2;
            this.kart3_button.UseVisualStyleBackColor = true;
            this.kart3_button.Visible = false;
            this.kart3_button.Click += new System.EventHandler(this.kart3_Click);
            // 
            // dealDraw_button
            // 
            this.dealDraw_button.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dealDraw_button.Location = new System.Drawing.Point(391, 562);
            this.dealDraw_button.Name = "dealDraw_button";
            this.dealDraw_button.Size = new System.Drawing.Size(74, 32);
            this.dealDraw_button.TabIndex = 8;
            this.dealDraw_button.Text = "Deal";
            this.dealDraw_button.UseVisualStyleBackColor = true;
            this.dealDraw_button.Visible = false;
            this.dealDraw_button.Click += new System.EventHandler(this.dealDraw_button_Click);
            // 
            // betOne_button
            // 
            this.betOne_button.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.betOne_button.Location = new System.Drawing.Point(71, 562);
            this.betOne_button.Name = "betOne_button";
            this.betOne_button.Size = new System.Drawing.Size(74, 32);
            this.betOne_button.TabIndex = 5;
            this.betOne_button.Text = "Bet +";
            this.betOne_button.UseVisualStyleBackColor = true;
            this.betOne_button.Visible = false;
            this.betOne_button.Click += new System.EventHandler(this.betOne_button_Click);
            // 
            // betMax_button
            // 
            this.betMax_button.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.betMax_button.Location = new System.Drawing.Point(151, 562);
            this.betMax_button.Name = "betMax_button";
            this.betMax_button.Size = new System.Drawing.Size(74, 32);
            this.betMax_button.TabIndex = 6;
            this.betMax_button.Text = "Bet Mx";
            this.betMax_button.UseVisualStyleBackColor = true;
            this.betMax_button.Visible = false;
            this.betMax_button.Click += new System.EventHandler(this.betMax_button_Click);
            // 
            // hold1_label
            // 
            this.hold1_label.AutoSize = true;
            this.hold1_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hold1_label.ForeColor = System.Drawing.SystemColors.Control;
            this.hold1_label.Location = new System.Drawing.Point(94, 525);
            this.hold1_label.Name = "hold1_label";
            this.hold1_label.Size = new System.Drawing.Size(32, 15);
            this.hold1_label.TabIndex = 9;
            this.hold1_label.Text = "Hold";
            // 
            // hold2_label
            // 
            this.hold2_label.AutoSize = true;
            this.hold2_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hold2_label.ForeColor = System.Drawing.SystemColors.Control;
            this.hold2_label.Location = new System.Drawing.Point(170, 525);
            this.hold2_label.Name = "hold2_label";
            this.hold2_label.Size = new System.Drawing.Size(32, 15);
            this.hold2_label.TabIndex = 10;
            this.hold2_label.Text = "Hold";
            // 
            // hold3_label
            // 
            this.hold3_label.AutoSize = true;
            this.hold3_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hold3_label.ForeColor = System.Drawing.SystemColors.Control;
            this.hold3_label.Location = new System.Drawing.Point(256, 525);
            this.hold3_label.Name = "hold3_label";
            this.hold3_label.Size = new System.Drawing.Size(32, 15);
            this.hold3_label.TabIndex = 11;
            this.hold3_label.Text = "Hold";
            // 
            // sp_label
            // 
            this.sp_label.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sp_label.ForeColor = System.Drawing.Color.Gold;
            this.sp_label.Location = new System.Drawing.Point(396, 58);
            this.sp_label.Name = "sp_label";
            this.sp_label.Size = new System.Drawing.Size(107, 33);
            this.sp_label.TabIndex = 14;
            this.sp_label.Text = "100 Sp";
            this.sp_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sp_label.Visible = false;
            // 
            // isim_label
            // 
            this.isim_label.AutoSize = true;
            this.isim_label.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim_label.ForeColor = System.Drawing.Color.Gold;
            this.isim_label.Location = new System.Drawing.Point(34, 65);
            this.isim_label.Name = "isim_label";
            this.isim_label.Size = new System.Drawing.Size(49, 25);
            this.isim_label.TabIndex = 15;
            this.isim_label.Text = "Hi, ";
            this.isim_label.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "1";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 65;
            // 
            // kombinasyonTablosu
            // 
            this.kombinasyonTablosu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kombinasyonTablosu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kombinasyonTablosu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.kombinasyonTablosu.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kombinasyonTablosu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kombinasyonTablosu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.kombinasyonTablosu.Location = new System.Drawing.Point(39, 105);
            this.kombinasyonTablosu.MultiSelect = false;
            this.kombinasyonTablosu.Name = "kombinasyonTablosu";
            this.kombinasyonTablosu.Size = new System.Drawing.Size(464, 282);
            this.kombinasyonTablosu.TabIndex = 8;
            this.kombinasyonTablosu.TabStop = false;
            this.kombinasyonTablosu.UseCompatibleStateImageBehavior = false;
            this.kombinasyonTablosu.View = System.Windows.Forms.View.Details;
            this.kombinasyonTablosu.Visible = false;
            this.kombinasyonTablosu.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.kombinasyonTablosu_ColumnWidthChanging);
            this.kombinasyonTablosu.SelectedIndexChanged += new System.EventHandler(this.kombinasyonTablosu_SelectedIndexChanged);
            // 
            // hold4_label
            // 
            this.hold4_label.AutoSize = true;
            this.hold4_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hold4_label.ForeColor = System.Drawing.SystemColors.Control;
            this.hold4_label.Location = new System.Drawing.Point(333, 525);
            this.hold4_label.Name = "hold4_label";
            this.hold4_label.Size = new System.Drawing.Size(32, 15);
            this.hold4_label.TabIndex = 12;
            this.hold4_label.Text = "Hold";
            // 
            // hold5_label
            // 
            this.hold5_label.AutoSize = true;
            this.hold5_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hold5_label.ForeColor = System.Drawing.SystemColors.Control;
            this.hold5_label.Location = new System.Drawing.Point(415, 525);
            this.hold5_label.Name = "hold5_label";
            this.hold5_label.Size = new System.Drawing.Size(32, 15);
            this.hold5_label.TabIndex = 13;
            this.hold5_label.Text = "Hold";
            // 
            // kart4_button
            // 
            this.kart4_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kart4_button.BackgroundImage")));
            this.kart4_button.ForeColor = System.Drawing.Color.Black;
            this.kart4_button.Location = new System.Drawing.Point(311, 424);
            this.kart4_button.Name = "kart4_button";
            this.kart4_button.Size = new System.Drawing.Size(74, 98);
            this.kart4_button.TabIndex = 3;
            this.kart4_button.UseVisualStyleBackColor = true;
            this.kart4_button.Visible = false;
            this.kart4_button.Click += new System.EventHandler(this.kart4_Click);
            // 
            // kart5_button
            // 
            this.kart5_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kart5_button.BackgroundImage")));
            this.kart5_button.ForeColor = System.Drawing.Color.Black;
            this.kart5_button.Location = new System.Drawing.Point(391, 424);
            this.kart5_button.Name = "kart5_button";
            this.kart5_button.Size = new System.Drawing.Size(74, 98);
            this.kart5_button.TabIndex = 4;
            this.kart5_button.UseVisualStyleBackColor = true;
            this.kart5_button.Visible = false;
            this.kart5_button.Click += new System.EventHandler(this.kart5_Click);
            // 
            // timer_listview
            // 
            this.timer_listview.Interval = 444;
            this.timer_listview.Tick += new System.EventHandler(this.timer_listview_Tick);
            // 
            // timer_kartlar
            // 
            this.timer_kartlar.Tick += new System.EventHandler(this.timer_kartlar_Tick);
            // 
            // timer_sp
            // 
            this.timer_sp.Interval = 60;
            this.timer_sp.Tick += new System.EventHandler(this.timer_sp_Tick);
            // 
            // username_textBox
            // 
            this.username_textBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_textBox.Location = new System.Drawing.Point(231, 271);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(164, 27);
            this.username_textBox.TabIndex = 18;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_label.ForeColor = System.Drawing.Color.Gold;
            this.username_label.Location = new System.Drawing.Point(113, 275);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(112, 23);
            this.username_label.TabIndex = 19;
            this.username_label.Text = "Username :";
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Start_Button.Location = new System.Drawing.Point(231, 320);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(74, 32);
            this.Start_Button.TabIndex = 20;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Click);
            // 
            // holdButton
            // 
            this.holdButton.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.holdButton.ForeColor = System.Drawing.Color.Black;
            this.holdButton.Location = new System.Drawing.Point(311, 562);
            this.holdButton.Name = "holdButton";
            this.holdButton.Size = new System.Drawing.Size(74, 32);
            this.holdButton.TabIndex = 7;
            this.holdButton.Text = "Hold All";
            this.holdButton.UseVisualStyleBackColor = true;
            this.holdButton.Visible = false;
            this.holdButton.Click += new System.EventHandler(this.HoldButton_Click);
            // 
            // Oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(532, 638);
            this.Controls.Add(this.holdButton);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.kart5_button);
            this.Controls.Add(this.kart4_button);
            this.Controls.Add(this.isim_label);
            this.Controls.Add(this.sp_label);
            this.Controls.Add(this.hold5_label);
            this.Controls.Add(this.hold4_label);
            this.Controls.Add(this.hold3_label);
            this.Controls.Add(this.hold2_label);
            this.Controls.Add(this.hold1_label);
            this.Controls.Add(this.kombinasyonTablosu);
            this.Controls.Add(this.betMax_button);
            this.Controls.Add(this.betOne_button);
            this.Controls.Add(this.dealDraw_button);
            this.Controls.Add(this.kart3_button);
            this.Controls.Add(this.kart2_button);
            this.Controls.Add(this.kart1_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Oyun";
            this.ShowIcon = false;
            this.Text = "Jacks Or Better";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dealDraw_button;
        private System.Windows.Forms.Button betOne_button;
        private System.Windows.Forms.Button betMax_button;
        private System.Windows.Forms.Label hold1_label;
        private System.Windows.Forms.Label hold2_label;
        private System.Windows.Forms.Label hold3_label;
        private System.Windows.Forms.Label sp_label;
        private System.Windows.Forms.Label isim_label;
        private System.Windows.Forms.Label hold4_label;
        private System.Windows.Forms.Label hold5_label;
        public System.Windows.Forms.Button kart1_button;
        public System.Windows.Forms.Button kart2_button;
        public System.Windows.Forms.Button kart3_button;
        public System.Windows.Forms.Button kart4_button;
        public System.Windows.Forms.Button kart5_button;
        private System.Windows.Forms.Timer timer_listview;
        private System.Windows.Forms.Timer timer_kartlar;
        private System.Windows.Forms.Timer timer_sp;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button Start_Button;
        public System.Windows.Forms.ListView kombinasyonTablosu;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button holdButton;
    }
}

