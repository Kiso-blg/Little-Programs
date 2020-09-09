namespace MyDictionary
{
    partial class MyDictionaryForm
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
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.markAsWrittenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.listBoxDictionary = new System.Windows.Forms.ListBox();
            this.lblNonWrittenWordsWarnin = new System.Windows.Forms.Label();
            this.lblResultSign = new System.Windows.Forms.Label();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.lblIsWritten = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markAsWrittenToolStripMenuItem,
            this.editItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(156, 70);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Opening);
            // 
            // markAsWrittenToolStripMenuItem
            // 
            this.markAsWrittenToolStripMenuItem.Name = "markAsWrittenToolStripMenuItem";
            this.markAsWrittenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.markAsWrittenToolStripMenuItem.Text = "Mark as written";
            this.markAsWrittenToolStripMenuItem.Click += new System.EventHandler(this.MarkAsWrittenToolStripMenuItem_Click);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editItemToolStripMenuItem.Text = "Edit item";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.EditItemToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteItemToolStripMenuItem.Text = "Delete item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.DeleteItemToolStripMenuItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Silver;
            this.btnAddItem.Location = new System.Drawing.Point(15, 15);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(80, 25);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(15, 45);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 15);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search item";
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(15, 70);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(200, 20);
            this.txtSearchBar.TabIndex = 3;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.TxtSearchBar_TextChanged);
            // 
            // listBoxDictionary
            // 
            this.listBoxDictionary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxDictionary.ContextMenuStrip = this.contextMenuStrip;
            this.listBoxDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDictionary.FormattingEnabled = true;
            this.listBoxDictionary.ItemHeight = 16;
            this.listBoxDictionary.Location = new System.Drawing.Point(15, 100);
            this.listBoxDictionary.Name = "listBoxDictionary";
            this.listBoxDictionary.Size = new System.Drawing.Size(200, 386);
            this.listBoxDictionary.TabIndex = 4;
            this.listBoxDictionary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxDictionary_MouseClick);
            this.listBoxDictionary.SelectedIndexChanged += new System.EventHandler(this.ListBoxDictionary_SelectedIndexChanged);
            // 
            // lblNonWrittenWordsWarnin
            // 
            this.lblNonWrittenWordsWarnin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNonWrittenWordsWarnin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNonWrittenWordsWarnin.ForeColor = System.Drawing.Color.Red;
            this.lblNonWrittenWordsWarnin.Location = new System.Drawing.Point(15, 495);
            this.lblNonWrittenWordsWarnin.Name = "lblNonWrittenWordsWarnin";
            this.lblNonWrittenWordsWarnin.Size = new System.Drawing.Size(200, 25);
            this.lblNonWrittenWordsWarnin.TabIndex = 5;
            // 
            // lblResultSign
            // 
            this.lblResultSign.Location = new System.Drawing.Point(250, 70);
            this.lblResultSign.Name = "lblResultSign";
            this.lblResultSign.Size = new System.Drawing.Size(100, 15);
            this.lblResultSign.TabIndex = 6;
            this.lblResultSign.Text = "Item Translation:";
            // 
            // lblTranslation
            // 
            this.lblTranslation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTranslation.Location = new System.Drawing.Point(250, 100);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(350, 50);
            this.lblTranslation.TabIndex = 7;
            // 
            // lblIsWritten
            // 
            this.lblIsWritten.BackColor = System.Drawing.Color.Red;
            this.lblIsWritten.Location = new System.Drawing.Point(250, 160);
            this.lblIsWritten.Name = "lblIsWritten";
            this.lblIsWritten.Size = new System.Drawing.Size(50, 15);
            this.lblIsWritten.TabIndex = 8;
            this.lblIsWritten.MouseEnter += new System.EventHandler(this.LblIsWritten_MouseEnter);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(510, 490);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MyDictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(619, 541);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblIsWritten);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.lblResultSign);
            this.Controls.Add(this.lblNonWrittenWordsWarnin);
            this.Controls.Add(this.listBoxDictionary);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnAddItem);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MyDictionaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyDictionaryForm_FormClosing);
            this.Load += new System.EventHandler(this.MyDictionaryForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem markAsWrittenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.ListBox listBoxDictionary;
        private System.Windows.Forms.Label lblNonWrittenWordsWarnin;
        private System.Windows.Forms.Label lblResultSign;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.Label lblIsWritten;
        private System.Windows.Forms.Button btnClose;
    }
}

