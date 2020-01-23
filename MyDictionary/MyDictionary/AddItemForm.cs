using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyDictionary
{
    public partial class AddItemForm : Form
    {
        public AddItemForm(MyDictionaryForm myDictionaryForm)
        {
            InitializeComponent();
            this.MyDictionaryForm = myDictionaryForm;
            this.IsValidInput = false;
        }

        public MyDictionaryForm MyDictionaryForm { get; set; }

        public string Item { get; set; }

        public string Translation { get; set; }

        public bool IsValidInput { get; set; }

        public bool CanProceed { get; set; }

        private void ButtonSaveInput_Click(object sender, EventArgs e)
        {                        
            bool isValidItem = IsValidItem();
            bool translation = IsTranslationCorrect();                                                
            bool isCyrillic = CheckIsCyrillic();

            if (isValidItem && translation && isCyrillic)
            {
                this.Item = this.textBoxAddItem.Text;
                this.Translation = this.textBoxAddTranslation.Text;
                this.IsValidInput = true;
                this.CanProceed = true;
                this.Close();
            }
        }

        private bool IsTranslationCorrect()
        {
            if (this.textBoxAddTranslation.Text != string.Empty)
            {
                try
                {
                    List<string> translations = this.textBoxAddTranslation
                        .Text
                        .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)                        
                        .ToList();
                    return true;
                }
                catch (Exception)
                {
                    this.lblInvalidTranslationInput.Text = "Invalid input!";
                    return false;
                }
            }
            else
            {
                this.lblInvalidTranslationInput.Text = "Invalid input!";
                return false;
            }
        }

        private bool IsValidItem()
        {
            if (this.textBoxAddItem.Text != string.Empty)
            {
                bool isLatin = CheckIsLatin();

                if (isLatin)
                {
                    this.lblInvalidItemInput.Text = string.Empty;                    
                    return true;
                }
                else
                {
                    this.lblInvalidItemInput.Text = "Invalid input!";
                    return false;
                }
            }
            else
            {
                this.lblInvalidItemInput.Text = "Invalid input!";
                return false;
            }
        }

        private bool CheckIsLatin()
        {
            string latinPattern = "[^A-Za-z]";
            Match match = Regex.Match(this.textBoxAddItem.Text, latinPattern, RegexOptions.Singleline);

            if (match.Success)
            {
                this.lblInvalidItemInput.Text = "Invalid input!";
                return false;
            }
            else
            {
                this.lblInvalidItemInput.Text = string.Empty;
                return true;
            }
        }

        private bool CheckIsCyrillic()
        {
            string cyrillicPattern = "[^А-Яа-я, ]";

            Match match = Regex.Match(this.textBoxAddTranslation.Text, cyrillicPattern, RegexOptions.Singleline);

            if (match.Success)
            {
                this.lblInvalidTranslationInput.Text = "Invalid input!";
                return false;
            }

            return true;
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Item))
            {
                this.textBoxAddItem.Text = this.Item;
                this.textBoxAddTranslation.Text = string.Join(", ", this.Translation);
            }

            this.CanProceed = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.buttonSaveInput.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.CanProceed = false;
            this.Close();
        }

        private void TextBoxAddItem_TextChanged(object sender, EventArgs e)
        {
            if (IsValidItem())
            {
                this.lblInvalidItemInput.Text = string.Empty;
            }
        }

        private void TextBoxAddTranslation_TextChanged(object sender, EventArgs e)
        {
            if (IsTranslationCorrect() && CheckIsCyrillic())
            {
                this.lblInvalidTranslationInput.Text = string.Empty;
            }
        }
    }
}