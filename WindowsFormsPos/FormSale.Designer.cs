namespace WindowsFormsPos
{
    partial class FormSale
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
            this.txtcatcode = new System.Windows.Forms.TextBox();
            this.lblcustomer = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblinv = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.btnsalelist = new System.Windows.Forms.Button();
            this.btnnewcat = new System.Windows.Forms.Button();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btncust = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcatcode
            // 
            this.txtcatcode.Location = new System.Drawing.Point(305, 90);
            this.txtcatcode.Multiline = true;
            this.txtcatcode.Name = "txtcatcode";
            this.txtcatcode.ReadOnly = true;
            this.txtcatcode.Size = new System.Drawing.Size(256, 30);
            this.txtcatcode.TabIndex = 30;
            this.txtcatcode.Text = "Auto Generate";
            // 
            // lblcustomer
            // 
            this.lblcustomer.AutoSize = true;
            this.lblcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomer.Location = new System.Drawing.Point(157, 181);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(118, 16);
            this.lblcustomer.TabIndex = 29;
            this.lblcustomer.Text = "Customer Name";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(157, 138);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(41, 16);
            this.lbldate.TabIndex = 28;
            this.lbldate.Text = "Date";
            // 
            // lblinv
            // 
            this.lblinv.AutoSize = true;
            this.lblinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinv.Location = new System.Drawing.Point(157, 94);
            this.lblinv.Name = "lblinv";
            this.lblinv.Size = new System.Drawing.Size(116, 16);
            this.lblinv.TabIndex = 27;
            this.lblinv.Text = "Invoice Number";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Crimson;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deletebtn.Location = new System.Drawing.Point(652, 494);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(96, 33);
            this.deletebtn.TabIndex = 26;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.updatebtn.Location = new System.Drawing.Point(550, 495);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(96, 33);
            this.updatebtn.TabIndex = 25;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.savebtn.Location = new System.Drawing.Point(447, 495);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(96, 33);
            this.savebtn.TabIndex = 24;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // btnsalelist
            // 
            this.btnsalelist.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsalelist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsalelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalelist.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnsalelist.Location = new System.Drawing.Point(148, 27);
            this.btnsalelist.Name = "btnsalelist";
            this.btnsalelist.Size = new System.Drawing.Size(118, 33);
            this.btnsalelist.TabIndex = 23;
            this.btnsalelist.Text = "Sale List";
            this.btnsalelist.UseVisualStyleBackColor = false;
            this.btnsalelist.Click += new System.EventHandler(this.btnsalelist_Click);
            // 
            // btnnewcat
            // 
            this.btnnewcat.BackColor = System.Drawing.Color.MediumBlue;
            this.btnnewcat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnnewcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewcat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnnewcat.Location = new System.Drawing.Point(32, 27);
            this.btnnewcat.Name = "btnnewcat";
            this.btnnewcat.Size = new System.Drawing.Size(107, 33);
            this.btnnewcat.TabIndex = 22;
            this.btnnewcat.Text = "New";
            this.btnnewcat.UseVisualStyleBackColor = false;
            // 
            // txtcustname
            // 
            this.txtcustname.Location = new System.Drawing.Point(305, 176);
            this.txtcustname.Multiline = true;
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(238, 30);
            this.txtcustname.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.itmid,
            this.itemcode,
            this.icon,
            this.itemname,
            this.price,
            this.qty,
            this.disper,
            this.disamt,
            this.totalamt});
            this.dataGridView1.Location = new System.Drawing.Point(41, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 205);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // itmid
            // 
            this.itmid.HeaderText = "ItmID";
            this.itmid.Name = "itmid";
            this.itmid.Visible = false;
            // 
            // itemcode
            // 
            this.itemcode.HeaderText = "ItemCode";
            this.itemcode.Name = "itemcode";
            this.itemcode.ReadOnly = true;
            // 
            // icon
            // 
            this.icon.HeaderText = "Icon";
            this.icon.Image = global::WindowsFormsPos.Properties.Resources.checkbox_unchecked_4;
            this.icon.Name = "icon";
            this.icon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.icon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // itemname
            // 
            this.itemname.HeaderText = "ItemName";
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // disper
            // 
            this.disper.HeaderText = "DiscountPercent";
            this.disper.Name = "disper";
            // 
            // disamt
            // 
            this.disamt.HeaderText = "DiscountAmount";
            this.disamt.Name = "disamt";
            // 
            // totalamt
            // 
            this.totalamt.HeaderText = "Total Amount";
            this.totalamt.Name = "totalamt";
            this.totalamt.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/mm/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(305, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // txtamt
            // 
            this.txtamt.Location = new System.Drawing.Point(550, 450);
            this.txtamt.Multiline = true;
            this.txtamt.Name = "txtamt";
            this.txtamt.ReadOnly = true;
            this.txtamt.Size = new System.Drawing.Size(197, 30);
            this.txtamt.TabIndex = 39;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(413, 451);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(99, 16);
            this.lbltotal.TabIndex = 38;
            this.lbltotal.Text = "Total Amount";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Icon";
            this.dataGridViewImageColumn1.Image = global::WindowsFormsPos.Properties.Resources.checkbox_unchecked_4;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btncust
            // 
            this.btncust.Image = global::WindowsFormsPos.Properties.Resources.radio_unchecked;
            this.btncust.Location = new System.Drawing.Point(543, 176);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(25, 30);
            this.btncust.TabIndex = 40;
            this.btncust.UseVisualStyleBackColor = true;
            this.btncust.Click += new System.EventHandler(this.btncust_Click);
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 542);
            this.Controls.Add(this.btncust);
            this.Controls.Add(this.txtamt);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtcustname);
            this.Controls.Add(this.txtcatcode);
            this.Controls.Add(this.lblcustomer);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblinv);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.btnsalelist);
            this.Controls.Add(this.btnnewcat);
            this.Name = "FormSale";
            this.Text = "FormSale";
            this.Load += new System.EventHandler(this.FormSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcatcode;
        private System.Windows.Forms.Label lblcustomer;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblinv;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button btnsalelist;
        private System.Windows.Forms.Button btnnewcat;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btncust;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcode;
        private System.Windows.Forms.DataGridViewImageColumn icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn disper;
        private System.Windows.Forms.DataGridViewTextBoxColumn disamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamt;
    }
}