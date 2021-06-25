// <copyright file="Form_AboutUs.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_AboutUs class.
    /// Contains components for Form_AboutUs class.
    /// </summary>
    public partial class Form_AboutUs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Panel panelBody.
        /// </summary>
        private System.Windows.Forms.Panel panelBody;

        /// <summary>
        /// Label labelInformationContent.
        /// </summary>
        private System.Windows.Forms.Label labelInformationContent;

        /// <summary>
        /// Label labelNotes.
        /// </summary>
        private System.Windows.Forms.Label labelNotes;

        /// <summary>
        /// LinkLabel linkLabelSource.
        /// </summary>
        private System.Windows.Forms.LinkLabel linkLabelSource;

        /// <summary>
        /// Label labelVideoInformation.
        /// </summary>
        private System.Windows.Forms.Label labelVideoInformation;

        /// <summary>
        /// PictureBox pictureBox.
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBox;

        /// <summary>
        /// Button button_Close.
        /// </summary>
        private System.Windows.Forms.Button buttonClose;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.buttonClose = new System.Windows.Forms.Button();
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
            this.panelBody.Controls.Add(this.buttonClose);
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
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(330, 450);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 25);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
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
    }
}
