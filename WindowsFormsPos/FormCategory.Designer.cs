namespace WindowsFormsPos
{
    partial class FormCategory
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcatcode = new System.Windows.Forms.TextBox();
            this.parentlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.codelbl = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.btncategorylist = new System.Windows.Forms.Button();
            this.btnnewcat = new System.Windows.Forms.Button();
            this.comboparent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(212, 157);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(286, 34);
            this.txtname.TabIndex = 20;
            // 
            // txtcatcode
            // 
            this.txtcatcode.Location = new System.Drawing.Point(212, 104);
            this.txtcatcode.Multiline = true;
            this.txtcatcode.Name = "txtcatcode";
            this.txtcatcode.Size = new System.Drawing.Size(286, 34);
            this.txtcatcode.TabIndex = 19;
            // 
            // parentlbl
            // 
            this.parentlbl.AutoSize = true;
            this.parentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentlbl.Location = new System.Drawing.Point(36, 217);
            this.parentlbl.Name = "parentlbl";
            this.parentlbl.Size = new System.Drawing.Size(120, 16);
            this.parentlbl.TabIndex = 18;
            this.parentlbl.Text = "Parent Category";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(36, 166);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(116, 16);
            this.namelbl.TabIndex = 17;
            this.namelbl.Text = "Category Name";
            // 
            // codelbl
            // 
            this.codelbl.AutoSize = true;
            this.codelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codelbl.Location = new System.Drawing.Point(36, 111);
            this.codelbl.Name = "codelbl";
            this.codelbl.Size = new System.Drawing.Size(112, 16);
            this.codelbl.TabIndex = 16;
            this.codelbl.Text = "Category Code";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Crimson;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deletebtn.Location = new System.Drawing.Point(592, 275);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(96, 33);
            this.deletebtn.TabIndex = 15;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.updatebtn.Location = new System.Drawing.Point(490, 276);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(96, 33);
            this.updatebtn.TabIndex = 14;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.savebtn.Location = new System.Drawing.Point(387, 276);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(96, 33);
            this.savebtn.TabIndex = 13;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // btncategorylist
            // 
            this.btncategorylist.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btncategorylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncategorylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategorylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorylist.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btncategorylist.Location = new System.Drawing.Point(155, 35);
            this.btncategorylist.Name = "btncategorylist";
            this.btncategorylist.Size = new System.Drawing.Size(118, 33);
            this.btncategorylist.TabIndex = 12;
            this.btncategorylist.Text = "Category List";
            this.btncategorylist.UseVisualStyleBackColor = false;
            this.btncategorylist.Click += new System.EventHandler(this.btncategorylist_Click);
            // 
            // btnnewcat
            // 
            this.btnnewcat.BackColor = System.Drawing.Color.MediumBlue;
            this.btnnewcat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnnewcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewcat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnnewcat.Location = new System.Drawing.Point(39, 35);
            this.btnnewcat.Name = "btnnewcat";
            this.btnnewcat.Size = new System.Drawing.Size(107, 33);
            this.btnnewcat.TabIndex = 11;
            this.btnnewcat.Text = "New";
            this.btnnewcat.UseVisualStyleBackColor = false;
            this.btnnewcat.Click += new System.EventHandler(this.btnnewcat_Click);
            // 
            // comboparent
            // 
            this.comboparent.FormattingEnabled = true;
            this.comboparent.Location = new System.Drawing.Point(212, 217);
            this.comboparent.Name = "comboparent";
            this.comboparent.Size = new System.Drawing.Size(286, 21);
            this.comboparent.TabIndex = 21;
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 355);
            this.Controls.Add(this.comboparent);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcatcode);
            this.Controls.Add(this.parentlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.codelbl);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.btncategorylist);
            this.Controls.Add(this.btnnewcat);
            this.Name = "FormCategory";
            this.Text = "FormCategory";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcatcode;
        private System.Windows.Forms.Label parentlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label codelbl;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button btncategorylist;
        private System.Windows.Forms.Button btnnewcat;
        private System.Windows.Forms.ComboBox comboparent;
    }
}