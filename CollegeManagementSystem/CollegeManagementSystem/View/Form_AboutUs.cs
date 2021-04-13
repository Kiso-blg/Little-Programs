namespace CollegeManagementSystem
{
    using System;
    using System.Windows.Forms;

    public partial class Form_AboutUs : Form
    {
        const string InformationContent = "This project is quite different from the original project from the video. The are a lot of changes. " +
            "I added much more functionalities and more forms. I changed the functionalities of some forms according the my veiw point of view. " +
            "The syntax was changed accoring to my point of view too, making the code much more readable. " +
            "The database was much more improved too. I created more tables and added some new ones. I put stored procedures for all functionalites.";

        public Form_AboutUs()
        {
            InitializeComponent();
        }

        // Form Load
        private void Form_AboutUs_Load(object sender, EventArgs e)
        {
            this.labelInformationContent.Text = InformationContent;
        }

        // Close the Form
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Override OnShown Event
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.Capture = true;
        }

        // Override OnMouseCaptureChanged Event
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
    }
}