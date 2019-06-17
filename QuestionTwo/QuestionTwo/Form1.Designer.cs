namespace QuestionTwo
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCost = new System.Windows.Forms.Button();
            this.btnTotalCost = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Tomatoes",
            "Onions",
            "Carrots"});
            this.listBox1.Location = new System.Drawing.Point(23, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 121);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(201, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "List Items";
            // 
            // btnCost
            // 
            this.btnCost.Location = new System.Drawing.Point(438, 12);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(119, 23);
            this.btnCost.TabIndex = 3;
            this.btnCost.Text = "Cost in UGX";
            this.btnCost.UseVisualStyleBackColor = true;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // btnTotalCost
            // 
            this.btnTotalCost.Location = new System.Drawing.Point(438, 107);
            this.btnTotalCost.Name = "btnTotalCost";
            this.btnTotalCost.Size = new System.Drawing.Size(119, 23);
            this.btnTotalCost.TabIndex = 4;
            this.btnTotalCost.Text = "Total Cost in UGX";
            this.btnTotalCost.UseVisualStyleBackColor = true;
            this.btnTotalCost.Click += new System.EventHandler(this.btnTotalCost_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(438, 74);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(83, 20);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(438, 48);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(13, 13);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "0";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(438, 143);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(13, 13);
            this.lblTotalCost.TabIndex = 7;
            this.lblTotalCost.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 182);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnTotalCost);
            this.Controls.Add(this.btnCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Question Two";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCost;
        private System.Windows.Forms.Button btnTotalCost;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

