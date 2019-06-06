namespace tx_colored_tablerows
{
    partial class frmMain
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
            this.textControl1 = new TXTextControl.TextControl();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSetConditions = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textControl1
            // 
            this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl1.Location = new System.Drawing.Point(0, 100);
            this.textControl1.Name = "textControl1";
            this.textControl1.Size = new System.Drawing.Size(958, 475);
            this.textControl1.TabIndex = 0;
            this.textControl1.Text = "textControl1";
            this.textControl1.UserNames = null;
            this.textControl1.InputPositionChanged += new System.EventHandler(this.textControl1_InputPositionChanged);
            // 
            // btnMerge
            // 
            this.btnMerge.Enabled = false;
            this.btnMerge.Location = new System.Drawing.Point(136, 12);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(118, 35);
            this.btnMerge.TabIndex = 1;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 35);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Template";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSetConditions
            // 
            this.btnSetConditions.Enabled = false;
            this.btnSetConditions.Location = new System.Drawing.Point(12, 62);
            this.btnSetConditions.Name = "btnSetConditions";
            this.btnSetConditions.Size = new System.Drawing.Size(166, 23);
            this.btnSetConditions.TabIndex = 3;
            this.btnSetConditions.Text = "Set Cell Color Conditions";
            this.btnSetConditions.UseVisualStyleBackColor = true;
            this.btnSetConditions.Click += new System.EventHandler(this.btnSetConditions_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnMerge);
            this.panel1.Controls.Add(this.btnSetConditions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 100);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 575);
            this.Controls.Add(this.textControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Conditional TableCell Colors";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TXTextControl.TextControl textControl1;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSetConditions;
        private System.Windows.Forms.Panel panel1;
    }
}

