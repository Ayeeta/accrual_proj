namespace QuestionOne
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbtnUnderline = new System.Windows.Forms.RadioButton();
            this.cBoxBold = new System.Windows.Forms.CheckBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnItalic = new System.Windows.Forms.RadioButton();
            this.cBoxChangeColor = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDisplayMessage = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbtnUnderline
            // 
            this.rbtnUnderline.AutoSize = true;
            this.rbtnUnderline.Location = new System.Drawing.Point(6, 19);
            this.rbtnUnderline.Name = "rbtnUnderline";
            this.rbtnUnderline.Size = new System.Drawing.Size(70, 17);
            this.rbtnUnderline.TabIndex = 2;
            this.rbtnUnderline.TabStop = true;
            this.rbtnUnderline.Text = "Underline";
            this.rbtnUnderline.UseVisualStyleBackColor = true;
            // 
            // cBoxBold
            // 
            this.cBoxBold.AutoSize = true;
            this.cBoxBold.Location = new System.Drawing.Point(108, 216);
            this.cBoxBold.Name = "cBoxBold";
            this.cBoxBold.Size = new System.Drawing.Size(71, 17);
            this.cBoxBold.TabIndex = 3;
            this.cBoxBold.Text = "Text Bold";
            this.cBoxBold.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(108, 277);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(108, 68);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(276, 83);
            this.txtMessage.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Message:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnItalic);
            this.groupBox1.Controls.Add(this.rbtnUnderline);
            this.groupBox1.Location = new System.Drawing.Point(108, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 53);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose one ...";
            // 
            // rbtnItalic
            // 
            this.rbtnItalic.AutoSize = true;
            this.rbtnItalic.Location = new System.Drawing.Point(185, 19);
            this.rbtnItalic.Name = "rbtnItalic";
            this.rbtnItalic.Size = new System.Drawing.Size(47, 17);
            this.rbtnItalic.TabIndex = 3;
            this.rbtnItalic.TabStop = true;
            this.rbtnItalic.Text = "Italic";
            this.rbtnItalic.UseVisualStyleBackColor = true;
            // 
            // cBoxChangeColor
            // 
            this.cBoxChangeColor.AutoSize = true;
            this.cBoxChangeColor.Location = new System.Drawing.Point(293, 216);
            this.cBoxChangeColor.Name = "cBoxChangeColor";
            this.cBoxChangeColor.Size = new System.Drawing.Size(90, 17);
            this.cBoxChangeColor.TabIndex = 8;
            this.cBoxChangeColor.Text = "Change Color";
            this.cBoxChangeColor.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(293, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDisplayMessage
            // 
            this.lblDisplayMessage.AutoSize = true;
            this.lblDisplayMessage.Location = new System.Drawing.Point(102, 323);
            this.lblDisplayMessage.Name = "lblDisplayMessage";
            this.lblDisplayMessage.Size = new System.Drawing.Size(10, 13);
            this.lblDisplayMessage.TabIndex = 10;
            this.lblDisplayMessage.Text = ".";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(202, 277);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 453);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDisplayMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cBoxChangeColor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.cBoxBold);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Question One";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbtnUnderline;
        private System.Windows.Forms.CheckBox cBoxBold;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnItalic;
        private System.Windows.Forms.CheckBox cBoxChangeColor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDisplayMessage;
        private System.Windows.Forms.Button btnClear;
    }
}

