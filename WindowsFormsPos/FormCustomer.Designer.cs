namespace WindowsFormsPos
{
    partial class FormCustomer
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
            this.newbtn = new System.Windows.Forms.Button();
            this.customerlistbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.codelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.phonenolbl = new System.Windows.Forms.Label();
            this.txtcustcode = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtphoneno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newbtn
            // 
            this.newbtn.BackColor = System.Drawing.Color.MediumBlue;
            this.newbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.newbtn.Location = new System.Drawing.Point(99, 32);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(96, 33);
            this.newbtn.TabIndex = 0;
            this.newbtn.Text = "New";
            this.newbtn.UseVisualStyleBackColor = false;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // customerlistbtn
            // 
            this.customerlistbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.customerlistbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customerlistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerlistbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerlistbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.customerlistbtn.Location = new System.Drawing.Point(201, 32);
            this.customerlistbtn.Name = "customerlistbtn";
            this.customerlistbtn.Size = new System.Drawing.Size(118, 33);
            this.customerlistbtn.TabIndex = 1;
            this.customerlistbtn.Text = "Customer List";
            this.customerlistbtn.UseVisualStyleBackColor = false;
            this.customerlistbtn.Click += new System.EventHandler(this.customerlistbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.savebtn.Location = new System.Drawing.Point(525, 273);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(96, 33);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.updatebtn.Location = new System.Drawing.Point(628, 273);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(96, 33);
            this.updatebtn.TabIndex = 3;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Crimson;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deletebtn.Location = new System.Drawing.Point(730, 272);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(96, 33);
            this.deletebtn.TabIndex = 4;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // codelbl
            // 
            this.codelbl.AutoSize = true;
            this.codelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codelbl.Location = new System.Drawing.Point(96, 108);
            this.codelbl.Name = "codelbl";
            this.codelbl.Size = new System.Drawing.Size(114, 16);
            this.codelbl.TabIndex = 5;
            this.codelbl.Text = "Customer Code";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(96, 163);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(118, 16);
            this.namelbl.TabIndex = 6;
            this.namelbl.Text = "Customer Name";
            // 
            // phonenolbl
            // 
            this.phonenolbl.AutoSize = true;
            this.phonenolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenolbl.Location = new System.Drawing.Point(96, 214);
            this.phonenolbl.Name = "phonenolbl";
            this.phonenolbl.Size = new System.Drawing.Size(110, 16);
            this.phonenolbl.TabIndex = 7;
            this.phonenolbl.Text = "Phone Number";
            // 
            // txtcustcode
            // 
            this.txtcustcode.Location = new System.Drawing.Point(272, 101);
            this.txtcustcode.Multiline = true;
            this.txtcustcode.Name = "txtcustcode";
            this.txtcustcode.Size = new System.Drawing.Size(364, 34);
            this.txtcustcode.TabIndex = 8;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(272, 154);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(364, 34);
            this.txtname.TabIndex = 9;
            // 
            // txtphoneno
            // 
            this.txtphoneno.Location = new System.Drawing.Point(272, 205);
            this.txtphoneno.Multiline = true;
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(364, 34);
            this.txtphoneno.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(864, 366);
            this.Controls.Add(this.txtphoneno);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcustcode);
            this.Controls.Add(this.phonenolbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.codelbl);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.customerlistbtn);
            this.Controls.Add(this.newbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button customerlistbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Label codelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label phonenolbl;
        private System.Windows.Forms.TextBox txtcustcode;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtphoneno;
    }
}

