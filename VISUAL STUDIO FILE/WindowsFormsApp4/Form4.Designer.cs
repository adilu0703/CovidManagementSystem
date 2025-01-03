namespace WindowsFormsApp4
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VU = new System.Windows.Forms.Button();
            this.VS = new System.Windows.Forms.Button();
            this.VD = new System.Windows.Forms.Button();
            this.VI = new System.Windows.Forms.Button();
            this.VP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB1P = new System.Windows.Forms.TextBox();
            this.TB2P = new System.Windows.Forms.TextBox();
            this.TB4P = new System.Windows.Forms.TextBox();
            this.TB7P = new System.Windows.Forms.TextBox();
            this.TB5P = new System.Windows.Forms.TextBox();
            this.TB6P = new System.Windows.Forms.TextBox();
            this.TB8P = new System.Windows.Forms.TextBox();
            this.P_GRIDVIEW = new System.Windows.Forms.DataGridView();
            this.TB3P = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB9P = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB10P = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_GRIDVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-24, -76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(919, 709);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VU
            // 
            this.VU.BackColor = System.Drawing.Color.Teal;
            this.VU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VU.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VU.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VU.Location = new System.Drawing.Point(419, 472);
            this.VU.Name = "VU";
            this.VU.Size = new System.Drawing.Size(95, 32);
            this.VU.TabIndex = 8;
            this.VU.Text = "UPDATE";
            this.VU.UseVisualStyleBackColor = false;
            this.VU.Click += new System.EventHandler(this.VU_Click);
            // 
            // VS
            // 
            this.VS.BackColor = System.Drawing.Color.Teal;
            this.VS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VS.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VS.Location = new System.Drawing.Point(282, 472);
            this.VS.Name = "VS";
            this.VS.Size = new System.Drawing.Size(99, 32);
            this.VS.TabIndex = 9;
            this.VS.Text = "SEARCH";
            this.VS.UseVisualStyleBackColor = false;
            this.VS.Click += new System.EventHandler(this.VS_Click);
            // 
            // VD
            // 
            this.VD.BackColor = System.Drawing.Color.Teal;
            this.VD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VD.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VD.Location = new System.Drawing.Point(548, 472);
            this.VD.Name = "VD";
            this.VD.Size = new System.Drawing.Size(101, 32);
            this.VD.TabIndex = 10;
            this.VD.Text = "DELETE";
            this.VD.UseVisualStyleBackColor = false;
            this.VD.Click += new System.EventHandler(this.VD_Click);
            // 
            // VI
            // 
            this.VI.BackColor = System.Drawing.Color.Teal;
            this.VI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VI.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VI.Location = new System.Drawing.Point(151, 472);
            this.VI.Name = "VI";
            this.VI.Size = new System.Drawing.Size(98, 32);
            this.VI.TabIndex = 11;
            this.VI.Text = "INSERT";
            this.VI.UseVisualStyleBackColor = false;
            this.VI.Click += new System.EventHandler(this.button3_Click);
            // 
            // VP
            // 
            this.VP.BackColor = System.Drawing.Color.Teal;
            this.VP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VP.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VP.Location = new System.Drawing.Point(16, 472);
            this.VP.Name = "VP";
            this.VP.Size = new System.Drawing.Size(97, 32);
            this.VP.TabIndex = 12;
            this.VP.Text = "VIEW";
            this.VP.UseVisualStyleBackColor = false;
            this.VP.Click += new System.EventHandler(this.VP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(251, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "PATIENTS RECORD";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(670, 472);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 29);
            this.button5.TabIndex = 16;
            this.button5.Text = "HOME";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "PATIENT_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "PATIENT_NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "PATIENT_GENDER";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "PATIENT_AGE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "PATIENT_BLOODGP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "PATIENT ADDRESS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "PATIENT_CITY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "WARD_ID";
            // 
            // TB1P
            // 
            this.TB1P.Location = new System.Drawing.Point(227, 79);
            this.TB1P.Name = "TB1P";
            this.TB1P.Size = new System.Drawing.Size(124, 20);
            this.TB1P.TabIndex = 33;
            // 
            // TB2P
            // 
            this.TB2P.Location = new System.Drawing.Point(227, 121);
            this.TB2P.Name = "TB2P";
            this.TB2P.Size = new System.Drawing.Size(124, 20);
            this.TB2P.TabIndex = 34;
            this.TB2P.TextChanged += new System.EventHandler(this.TB2P_TextChanged);
            // 
            // TB4P
            // 
            this.TB4P.Location = new System.Drawing.Point(227, 196);
            this.TB4P.Name = "TB4P";
            this.TB4P.Size = new System.Drawing.Size(124, 20);
            this.TB4P.TabIndex = 36;
            // 
            // TB7P
            // 
            this.TB7P.Location = new System.Drawing.Point(227, 313);
            this.TB7P.Name = "TB7P";
            this.TB7P.Size = new System.Drawing.Size(124, 20);
            this.TB7P.TabIndex = 38;
            // 
            // TB5P
            // 
            this.TB5P.Location = new System.Drawing.Point(227, 232);
            this.TB5P.Name = "TB5P";
            this.TB5P.Size = new System.Drawing.Size(124, 20);
            this.TB5P.TabIndex = 39;
            // 
            // TB6P
            // 
            this.TB6P.Location = new System.Drawing.Point(227, 275);
            this.TB6P.Name = "TB6P";
            this.TB6P.Size = new System.Drawing.Size(124, 20);
            this.TB6P.TabIndex = 40;
            // 
            // TB8P
            // 
            this.TB8P.Location = new System.Drawing.Point(227, 357);
            this.TB8P.Name = "TB8P";
            this.TB8P.Size = new System.Drawing.Size(124, 20);
            this.TB8P.TabIndex = 41;
            // 
            // P_GRIDVIEW
            // 
            this.P_GRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.P_GRIDVIEW.Location = new System.Drawing.Point(444, 102);
            this.P_GRIDVIEW.Name = "P_GRIDVIEW";
            this.P_GRIDVIEW.Size = new System.Drawing.Size(240, 150);
            this.P_GRIDVIEW.TabIndex = 42;
            this.P_GRIDVIEW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.P_GRIDVIEW_CellContentClick);
            // 
            // TB3P
            // 
            this.TB3P.FormattingEnabled = true;
            this.TB3P.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.TB3P.Location = new System.Drawing.Point(227, 161);
            this.TB3P.Name = "TB3P";
            this.TB3P.Size = new System.Drawing.Size(121, 21);
            this.TB3P.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "WARD_NAME";
            // 
            // TB9P
            // 
            this.TB9P.FormattingEnabled = true;
            this.TB9P.Items.AddRange(new object[] {
            "I",
            "Q"});
            this.TB9P.Location = new System.Drawing.Point(227, 392);
            this.TB9P.Name = "TB9P";
            this.TB9P.Size = new System.Drawing.Size(121, 21);
            this.TB9P.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "STATUS";
            // 
            // TB10P
            // 
            this.TB10P.FormattingEnabled = true;
            this.TB10P.Items.AddRange(new object[] {
            "ALIVE",
            "DEAD",
            "RECOVERED"});
            this.TB10P.Location = new System.Drawing.Point(227, 431);
            this.TB10P.Name = "TB10P";
            this.TB10P.Size = new System.Drawing.Size(121, 21);
            this.TB10P.TabIndex = 48;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 527);
            this.Controls.Add(this.TB10P);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TB9P);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB3P);
            this.Controls.Add(this.P_GRIDVIEW);
            this.Controls.Add(this.TB8P);
            this.Controls.Add(this.TB6P);
            this.Controls.Add(this.TB5P);
            this.Controls.Add(this.TB7P);
            this.Controls.Add(this.TB4P);
            this.Controls.Add(this.TB2P);
            this.Controls.Add(this.TB1P);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VP);
            this.Controls.Add(this.VI);
            this.Controls.Add(this.VD);
            this.Controls.Add(this.VS);
            this.Controls.Add(this.VU);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_GRIDVIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button VU;
        private System.Windows.Forms.Button VS;
        private System.Windows.Forms.Button VD;
        private System.Windows.Forms.Button VI;
        private System.Windows.Forms.Button VP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB1P;
        private System.Windows.Forms.TextBox TB2P;
        private System.Windows.Forms.TextBox TB4P;
        private System.Windows.Forms.TextBox TB7P;
        private System.Windows.Forms.TextBox TB5P;
        private System.Windows.Forms.TextBox TB6P;
        private System.Windows.Forms.TextBox TB8P;
        private System.Windows.Forms.DataGridView P_GRIDVIEW;
        private System.Windows.Forms.ComboBox TB3P;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TB9P;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox TB10P;
    }
}