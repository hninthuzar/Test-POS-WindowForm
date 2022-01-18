namespace WindowsFormsPos
{
    partial class FormItem
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
            this.btnItemlist = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.txtitmcode = new System.Windows.Forms.TextBox();
            this.lblitmcode = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtunit = new System.Windows.Forms.TextBox();
            this.lblunit = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.lblremark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnItemlist
            // 
            this.btnItemlist.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnItemlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnItemlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemlist.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnItemlist.Location = new System.Drawing.Point(149, 21);
            this.btnItemlist.Name = "btnItemlist";
            this.btnItemlist.Size = new System.Drawing.Size(118, 33);
            this.btnItemlist.TabIndex = 3;
            this.btnItemlist.Text = "Item List";
            this.btnItemlist.UseVisualStyleBackColor = false;
            this.btnItemlist.Click += new System.EventHandler(this.btnItemlist_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.MediumBlue;
            this.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnnew.Location = new System.Drawing.Point(40, 21);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(96, 33);
            this.btnnew.TabIndex = 2;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // txtitmcode
            // 
            this.txtitmcode.Location = new System.Drawing.Point(40, 116);
            this.txtitmcode.Multiline = true;
            this.txtitmcode.Name = "txtitmcode";
            this.txtitmcode.Size = new System.Drawing.Size(364, 34);
            this.txtitmcode.TabIndex = 10;
            // 
            // lblitmcode
            // 
            this.lblitmcode.AutoSize = true;
            this.lblitmcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitmcode.Location = new System.Drawing.Point(37, 84);
            this.lblitmcode.Name = "lblitmcode";
            this.lblitmcode.Size = new System.Drawing.Size(78, 16);
            this.lblitmcode.TabIndex = 9;
            this.lblitmcode.Text = "Item Code";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Crimson;
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btndelete.Location = new System.Drawing.Point(699, 358);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(96, 33);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnupdate.Location = new System.Drawing.Point(597, 359);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(96, 33);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnsave.Location = new System.Drawing.Point(494, 359);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(96, 33);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(442, 116);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(364, 34);
            this.txtname.TabIndex = 15;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(439, 84);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(82, 16);
            this.lblname.TabIndex = 14;
            this.lblname.Text = "Item Name";
            // 
            // txtunit
            // 
            this.txtunit.Location = new System.Drawing.Point(40, 201);
            this.txtunit.Multiline = true;
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(364, 34);
            this.txtunit.TabIndex = 17;
            // 
            // lblunit
            // 
            this.lblunit.AutoSize = true;
            this.lblunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunit.Location = new System.Drawing.Point(37, 169);
            this.lblunit.Name = "lblunit";
            this.lblunit.Size = new System.Drawing.Size(35, 16);
            this.lblunit.TabIndex = 16;
            this.lblunit.Text = "Unit";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(439, 201);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(364, 34);
            this.txtprice.TabIndex = 19;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(436, 169);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(44, 16);
            this.lblprice.TabIndex = 18;
            this.lblprice.Text = "Price";
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(40, 290);
            this.txtremark.Multiline = true;
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(364, 34);
            this.txtremark.TabIndex = 21;
            // 
            // lblremark
            // 
            this.lblremark.AutoSize = true;
            this.lblremark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremark.Location = new System.Drawing.Point(37, 258);
            this.lblremark.Name = "lblremark";
            this.lblremark.Size = new System.Drawing.Size(62, 16);
            this.lblremark.TabIndex = 20;
            this.lblremark.Text = "Remark";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 420);
            this.Controls.Add(this.txtremark);
            this.Controls.Add(this.lblremark);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.txtunit);
            this.Controls.Add(this.lblunit);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtitmcode);
            this.Controls.Add(this.lblitmcode);
            this.Controls.Add(this.btnItemlist);
            this.Controls.Add(this.btnnew);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItemlist;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.TextBox txtitmcode;
        private System.Windows.Forms.Label lblitmcode;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtunit;
        private System.Windows.Forms.Label lblunit;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.Label lblremark;
    }
}