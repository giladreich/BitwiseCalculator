namespace BitwiseCalculator
{
    partial class MainWindow
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
            this.tbxExpression = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxHex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxAutoCalc = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxExpression
            // 
            this.tbxExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxExpression.Location = new System.Drawing.Point(12, 35);
            this.tbxExpression.Name = "tbxExpression";
            this.tbxExpression.Size = new System.Drawing.Size(371, 20);
            this.tbxExpression.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 135);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expression:";
            // 
            // tbxDec
            // 
            this.tbxDec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDec.Location = new System.Drawing.Point(66, 61);
            this.tbxDec.Name = "tbxDec";
            this.tbxDec.ReadOnly = true;
            this.tbxDec.Size = new System.Drawing.Size(315, 20);
            this.tbxDec.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Decimal :";
            // 
            // tbxHex
            // 
            this.tbxHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHex.Location = new System.Drawing.Point(66, 85);
            this.tbxHex.Name = "tbxHex";
            this.tbxHex.ReadOnly = true;
            this.tbxHex.Size = new System.Drawing.Size(315, 20);
            this.tbxHex.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hex :";
            // 
            // tbxBin
            // 
            this.tbxBin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBin.Location = new System.Drawing.Point(66, 109);
            this.tbxBin.Name = "tbxBin";
            this.tbxBin.ReadOnly = true;
            this.tbxBin.Size = new System.Drawing.Size(315, 20);
            this.tbxBin.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Binary :";
            // 
            // cbxAutoCalc
            // 
            this.cbxAutoCalc.AutoSize = true;
            this.cbxAutoCalc.Checked = true;
            this.cbxAutoCalc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoCalc.Location = new System.Drawing.Point(244, 12);
            this.cbxAutoCalc.Name = "cbxAutoCalc";
            this.cbxAutoCalc.Size = new System.Drawing.Size(135, 17);
            this.cbxAutoCalc.TabIndex = 5;
            this.cbxAutoCalc.Text = "Automatically Calculate";
            this.cbxAutoCalc.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 169);
            this.Controls.Add(this.cbxAutoCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxBin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxHex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbxExpression);
            this.Icon = global::BitwiseCalculator.Properties.Resources.app;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(800, 208);
            this.MinimumSize = new System.Drawing.Size(350, 208);
            this.Name = "MainWindow";
            this.Text = "Cute Little Bitwise Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainWindow_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxExpression;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxHex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxBin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxAutoCalc;
    }
}

