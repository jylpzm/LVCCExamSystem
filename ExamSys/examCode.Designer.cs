namespace ExamSys
{
    partial class examCode
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
            this.codeProc = new MaterialSkin.Controls.MaterialRaisedButton();
            this.codeReg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeProc
            // 
            this.codeProc.Depth = 0;
            this.codeProc.Location = new System.Drawing.Point(145, 159);
            this.codeProc.MouseState = MaterialSkin.MouseState.HOVER;
            this.codeProc.Name = "codeProc";
            this.codeProc.Primary = true;
            this.codeProc.Size = new System.Drawing.Size(115, 46);
            this.codeProc.TabIndex = 8;
            this.codeProc.Text = "PROCEED";
            this.codeProc.UseVisualStyleBackColor = true;
            this.codeProc.Click += new System.EventHandler(this.codeProc_Click);
            // 
            // codeReg
            // 
            this.codeReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeReg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.codeReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.codeReg.HintForeColor = System.Drawing.Color.Empty;
            this.codeReg.HintText = "ENTER CODE HERE";
            this.codeReg.isPassword = false;
            this.codeReg.LineFocusedColor = System.Drawing.Color.Blue;
            this.codeReg.LineIdleColor = System.Drawing.Color.Gray;
            this.codeReg.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.codeReg.LineThickness = 3;
            this.codeReg.Location = new System.Drawing.Point(74, 111);
            this.codeReg.Margin = new System.Windows.Forms.Padding(4);
            this.codeReg.Name = "codeReg";
            this.codeReg.Size = new System.Drawing.Size(267, 33);
            this.codeReg.TabIndex = 7;
            this.codeReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(-6, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 87);
            this.panel1.TabIndex = 6;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(66, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(275, 37);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Enter Invitation Code";
            // 
            // examCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 231);
            this.Controls.Add(this.codeProc);
            this.Controls.Add(this.codeReg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "examCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton codeProc;
        private Bunifu.Framework.UI.BunifuMaterialTextbox codeReg;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}