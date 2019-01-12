namespace DownloadValutCourses_Form
{
    partial class formValutCourses
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
            this.components = new System.ComponentModel.Container();
            this.labelInformation = new System.Windows.Forms.Label();
            this.buttonDownloadCourses = new System.Windows.Forms.Button();
            this.labelProccessing = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(12, 9);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(226, 17);
            this.labelInformation.TabIndex = 1;
            this.labelInformation.Text = "Download valut courses from BNB.";
            // 
            // buttonDownloadCourses
            // 
            this.buttonDownloadCourses.Location = new System.Drawing.Point(244, 6);
            this.buttonDownloadCourses.Name = "buttonDownloadCourses";
            this.buttonDownloadCourses.Size = new System.Drawing.Size(75, 23);
            this.buttonDownloadCourses.TabIndex = 2;
            this.buttonDownloadCourses.Text = "Download";
            this.buttonDownloadCourses.UseVisualStyleBackColor = true;
            this.buttonDownloadCourses.Click += new System.EventHandler(this.buttonDownloadCourses_Click);
            // 
            // labelProccessing
            // 
            this.labelProccessing.AutoSize = true;
            this.labelProccessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProccessing.Location = new System.Drawing.Point(12, 32);
            this.labelProccessing.Name = "labelProccessing";
            this.labelProccessing.Size = new System.Drawing.Size(109, 17);
            this.labelProccessing.TabIndex = 0;
            this.labelProccessing.Text = "Proccessing......";
            this.labelProccessing.Visible = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // formValutCourses
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(792, 391);
            this.Controls.Add(this.labelProccessing);
            this.Controls.Add(this.buttonDownloadCourses);
            this.Controls.Add(this.labelInformation);
            this.Name = "formValutCourses";
            this.Text = "Download Valut Courses";
            this.Load += new System.EventHandler(this.formValutCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button buttonDownloadCourses;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Label labelProccessing;
    }
}

