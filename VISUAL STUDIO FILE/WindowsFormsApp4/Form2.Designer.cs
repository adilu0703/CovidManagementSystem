namespace WindowsFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IND = new System.Windows.Forms.Button();
            this.SD = new System.Windows.Forms.Button();
            this.DD = new System.Windows.Forms.Button();
            this.UD = new System.Windows.Forms.Button();
            this.VD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TB1D = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB4D = new System.Windows.Forms.TextBox();
            this.TB2D = new System.Windows.Forms.TextBox();
            this.TB3D = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TB5D = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB6D = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-498, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1770, 542);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IND
            // 
            this.IND.BackColor = System.Drawing.Color.Teal;
            this.IND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IND.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IND.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IND.Location = new System.Drawing.Point(177, 309);
            this.IND.Name = "IND";
            this.IND.Size = new System.Drawing.Size(116, 32);
            this.IND.TabIndex = 2;
            this.IND.Text = "INSERT";
            this.IND.UseVisualStyleBackColor = false;
            this.IND.Click += new System.EventHandler(this.IND_Click);
            // 
            // SD
            // 
            this.SD.BackColor = System.Drawing.Color.Teal;
            this.SD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SD.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SD.Location = new System.Drawing.Point(177, 376);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(116, 32);
            this.SD.TabIndex = 4;
            this.SD.Text = "SEARCH";
            this.SD.UseVisualStyleBackColor = false;
            this.SD.Click += new System.EventHandler(this.SD_Click);
            // 
            // DD
            // 
            this.DD.BackColor = System.Drawing.Color.Teal;
            this.DD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DD.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DD.Location = new System.Drawing.Point(27, 376);
            this.DD.Name = "DD";
            this.DD.Size = new System.Drawing.Size(116, 32);
            this.DD.TabIndex = 5;
            this.DD.Text = "DELETE";
            this.DD.UseVisualStyleBackColor = false;
            this.DD.Click += new System.EventHandler(this.DD_Click);
            // 
            // UD
            // 
            this.UD.BackColor = System.Drawing.Color.Teal;
            this.UD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UD.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UD.Location = new System.Drawing.Point(27, 432);
            this.UD.Name = "UD";
            this.UD.Size = new System.Drawing.Size(116, 32);
            this.UD.TabIndex = 6;
            this.UD.Text = "UPDATE";
            this.UD.UseVisualStyleBackColor = false;
            this.UD.Click += new System.EventHandler(this.UD_Click);
            // 
            // VD
            // 
            this.VD.BackColor = System.Drawing.Color.Teal;
            this.VD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VD.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VD.Location = new System.Drawing.Point(27, 309);
            this.VD.Name = "VD";
            this.VD.Size = new System.Drawing.Size(116, 32);
            this.VD.TabIndex = 7;
            this.VD.Text = "VIEW";
            this.VD.UseVisualStyleBackColor = false;
            this.VD.Click += new System.EventHandler(this.VD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "DOCTOR\'S DETAIL";
            // 
            // HD
            // 
            this.HD.BackColor = System.Drawing.Color.Teal;
            this.HD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HD.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HD.Location = new System.Drawing.Point(177, 435);
            this.HD.Name = "HD";
            this.HD.Size = new System.Drawing.Size(116, 29);
            this.HD.TabIndex = 16;
            this.HD.Text = "HOME";
            this.HD.UseVisualStyleBackColor = false;
            this.HD.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(504, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 239);
            this.dataGridView1.TabIndex = 17;
            // 
            // TB1D
            // 
            this.TB1D.Location = new System.Drawing.Point(153, 73);
            this.TB1D.Name = "TB1D";
            this.TB1D.Size = new System.Drawing.Size(124, 20);
            this.TB1D.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "DR_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "DR_NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "AGE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "WARD_NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "GENDER";
            // 
            // TB4D
            // 
            this.TB4D.Location = new System.Drawing.Point(153, 196);
            this.TB4D.Name = "TB4D";
            this.TB4D.Size = new System.Drawing.Size(124, 20);
            this.TB4D.TabIndex = 25;
            // 
            // TB2D
            // 
            this.TB2D.Location = new System.Drawing.Point(153, 115);
            this.TB2D.Name = "TB2D";
            this.TB2D.Size = new System.Drawing.Size(124, 20);
            this.TB2D.TabIndex = 27;
            // 
            // TB3D
            // 
            this.TB3D.FormattingEnabled = true;
            this.TB3D.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.TB3D.Location = new System.Drawing.Point(153, 158);
            this.TB3D.Name = "TB3D";
            this.TB3D.Size = new System.Drawing.Size(121, 21);
            this.TB3D.TabIndex = 28;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TB5D
            // 
            this.TB5D.FormattingEnabled = true;
            this.TB5D.Items.AddRange(new object[] {
            "I",
            "Q"});
            this.TB5D.Location = new System.Drawing.Point(152, 235);
            this.TB5D.Name = "TB5D";
            this.TB5D.Size = new System.Drawing.Size(125, 21);
            this.TB5D.TabIndex = 30;
            this.TB5D.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "WARD_ID";
            // 
            // TB6D
            // 
            this.TB6D.Location = new System.Drawing.Point(153, 273);
            this.TB6D.Name = "TB6D";
            this.TB6D.Size = new System.Drawing.Size(124, 20);
            this.TB6D.TabIndex = 32;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.TB6D);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB5D);
            this.Controls.Add(this.TB3D);
            this.Controls.Add(this.TB2D);
            this.Controls.Add(this.TB4D);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB1D);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VD);
            this.Controls.Add(this.UD);
            this.Controls.Add(this.DD);
            this.Controls.Add(this.SD);
            this.Controls.Add(this.IND);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button IND;
        private System.Windows.Forms.Button SD;
        private System.Windows.Forms.Button DD;
        private System.Windows.Forms.Button UD;
        private System.Windows.Forms.Button VD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TB1D;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB4D;
        private System.Windows.Forms.TextBox TB2D;
        private System.Windows.Forms.ComboBox TB3D;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox TB5D;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB6D;
    }
}