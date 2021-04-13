
namespace CollegeManagementSystem
{
    partial class Form_AboutUs
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.labelInformationContent = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.linkLabelSource = new System.Windows.Forms.LinkLabel();
            this.labelVideoInformation = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.SystemColors.Control;
            this.panelBody.Controls.Add(this.button_Close);
            this.panelBody.Controls.Add(this.labelInformationContent);
            this.panelBody.Controls.Add(this.labelNotes);
            this.panelBody.Controls.Add(this.linkLabelSource);
            this.panelBody.Controls.Add(this.labelVideoInformation);
            this.panelBody.Controls.Add(this.pictureBox);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(740, 500);
            this.panelBody.TabIndex = 0;
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Close.Location = new System.Drawing.Point(330, 450);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(80, 25);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // labelInformationContent
            // 
            this.labelInformationContent.AutoSize = true;
            this.labelInformationContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformationContent.Location = new System.Drawing.Point(12, 350);
            this.labelInformationContent.MaximumSize = new System.Drawing.Size(716, 80);
            this.labelInformationContent.Name = "labelInformationContent";
            this.labelInformationContent.Size = new System.Drawing.Size(0, 16);
            this.labelInformationContent.TabIndex = 4;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotes.ForeColor = System.Drawing.Color.Firebrick;
            this.labelNotes.Location = new System.Drawing.Point(12, 315);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(193, 24);
            this.labelNotes.TabIndex = 3;
            this.labelNotes.Text = "Notes and information";
            // 
            // linkLabelSource
            // 
            this.linkLabelSource.AutoSize = true;
            this.linkLabelSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelSource.Location = new System.Drawing.Point(12, 271);
            this.linkLabelSource.Name = "linkLabelSource";
            this.linkLabelSource.Size = new System.Drawing.Size(591, 20);
            this.linkLabelSource.TabIndex = 2;
            this.linkLabelSource.TabStop = true;
            this.linkLabelSource.Text = "https://www.youtube.com/watch?v=rOlIWTcuJaA&t=16182s&ab_channel=BTechDays";
            // 
            // labelVideoInformation
            // 
            this.labelVideoInformation.AutoSize = true;
            this.labelVideoInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVideoInformation.ForeColor = System.Drawing.Color.Firebrick;
            this.labelVideoInformation.Location = new System.Drawing.Point(12, 247);
            this.labelVideoInformation.Name = "labelVideoInformation";
            this.labelVideoInformation.Size = new System.Drawing.Size(245, 24);
            this.labelVideoInformation.TabIndex = 1;
            this.labelVideoInformation.Text = "Video Source of the Project:";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::CollegeManagementSystem.Properties.Resources.about_us;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(716, 220);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Form_AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 500);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_AboutUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Us";
            this.Load += new System.EventHandler(this.Form_AboutUs_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label labelInformationContent;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.LinkLabel linkLabelSource;
        private System.Windows.Forms.Label labelVideoInformation;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_Close;
    }
}