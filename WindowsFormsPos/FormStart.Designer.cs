namespace WindowsFormsPos
{
    partial class FormStart
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnitemfrm = new System.Windows.Forms.Button();
            this.btncustomerfrm = new System.Windows.Forms.Button();
            this.btncategoryfrm = new System.Windows.Forms.Button();
            this.btnsalefrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(237, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "POS All ITEM";
            // 
            // btnitemfrm
            // 
            this.btnitemfrm.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnitemfrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnitemfrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitemfrm.ForeColor = System.Drawing.Color.White;
            this.btnitemfrm.Location = new System.Drawing.Point(334, 108);
            this.btnitemfrm.Name = "btnitemfrm";
            this.btnitemfrm.Size = new System.Drawing.Size(119, 37);
            this.btnitemfrm.TabIndex = 1;
            this.btnitemfrm.Text = "Item";
            this.btnitemfrm.UseVisualStyleBackColor = false;
            this.btnitemfrm.Click += new System.EventHandler(this.btnitemfrm_Click);
            // 
            // btncustomerfrm
            // 
            this.btncustomerfrm.BackColor = System.Drawing.Color.Blue;
            this.btncustomerfrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomerfrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomerfrm.ForeColor = System.Drawing.Color.White;
            this.btncustomerfrm.Location = new System.Drawing.Point(175, 177);
            this.btncustomerfrm.Name = "btncustomerfrm";
            this.btncustomerfrm.Size = new System.Drawing.Size(124, 37);
            this.btncustomerfrm.TabIndex = 2;
            this.btncustomerfrm.Text = "Customer";
            this.btncustomerfrm.UseVisualStyleBackColor = false;
            this.btncustomerfrm.Click += new System.EventHandler(this.btncustomerfrm_Click);
            // 
            // btncategoryfrm
            // 
            this.btncategoryfrm.BackColor = System.Drawing.Color.OrangeRed;
            this.btncategoryfrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategoryfrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategoryfrm.ForeColor = System.Drawing.Color.White;
            this.btncategoryfrm.Location = new System.Drawing.Point(175, 108);
            this.btncategoryfrm.Name = "btncategoryfrm";
            this.btncategoryfrm.Size = new System.Drawing.Size(124, 37);
            this.btncategoryfrm.TabIndex = 3;
            this.btncategoryfrm.Text = "Category";
            this.btncategoryfrm.UseVisualStyleBackColor = false;
            this.btncategoryfrm.Click += new System.EventHandler(this.btncategoryfrm_Click);
            // 
            // btnsalefrm
            // 
            this.btnsalefrm.BackColor = System.Drawing.Color.Green;
            this.btnsalefrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalefrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalefrm.ForeColor = System.Drawing.Color.White;
            this.btnsalefrm.Location = new System.Drawing.Point(334, 177);
            this.btnsalefrm.Name = "btnsalefrm";
            this.btnsalefrm.Size = new System.Drawing.Size(124, 37);
            this.btnsalefrm.TabIndex = 4;
            this.btnsalefrm.Text = "Sale";
            this.btnsalefrm.UseVisualStyleBackColor = false;
            this.btnsalefrm.Click += new System.EventHandler(this.btnsalefrm_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 321);
            this.Controls.Add(this.btnsalefrm);
            this.Controls.Add(this.btncategoryfrm);
            this.Controls.Add(this.btncustomerfrm);
            this.Controls.Add(this.btnitemfrm);
            this.Controls.Add(this.label1);
            this.Name = "FormStart";
            this.Text = "FormStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnitemfrm;
        private System.Windows.Forms.Button btncustomerfrm;
        private System.Windows.Forms.Button btncategoryfrm;
        private System.Windows.Forms.Button btnsalefrm;
    }
}