namespace tx_colored_tablerows
{
    partial class frmCellFormat
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTrueColor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCompareValue = new System.Windows.Forms.TextBox();
            this.pnlFalseColor = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectTrueColor = new System.Windows.Forms.Button();
            this.btnSelectFalseColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(360, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(279, 125);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "[Value]";
            // 
            // cbOperator
            // 
            this.cbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Location = new System.Drawing.Point(58, 43);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(146, 21);
            this.cbOperator.TabIndex = 3;
            this.cbOperator.SelectedIndexChanged += new System.EventHandler(this.cbOperator_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "True Color:";
            // 
            // pnlTrueColor
            // 
            this.pnlTrueColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrueColor.Location = new System.Drawing.Point(77, 79);
            this.pnlTrueColor.Name = "pnlTrueColor";
            this.pnlTrueColor.Size = new System.Drawing.Size(22, 23);
            this.pnlTrueColor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Field:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comparison:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Compare to:";
            // 
            // tbCompareValue
            // 
            this.tbCompareValue.Location = new System.Drawing.Point(224, 44);
            this.tbCompareValue.Name = "tbCompareValue";
            this.tbCompareValue.Size = new System.Drawing.Size(118, 20);
            this.tbCompareValue.TabIndex = 10;
            this.tbCompareValue.TextChanged += new System.EventHandler(this.tbCompareValue_TextChanged);
            // 
            // pnlFalseColor
            // 
            this.pnlFalseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFalseColor.Location = new System.Drawing.Point(224, 79);
            this.pnlFalseColor.Name = "pnlFalseColor";
            this.pnlFalseColor.Size = new System.Drawing.Size(22, 23);
            this.pnlFalseColor.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "False Color:";
            // 
            // btnSelectTrueColor
            // 
            this.btnSelectTrueColor.Location = new System.Drawing.Point(105, 79);
            this.btnSelectTrueColor.Name = "btnSelectTrueColor";
            this.btnSelectTrueColor.Size = new System.Drawing.Size(29, 23);
            this.btnSelectTrueColor.TabIndex = 13;
            this.btnSelectTrueColor.Text = "...";
            this.btnSelectTrueColor.UseVisualStyleBackColor = true;
            this.btnSelectTrueColor.Click += new System.EventHandler(this.btnTrueColor_Click);
            // 
            // btnSelectFalseColor
            // 
            this.btnSelectFalseColor.Location = new System.Drawing.Point(253, 79);
            this.btnSelectFalseColor.Name = "btnSelectFalseColor";
            this.btnSelectFalseColor.Size = new System.Drawing.Size(29, 23);
            this.btnSelectFalseColor.TabIndex = 14;
            this.btnSelectFalseColor.Text = "...";
            this.btnSelectFalseColor.UseVisualStyleBackColor = true;
            this.btnSelectFalseColor.Click += new System.EventHandler(this.btnFalseColor_Clickbutton2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 125);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmCellFormat
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(447, 160);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSelectFalseColor);
            this.Controls.Add(this.btnSelectTrueColor);
            this.Controls.Add(this.pnlFalseColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCompareValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlTrueColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCellFormat";
            this.ShowIcon = false;
            this.Text = "Conditional Cell Color";
            this.Load += new System.EventHandler(this.frmCellFormat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTrueColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCompareValue;
        private System.Windows.Forms.Panel pnlFalseColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectTrueColor;
        private System.Windows.Forms.Button btnSelectFalseColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnReset;
    }
}