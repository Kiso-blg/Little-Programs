// <copyright file="Form_AboutUs.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_AboutUs class.
    /// Contains all controllers for Form_AboutUs class.
    /// </summary>
    public partial class Form_AboutUs : Form
    {
        /// <summary>
        /// Contains information about the project.
        /// </summary>
        private const string InformationContent = "This project is quite different from the original project from the video. The are a lot of changes. " +
            "I added much more functionalities and more forms. I changed the functionalities of some forms according the my veiw point of view. " +
            "The syntax was changed accoring to my point of view too, making the code much more readable. " +
            "The database was much more improved too. I created more tables and added some new ones. I put stored procedures for all functionalites.";

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_AboutUs" /> class.
        /// </summary>
        public Form_AboutUs()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Override OnShown Event.
        /// </summary>
        /// <param name="e">Contains event arguments.</param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.Capture = true;
        }

        /// <summary>
        /// Override OnMouseCaptureChanged Event.
        /// </summary>
        /// <param name="e">Contains event arguments.</param>
        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            if (!this.Capture)
            {
                if (!this.RectangleToScreen(this.DisplayRectangle).Contains(Cursor.Position))
                {
                    this.Close();
                }
                else
                {
                    this.Capture = true;
                }
            }

            base.OnMouseCaptureChanged(e);
        }

        /// <summary>
        /// Load Form_AboutUs form.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void Form_AboutUs_Load(object sender, EventArgs e)
        {
            this.labelInformationContent.Text = InformationContent;
        }

        /// <summary>
        ///  Close the Form_AboutUs form.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
