namespace WindowsFormsApp4
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VD = new System.Windows.Forms.Button();
            this.IND = new System.Windows.Forms.Button();
            this.DD = new System.Windows.Forms.Button();
            this.SD = new System.Windows.Forms.Button();
            this.UD = new System.Windows.Forms.Button();
            this.HD = new System.Windows.Forms.Button();
            this.TB3I = new System.Windows.Forms.TextBox();
            this.TB2I = new System.Windows.Forms.TextBox();
            this.TB1I = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ISOMGRIDVIEW = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISOMGRIDVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-100, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(993, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "ISOLATION WARD DETAILS";
            // 
            // VD
            // 
            this.VD.BackColor = System.Drawing.Color.Teal;
            this.VD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VD.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VD.Location = new System.Drawing.Point(448, 246);
            this.VD.Name = "VD";
            this.VD.Size = new System.Drawing.Size(170, 32);
            this.VD.TabIndex = 8;
            this.VD.Text = "VIEW WARD DETAILS";
            this.VD.UseVisualStyleBackColor = false;
            this.VD.Click += new System.EventHandler(this.VD_Click);
            // 
            // IND
            // 
            this.IND.BackColor = System.Drawing.Color.Teal;
            this.IND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IND.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IND.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IND.Location = new System.Drawing.Point(29, 241);
            this.IND.Name = "IND";
            this.IND.Size = new System.Drawing.Size(116, 32);
            this.IND.TabIndex = 9;
            this.IND.Text = "INSERT";
            this.IND.UseVisualStyleBackColor = false;
            this.IND.Click += new System.EventHandler(this.IND_Click);
            // 
            // DD
            // 
            this.DD.BackColor = System.Drawing.Color.Teal;
            this.DD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DD.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DD.Location = new System.Drawing.Point(29, 355);
            this.DD.Name = "DD";
            this.DD.Size = new System.Drawing.Size(116, 32);
            this.DD.TabIndex = 10;
            this.DD.Text = "DELETE";
            this.DD.UseVisualStyleBackColor = false;
            this.DD.Click += new System.EventHandler(this.DD_Click);
            // 
            // SD
            // 
            this.SD.BackColor = System.Drawing.Color.Teal;
            this.SD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SD.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SD.Location = new System.Drawing.Point(29, 279);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(116, 32);
            this.SD.TabIndex = 11;
            this.SD.Text = "SEARCH";
            this.SD.UseVisualStyleBackColor = false;
            this.SD.Click += new System.EventHandler(this.SD_Click);
            // 
            // UD
            // 
            this.UD.BackColor = System.Drawing.Color.Teal;
            this.UD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UD.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UD.Location = new System.Drawing.Point(29, 317);
            this.UD.Name = "UD";
            this.UD.Size = new System.Drawing.Size(116, 32);
            this.UD.TabIndex = 12;
            this.UD.Text = "UPDATE";
            this.UD.UseVisualStyleBackColor = false;
            this.UD.Click += new System.EventHandler(this.UD_Click);
            // 
            // HD
            // 
            this.HD.BackColor = System.Drawing.Color.Teal;
            this.HD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HD.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HD.Location = new System.Drawing.Point(29, 453);
            this.HD.Name = "HD";
            this.HD.Size = new System.Drawing.Size(116, 29);
            this.HD.TabIndex = 17;
            this.HD.Text = "HOME";
            this.HD.UseVisualStyleBackColor = false;
            this.HD.Click += new System.EventHandler(this.HD_Click);
            // 
            // TB3I
            // 
            this.TB3I.Location = new System.Drawing.Point(141, 178);
            this.TB3I.Name = "TB3I";
            this.TB3I.Size = new System.Drawing.Size(124, 20);
            this.TB3I.TabIndex = 19;
            // 
            // TB2I
            // 
            this.TB2I.Location = new System.Drawing.Point(141, 143);
            this.TB2I.Name = "TB2I";
            this.TB2I.Size = new System.Drawing.Size(124, 20);
            this.TB2I.TabIndex = 20;
            // 
            // TB1I
            // 
            this.TB1I.Location = new System.Drawing.Point(141, 104);
            this.TB1I.Name = "TB1I";
            this.TB1I.Size = new System.Drawing.Size(124, 20);
            this.TB1I.TabIndex = 21;
            this.TB1I.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "WARD_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "BEDS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "CITY";
            // 
            // ISOMGRIDVIEW
            // 
            this.ISOMGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ISOMGRIDVIEW.Location = new System.Drawing.Point(314, 73);
            this.ISOMGRIDVIEW.Name = "ISOMGRIDVIEW";
            this.ISOMGRIDVIEW.Size = new System.Drawing.Size(431, 150);
            this.ISOMGRIDVIEW.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(29, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 32);
            this.button3.TabIndex = 26;
            this.button3.Text = "ISOLATION WARD PATIENTS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ISOMGRIDVIEW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB1I);
            this.Controls.Add(this.TB2I);
            this.Controls.Add(this.TB3I);
            this.Controls.Add(this.HD);
            this.Controls.Add(this.UD);
            this.Controls.Add(this.SD);
            this.Controls.Add(this.DD);
            this.Controls.Add(this.IND);
            this.Controls.Add(this.VD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form16";
            this.Text = "Form16";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISOMGRIDVIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VD;
        private System.Windows.Forms.Button IND;
        private System.Windows.Forms.Button DD;
        private System.Windows.Forms.Button SD;
        private System.Windows.Forms.Button UD;
        private System.Windows.Forms.Button HD;
        private System.Windows.Forms.TextBox TB3I;
        private System.Windows.Forms.TextBox TB2I;
        private System.Windows.Forms.TextBox TB1I;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ISOMGRIDVIEW;
        private System.Windows.Forms.Button button3;
    }
}