﻿namespace MyDictionary
{
    partial class AddItemForm
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
            this.lblAddItem = new System.Windows.Forms.Label();
            this.textBoxAddItem = new System.Windows.Forms.TextBox();
            this.lblAddTranslation = new System.Windows.Forms.Label();
            this.textBoxAddTranslation = new System.Windows.Forms.TextBox();
            this.buttonSaveInput = new System.Windows.Forms.Button();
            this.lblInvalidItemInput = new System.Windows.Forms.Label();
            this.lblInvalidTranslationInput = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddItem
            // 
            this.lblAddItem.Location = new System.Drawing.Point(30, 30);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(117, 15);
            this.lblAddItem.TabIndex = 0;
            this.lblAddItem.Text = "Enter new item on latin";
            // 
            // textBoxAddItem
            // 
            this.textBoxAddItem.Location = new System.Drawing.Point(30, 50);
            this.textBoxAddItem.Name = "textBoxAddItem";
            this.textBoxAddItem.Size = new System.Drawing.Size(180, 20);
            this.textBoxAddItem.TabIndex = 1;
            this.textBoxAddItem.TextChanged += new System.EventHandler(this.TextBoxAddItem_TextChanged);
            // 
            // lblAddTranslation
            // 
            this.lblAddTranslation.Location = new System.Drawing.Point(30, 90);
            this.lblAddTranslation.Name = "lblAddTranslation";
            this.lblAddTranslation.Size = new System.Drawing.Size(251, 15);
            this.lblAddTranslation.TabIndex = 2;
            this.lblAddTranslation.Text = "Add translations separated by comma(,) or space";
            // 
            // textBoxAddTranslation
            // 
            this.textBoxAddTranslation.Location = new System.Drawing.Point(30, 110);
            this.textBoxAddTranslation.Name = "textBoxAddTranslation";
            this.textBoxAddTranslation.Size = new System.Drawing.Size(251, 20);
            this.textBoxAddTranslation.TabIndex = 3;
            this.textBoxAddTranslation.TextChanged += new System.EventHandler(this.TextBoxAddTranslation_TextChanged);
            // 
            // buttonSaveInput
            // 
            this.buttonSaveInput.Location = new System.Drawing.Point(30, 150);
            this.buttonSaveInput.Name = "buttonSaveInput";
            this.buttonSaveInput.Size = new System.Drawing.Size(80, 25);
            this.buttonSaveInput.TabIndex = 4;
            this.buttonSaveInput.Text = "Save";
            this.buttonSaveInput.UseVisualStyleBackColor = true;
            this.buttonSaveInput.Click += new System.EventHandler(this.ButtonSaveInput_Click);
            // 
            // labelInvalidItemInput
            // 
            this.lblInvalidItemInput.AutoSize = true;
            this.lblInvalidItemInput.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidItemInput.Location = new System.Drawing.Point(30, 73);
            this.lblInvalidItemInput.Name = "labelInvalidItemInput";
            this.lblInvalidItemInput.Size = new System.Drawing.Size(0, 13);
            this.lblInvalidItemInput.TabIndex = 5;
            // 
            // labelInvalidTranslationInput
            // 
            this.lblInvalidTranslationInput.AutoSize = true;
            this.lblInvalidTranslationInput.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidTranslationInput.Location = new System.Drawing.Point(30, 133);
            this.lblInvalidTranslationInput.Name = "labelInvalidTranslationInput";
            this.lblInvalidTranslationInput.Size = new System.Drawing.Size(0, 13);
            this.lblInvalidTranslationInput.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(308, 201);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblInvalidTranslationInput);
            this.Controls.Add(this.lblInvalidItemInput);
            this.Controls.Add(this.buttonSaveInput);
            this.Controls.Add(this.textBoxAddTranslation);
            this.Controls.Add(this.lblAddTranslation);
            this.Controls.Add(this.textBoxAddItem);
            this.Controls.Add(this.lblAddItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.TextBox textBoxAddItem;
        private System.Windows.Forms.Label lblAddTranslation;
        private System.Windows.Forms.TextBox textBoxAddTranslation;
        private System.Windows.Forms.Button buttonSaveInput;
        private System.Windows.Forms.Label lblInvalidItemInput;
        private System.Windows.Forms.Label lblInvalidTranslationInput;
        private System.Windows.Forms.Button btnCancel;
    }
}