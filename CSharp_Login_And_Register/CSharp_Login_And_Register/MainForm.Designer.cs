namespace CSharp_Login_And_Register
{
    partial class MainForm
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
            this.panel_Body = new System.Windows.Forms.Panel();
            this.Label_Close = new System.Windows.Forms.Label();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.labelMainForm = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.panel_Body.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel_Body.Controls.Add(this.labelReturn);
            this.panel_Body.Controls.Add(this.Label_Close);
            this.panel_Body.Controls.Add(this.panel_Header);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(800, 460);
            this.panel_Body.TabIndex = 2;
            // 
            // Label_Close
            // 
            this.Label_Close.AutoSize = true;
            this.Label_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Close.ForeColor = System.Drawing.Color.Gold;
            this.Label_Close.Location = new System.Drawing.Point(777, 2);
            this.Label_Close.Name = "Label_Close";
            this.Label_Close.Size = new System.Drawing.Size(21, 22);
            this.Label_Close.TabIndex = 10;
            this.Label_Close.Text = "X";
            this.Label_Close.Click += new System.EventHandler(this.Label_Close_Click);
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel_Header.Controls.Add(this.labelMainForm);
            this.panel_Header.Location = new System.Drawing.Point(0, 190);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(800, 80);
            this.panel_Header.TabIndex = 0;
            // 
            // labelMainForm
            // 
            this.labelMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMainForm.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainForm.Location = new System.Drawing.Point(0, 0);
            this.labelMainForm.Name = "labelMainForm";
            this.labelMainForm.Size = new System.Drawing.Size(800, 80);
            this.labelMainForm.TabIndex = 0;
            this.labelMainForm.Text = "MAIN FORM";
            this.labelMainForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainForm.UseCompatibleTextRendering = true;
            this.labelMainForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelMainForm_MouseMove);
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReturn.ForeColor = System.Drawing.Color.White;
            this.labelReturn.Location = new System.Drawing.Point(350, 390);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(99, 25);
            this.labelReturn.TabIndex = 11;
            this.labelReturn.Text = "RETURN";
            this.labelReturn.Click += new System.EventHandler(this.LabelReturn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            this.panel_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Label labelMainForm;
        private System.Windows.Forms.Label labelReturn;
    }
}